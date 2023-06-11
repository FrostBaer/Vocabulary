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
    public partial class AddWordDialog : Form
    {
        private Word word = new Word();

        public AddWordDialog()
        {
            InitializeComponent();
        }
        public Word Word
        {
            get
            {
                word.Hun = tbHun.Text;
                word.Foreign = tbMeaning.Text;
                word.Description = tbExample.Text;
                word.Synonyms = tbSynonym.Text;

                return word;
            }
            private set
            {
                word = value;
            }
        }
    }
}
