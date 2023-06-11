using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;


/// <summary>
/// cd \..\Vocabulary\bin\Debug 
/// Vocabulary.exe>log.txt
/// </summary>

namespace Vocabulary
{
    public delegate void directionChangingDelegate();
    public delegate void langChangingDelegate();

    public class Word
    {
        private string hun;
        private string foreign;
        private string description;
        private string synonyms;

        public string Hun { get; set; }
        public string Foreign { get; set; }
        public string Description {
            get { return description; }
            set
            {
                if (value == "")
                    description = "Nincs elérhető példamondat!";
                else { description = value; }       
            }
        }
        public string Synonyms
        {
            get { return synonyms; }
            set
            {
                if (value == "")
                    synonyms = "Nincs elérhető szinonima!";
                else { synonyms = value; }
            }
        }
    }

    enum Languages:short
    {
        angol,        
        dan,
        finn,
        nemet
    }

    public class Dictionary
    {
        public event directionChangingDelegate DirChanger;
        public event langChangingDelegate LangChanger;
        private List<Word> wordList = new List<Word>();
        private short lang = 0;
        //default: questioning hungarian words 
        private bool direction = true;

        private static Dictionary instance = null;
        private static readonly object lockObject = new object();


        public short Lang {
            get { return lang; }
            set
            {
                if (value < (Enum.GetNames(typeof(Languages)).Length))
                    lang = value;
            }
        }
        public bool Direction {
            get { return direction; }
            private set
            {
                direction = value;
                if (DirChanger != null)
                    DirChanger();
            }
        }

        //thread-safe singleton constructor
        public static Dictionary Instance
        {
            get
            {
                lock (lockObject)
                {
                    if(instance == null)
                    {
                        instance = new Dictionary();
                    }
                    return instance;
                }
            }
        }

        public void Read()
        {
            Console.WriteLine("Nyelv:" + Enum.GetName(typeof(Languages), Lang));
            try
            {
                FileStream fs = new FileStream(Enum.GetName(typeof(Languages), Lang) + ".txt", FileMode.Open);
                StreamReader sr = new StreamReader(fs, Encoding.UTF8);
                while (!sr.EndOfStream)
                {
                    string[] line = sr.ReadLine().Split(':');
                    Word word = new Word();
                    word.Foreign = line[0];
                    word.Hun = line[1];
                    if (line.Length < 3)
                        word.Description = "";
                    else { word.Description = line[2]; }
                    wordList.Add(word);
                }
                sr.Close();
                fs.Close();
            }
            catch (Exception ex) { Console.WriteLine("Error during reading..." + ex); }
            finally { /*ListWords();*/ }
        }
        public void ListWords()
        {
            foreach(Word word in wordList)
            {
                Console.WriteLine(word.Hun + "\t" + word.Foreign);
            }
        }
        public string getWordList()
        {
            string str = "";
            foreach (Word word in wordList)
            {
                str = string.Concat(str, word.Hun + " : " + word.Foreign + Environment.NewLine);
            }
            Console.WriteLine(str);
            return str;
        }

        public Word NextWord(Word n)
        {
            try
            {
                //Console.WriteLine("A keresett szó: " + n.Hun + " : " + n.Foreign);
                if(wordList.IndexOf(n)<wordList.Count-1 && wordList.IndexOf(n)>-1)
                    return (wordList[wordList.IndexOf(n) + 1]);
                //ha utolsó szó vagy nincs a listában
                return (wordList[0]);                
            }
            catch {
                Console.WriteLine("Error: Could not find next word!");
                return wordList[0];
            }
        }

        public Word RandWord()
        {
            var rand = new Random();
            return wordList[rand.Next(wordList.Count)];
        }

        //note to self: always use the property instead of attribute (in class too!)
        public void ChangeDirection()
        {
            //Console.WriteLine("Incoming direction: " + Direction);
            if (Direction)
                Direction = false;
            else { Direction = true; }
            //Console.WriteLine("New direction: " + Direction);
        }

        //erase existing words and read a new dictionary
        //do not change the dictionary language here!
        public void ChangeDictionary()
        {
            wordList.Clear();
            Console.WriteLine("Building new dictionary...");
            Read();
            if (LangChanger != null)
                LangChanger();
        }

        //delete current word and return next in list
        public void DeleteWord(Word w)
        {
            wordList.Remove(w);
            Console.WriteLine("Word removed!");
            ////Töröljük az adatbázisból is!
        }

        public void AddWord(Word w)
        {
            if(w == null)
            {
                throw new Exception("Hiba az új szó beolvasásakor!");
            }
            wordList.Add(w);
            Console.WriteLine("Word added!" +Environment.NewLine + w.Hun + " : " + w.Foreign + 
                Environment.NewLine + w.Description + "\t" + w.Synonyms);
            ////Adjuk hozzá az adatbázishoz is!
        }
    }
}
