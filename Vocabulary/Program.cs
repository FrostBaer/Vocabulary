using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Vocabulary
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Dictionary.Instance.Read();            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 form = new Form1();
            Dictionary.Instance.DirChanger += new directionChangingDelegate(form.directionChangedEvent);
            Dictionary.Instance.LangChanger += new langChangingDelegate(form.languageChangedEvent);
            Application.Run(form); 
        }
    }
}
