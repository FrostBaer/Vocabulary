namespace Vocabulary
{
    partial class AddWordDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddWordDialog));
            this.bAdd = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.labelAddNewWord = new System.Windows.Forms.Label();
            this.tbHun = new System.Windows.Forms.TextBox();
            this.labelHun = new System.Windows.Forms.Label();
            this.labelMeaning = new System.Windows.Forms.Label();
            this.labelAlt1 = new System.Windows.Forms.Label();
            this.labelAlt2 = new System.Windows.Forms.Label();
            this.labelSynonym = new System.Windows.Forms.Label();
            this.tbMeaning = new System.Windows.Forms.TextBox();
            this.tbAlt1 = new System.Windows.Forms.TextBox();
            this.tbAlt2 = new System.Windows.Forms.TextBox();
            this.tbSynonym = new System.Windows.Forms.TextBox();
            this.labelExample = new System.Windows.Forms.Label();
            this.tbExample = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbLang = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bAdd
            // 
            this.bAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bAdd.BackColor = System.Drawing.Color.MintCream;
            this.bAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bAdd.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAdd.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.bAdd.Location = new System.Drawing.Point(409, 240);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(82, 29);
            this.bAdd.TabIndex = 0;
            this.bAdd.Text = "Hozzáad";
            this.bAdd.UseVisualStyleBackColor = false;
            // 
            // bCancel
            // 
            this.bCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bCancel.BackColor = System.Drawing.Color.MintCream;
            this.bCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bCancel.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCancel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.bCancel.Location = new System.Drawing.Point(409, 282);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(82, 29);
            this.bCancel.TabIndex = 1;
            this.bCancel.Text = "Mégsem";
            this.bCancel.UseVisualStyleBackColor = false;
            // 
            // labelAddNewWord
            // 
            this.labelAddNewWord.AutoSize = true;
            this.labelAddNewWord.BackColor = System.Drawing.Color.MintCream;
            this.labelAddNewWord.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddNewWord.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labelAddNewWord.Location = new System.Drawing.Point(169, 29);
            this.labelAddNewWord.Name = "labelAddNewWord";
            this.labelAddNewWord.Size = new System.Drawing.Size(176, 25);
            this.labelAddNewWord.TabIndex = 2;
            this.labelAddNewWord.Text = "Új szó hozzáadása";
            // 
            // tbHun
            // 
            this.tbHun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbHun.Location = new System.Drawing.Point(143, 81);
            this.tbHun.Multiline = true;
            this.tbHun.Name = "tbHun";
            this.tbHun.Size = new System.Drawing.Size(226, 20);
            this.tbHun.TabIndex = 3;
            // 
            // labelHun
            // 
            this.labelHun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelHun.BackColor = System.Drawing.Color.MintCream;
            this.labelHun.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHun.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labelHun.Location = new System.Drawing.Point(26, 82);
            this.labelHun.Name = "labelHun";
            this.labelHun.Size = new System.Drawing.Size(100, 20);
            this.labelHun.TabIndex = 4;
            this.labelHun.Text = "Magyar *";
            this.labelHun.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMeaning
            // 
            this.labelMeaning.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelMeaning.BackColor = System.Drawing.Color.MintCream;
            this.labelMeaning.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMeaning.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labelMeaning.Location = new System.Drawing.Point(26, 121);
            this.labelMeaning.Name = "labelMeaning";
            this.labelMeaning.Size = new System.Drawing.Size(100, 20);
            this.labelMeaning.TabIndex = 5;
            this.labelMeaning.Text = "Jelentés";
            this.labelMeaning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelAlt1
            // 
            this.labelAlt1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelAlt1.BackColor = System.Drawing.Color.MintCream;
            this.labelAlt1.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlt1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labelAlt1.Location = new System.Drawing.Point(26, 165);
            this.labelAlt1.Name = "labelAlt1";
            this.labelAlt1.Size = new System.Drawing.Size(100, 20);
            this.labelAlt1.TabIndex = 6;
            this.labelAlt1.Text = "Alternatív 1";
            this.labelAlt1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelAlt2
            // 
            this.labelAlt2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelAlt2.BackColor = System.Drawing.Color.MintCream;
            this.labelAlt2.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlt2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labelAlt2.Location = new System.Drawing.Point(26, 206);
            this.labelAlt2.Name = "labelAlt2";
            this.labelAlt2.Size = new System.Drawing.Size(100, 20);
            this.labelAlt2.TabIndex = 7;
            this.labelAlt2.Text = "Alternatív 2";
            this.labelAlt2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSynonym
            // 
            this.labelSynonym.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelSynonym.BackColor = System.Drawing.Color.MintCream;
            this.labelSynonym.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSynonym.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labelSynonym.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelSynonym.Location = new System.Drawing.Point(26, 244);
            this.labelSynonym.Name = "labelSynonym";
            this.labelSynonym.Size = new System.Drawing.Size(100, 20);
            this.labelSynonym.TabIndex = 8;
            this.labelSynonym.Text = "Szinonimák";
            this.labelSynonym.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbMeaning
            // 
            this.tbMeaning.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbMeaning.Location = new System.Drawing.Point(143, 120);
            this.tbMeaning.Multiline = true;
            this.tbMeaning.Name = "tbMeaning";
            this.tbMeaning.Size = new System.Drawing.Size(226, 20);
            this.tbMeaning.TabIndex = 9;
            // 
            // tbAlt1
            // 
            this.tbAlt1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbAlt1.Location = new System.Drawing.Point(143, 164);
            this.tbAlt1.Multiline = true;
            this.tbAlt1.Name = "tbAlt1";
            this.tbAlt1.Size = new System.Drawing.Size(226, 20);
            this.tbAlt1.TabIndex = 10;
            // 
            // tbAlt2
            // 
            this.tbAlt2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbAlt2.Location = new System.Drawing.Point(143, 205);
            this.tbAlt2.Multiline = true;
            this.tbAlt2.Name = "tbAlt2";
            this.tbAlt2.Size = new System.Drawing.Size(226, 20);
            this.tbAlt2.TabIndex = 11;
            // 
            // tbSynonym
            // 
            this.tbSynonym.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbSynonym.Location = new System.Drawing.Point(143, 243);
            this.tbSynonym.Multiline = true;
            this.tbSynonym.Name = "tbSynonym";
            this.tbSynonym.Size = new System.Drawing.Size(226, 20);
            this.tbSynonym.TabIndex = 12;
            // 
            // labelExample
            // 
            this.labelExample.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelExample.BackColor = System.Drawing.Color.MintCream;
            this.labelExample.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExample.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labelExample.Location = new System.Drawing.Point(26, 286);
            this.labelExample.Name = "labelExample";
            this.labelExample.Size = new System.Drawing.Size(107, 20);
            this.labelExample.TabIndex = 13;
            this.labelExample.Text = "Példamondatok";
            // 
            // tbExample
            // 
            this.tbExample.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbExample.Location = new System.Drawing.Point(144, 285);
            this.tbExample.Multiline = true;
            this.tbExample.Name = "tbExample";
            this.tbExample.Size = new System.Drawing.Size(226, 20);
            this.tbExample.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.MintCream;
            this.label1.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(406, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Szótár";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbLang
            // 
            this.lbLang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbLang.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLang.FormattingEnabled = true;
            this.lbLang.ItemHeight = 15;
            this.lbLang.Location = new System.Drawing.Point(409, 121);
            this.lbLang.Name = "lbLang";
            this.lbLang.Size = new System.Drawing.Size(82, 94);
            this.lbLang.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(26, 332);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 14);
            this.label2.TabIndex = 17;
            this.label2.Text = "* vagy idegennyelvű magyarázat";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddWordDialog
            // 
            this.AcceptButton = this.bAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.CancelButton = this.bCancel;
            this.ClientSize = new System.Drawing.Size(535, 355);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbLang);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbExample);
            this.Controls.Add(this.labelExample);
            this.Controls.Add(this.tbSynonym);
            this.Controls.Add(this.tbAlt2);
            this.Controls.Add(this.tbAlt1);
            this.Controls.Add(this.tbMeaning);
            this.Controls.Add(this.labelSynonym);
            this.Controls.Add(this.labelAlt2);
            this.Controls.Add(this.labelAlt1);
            this.Controls.Add(this.labelMeaning);
            this.Controls.Add(this.labelHun);
            this.Controls.Add(this.tbHun);
            this.Controls.Add(this.labelAddNewWord);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bAdd);
            this.Name = "AddWordDialog";
            this.Text = "Új szó hozzáadása";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Label labelAddNewWord;
        private System.Windows.Forms.TextBox tbHun;
        private System.Windows.Forms.Label labelHun;
        private System.Windows.Forms.Label labelMeaning;
        private System.Windows.Forms.Label labelAlt1;
        private System.Windows.Forms.Label labelAlt2;
        private System.Windows.Forms.Label labelSynonym;
        private System.Windows.Forms.TextBox tbMeaning;
        private System.Windows.Forms.TextBox tbAlt1;
        private System.Windows.Forms.TextBox tbAlt2;
        private System.Windows.Forms.TextBox tbSynonym;
        private System.Windows.Forms.Label labelExample;
        private System.Windows.Forms.TextBox tbExample;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbLang;
        private System.Windows.Forms.Label label2;
    }
}