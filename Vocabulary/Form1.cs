using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Vocabulary
{
    public partial class Form1 : Form
    {
        private Word word = new Word();
        private Word temp = new Word();
        public Form1()
        {
            InitializeComponent();
        }

        public Word Temp
        {
            get; set;
        }

        private void nyelvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //change dictionary language here!
            Console.WriteLine("Type of the sender: " + sender);
            if (sender == angolToolStripMenuItem)
            {
                Dictionary.Instance.Lang = 0;
            }                
            else if (sender == danToolStripMenuItem)
            {
                Dictionary.Instance.Lang = 1;
            }
            else if (sender == finnToolStripMenuItem)
            {
                Dictionary.Instance.Lang = 2;
            }
            else if (sender == nemetToolStripMenuItem)
            {
                Dictionary.Instance.Lang = 3;                
            }
            else { Console.WriteLine("ToolStripMenuError: nem sikerült az új nyelv kiválasztása!"); }
            labelWordDisplay.Text = ("Nyelv: " + sender);
            Dictionary.Instance.ChangeDictionary();
        }

        private void kilepToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        //just changes direction, does not show new word
        private void csereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dictionary.Instance.ChangeDirection();
        }

        //check the direction 
        //display a word from the proper language list
        private void bRandWord_Click(object sender, EventArgs e)
        {
            setDefault();
            word = Dictionary.Instance.RandWord();
            labelWordDisplay.Text = Dictionary.Instance.Direction ? word.Hun : word.Foreign;
        }

        private void bNextWord_Click(object sender, EventArgs e)
        {
            setDefault();
            word = Dictionary.Instance.NextWord(word);
            labelWordDisplay.Text = Dictionary.Instance.Direction ? word.Hun : word.Foreign;
        }

        private void bCheck_Click(object sender, EventArgs e)
        {
            if(tbSolution.Text != "") { return; }            
            tbSolution.Text = Dictionary.Instance.Direction ? word.Foreign : word.Hun;
            tbExample.Text = word.Description;
            if (tbAnswer.Text == "") { return; }            
            if (tbAnswer.Text == tbSolution.Text)
                tbAnswer.BackColor = Color.LightGreen;               
            else tbAnswer.BackColor = Color.LightPink;            
        }

        private void setDefault()
        {
            tbAnswer.BackColor = Color.White;
            tbAnswer.Text = "";
            tbSolution.Text = "";
            tbExample.Text = "";
        }

        public void directionChangedEvent()
        {
            Console.WriteLine("Direction changed!");
            setDefault();
            if (Dictionary.Instance.Direction)
            {
                labelWordDisplay.Text = word.Hun;
            }
            else { labelWordDisplay.Text = word.Foreign; }
        }

        public void languageChangedEvent()
        {
            Console.WriteLine("Language changed!");
            setDefault();            
        }

        private void tbAnswer_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                //Console.WriteLine("Enter hit!");
                bCheck_Click(sender, e);
            }
        }

        private void bExample_Click(object sender, EventArgs e)
        {
            tbExample.Text = word.Description;
        }

        private void szóToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddWordDialog wordDialog = new AddWordDialog();
            if(wordDialog.ShowDialog() == DialogResult.OK)
            {
                temp = wordDialog.Word;
                Console.WriteLine("Got new word!");
                Dictionary.Instance.AddWord(temp);
            }
            else
            {
                Console.WriteLine("No new word.");
            }
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Biztosan törölni szeretné ezt a szót az adatbázisból?","Szó törlése",MessageBoxButtons.YesNo);
            if(dialogResult == DialogResult.No) { return; }
            temp = word;            
            bNextWord_Click(sender, e);
            Dictionary.Instance.DeleteWord(temp);
            temp = null;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.N && e.Modifiers == Keys.Control)
            {
                Console.WriteLine("Ctrl+N");
                szóToolStripMenuItem1_Click(sender, e);                
            }else if(e.KeyCode == Keys.C && e.Modifiers == Keys.Control)
            {
                Console.WriteLine("Cntr+C");
                bCheck_Click(sender, e);                
            }
        }

        private void szólistaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setDefault();
            tbExample.Text = Dictionary.Instance.getWordList();
        }

        private void bCheck_MouseHover(object sender, EventArgs e)
        {
            ToolTip tp = new ToolTip();
            tp.SetToolTip(this.bCheck, "Ctrl+C");
        }
    }
}
