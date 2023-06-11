namespace Vocabulary
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menüToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.csereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.szótárakToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.angolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.finnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nemetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kilépToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbAnswer = new System.Windows.Forms.TextBox();
            this.bNextWord = new System.Windows.Forms.Button();
            this.bRandWord = new System.Windows.Forms.Button();
            this.labelWordDisplay = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.bExample = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.bCheck = new System.Windows.Forms.Button();
            this.tbSolution = new System.Windows.Forms.TextBox();
            this.tbExample = new System.Windows.Forms.TextBox();
            this.újToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.szóToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.szótárToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bDelete = new System.Windows.Forms.Button();
            this.szólistaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menüToolStripMenuItem,
            this.újToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(582, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menüToolStripMenuItem
            // 
            this.menüToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.csereToolStripMenuItem,
            this.szólistaToolStripMenuItem,
            this.szótárakToolStripMenuItem,
            this.kilépToolStripMenuItem});
            this.menüToolStripMenuItem.Name = "menüToolStripMenuItem";
            this.menüToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menüToolStripMenuItem.Text = "Menü";
            // 
            // csereToolStripMenuItem
            // 
            this.csereToolStripMenuItem.Name = "csereToolStripMenuItem";
            this.csereToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.csereToolStripMenuItem.Text = "Csere";
            this.csereToolStripMenuItem.Click += new System.EventHandler(this.csereToolStripMenuItem_Click);
            // 
            // szótárakToolStripMenuItem
            // 
            this.szótárakToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.angolToolStripMenuItem,
            this.danToolStripMenuItem,
            this.finnToolStripMenuItem,
            this.nemetToolStripMenuItem});
            this.szótárakToolStripMenuItem.Name = "szótárakToolStripMenuItem";
            this.szótárakToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.szótárakToolStripMenuItem.Text = "Szótárak";
            // 
            // angolToolStripMenuItem
            // 
            this.angolToolStripMenuItem.Name = "angolToolStripMenuItem";
            this.angolToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.angolToolStripMenuItem.Text = "Angol";
            this.angolToolStripMenuItem.Click += new System.EventHandler(this.nyelvToolStripMenuItem_Click);
            // 
            // danToolStripMenuItem
            // 
            this.danToolStripMenuItem.Name = "danToolStripMenuItem";
            this.danToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.danToolStripMenuItem.Text = "Dán";
            this.danToolStripMenuItem.Click += new System.EventHandler(this.nyelvToolStripMenuItem_Click);
            // 
            // finnToolStripMenuItem
            // 
            this.finnToolStripMenuItem.Name = "finnToolStripMenuItem";
            this.finnToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.finnToolStripMenuItem.Text = "Finn";
            this.finnToolStripMenuItem.Click += new System.EventHandler(this.nyelvToolStripMenuItem_Click);
            // 
            // nemetToolStripMenuItem
            // 
            this.nemetToolStripMenuItem.Name = "nemetToolStripMenuItem";
            this.nemetToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nemetToolStripMenuItem.Text = "Német";
            this.nemetToolStripMenuItem.Click += new System.EventHandler(this.nyelvToolStripMenuItem_Click);
            // 
            // kilépToolStripMenuItem
            // 
            this.kilépToolStripMenuItem.Name = "kilépToolStripMenuItem";
            this.kilépToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kilépToolStripMenuItem.Text = "Kilép";
            this.kilépToolStripMenuItem.Click += new System.EventHandler(this.kilepToolStripMenuItem_Click);
            // 
            // tbAnswer
            // 
            this.tbAnswer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbAnswer.BackColor = System.Drawing.Color.White;
            this.tbAnswer.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAnswer.Location = new System.Drawing.Point(74, 32);
            this.tbAnswer.Name = "tbAnswer";
            this.tbAnswer.Size = new System.Drawing.Size(189, 26);
            this.tbAnswer.TabIndex = 1;
            this.tbAnswer.Tag = "";
            this.tbAnswer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbAnswer_KeyDown);
            // 
            // bNextWord
            // 
            this.bNextWord.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bNextWord.BackColor = System.Drawing.Color.MintCream;
            this.bNextWord.FlatAppearance.BorderSize = 0;
            this.bNextWord.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bNextWord.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.bNextWord.Location = new System.Drawing.Point(55, 99);
            this.bNextWord.Name = "bNextWord";
            this.bNextWord.Size = new System.Drawing.Size(129, 35);
            this.bNextWord.TabIndex = 2;
            this.bNextWord.Text = "Következő szó";
            this.bNextWord.UseVisualStyleBackColor = false;
            this.bNextWord.Click += new System.EventHandler(this.bNextWord_Click);
            // 
            // bRandWord
            // 
            this.bRandWord.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bRandWord.BackColor = System.Drawing.Color.MintCream;
            this.bRandWord.FlatAppearance.BorderSize = 0;
            this.bRandWord.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRandWord.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.bRandWord.Location = new System.Drawing.Point(54, 160);
            this.bRandWord.Name = "bRandWord";
            this.bRandWord.Size = new System.Drawing.Size(129, 35);
            this.bRandWord.TabIndex = 3;
            this.bRandWord.Text = "Random szó";
            this.bRandWord.UseVisualStyleBackColor = false;
            this.bRandWord.Click += new System.EventHandler(this.bRandWord_Click);
            // 
            // labelWordDisplay
            // 
            this.labelWordDisplay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelWordDisplay.AutoSize = true;
            this.labelWordDisplay.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWordDisplay.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labelWordDisplay.Location = new System.Drawing.Point(50, 27);
            this.labelWordDisplay.MaximumSize = new System.Drawing.Size(220, 35);
            this.labelWordDisplay.MinimumSize = new System.Drawing.Size(129, 35);
            this.labelWordDisplay.Name = "labelWordDisplay";
            this.labelWordDisplay.Size = new System.Drawing.Size(129, 35);
            this.labelWordDisplay.TabIndex = 4;
            this.labelWordDisplay.Text = "Nyelv: Angol";
            this.labelWordDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.GhostWhite;
            this.splitContainer1.Panel1.Controls.Add(this.bDelete);
            this.splitContainer1.Panel1.Controls.Add(this.bExample);
            this.splitContainer1.Panel1.Controls.Add(this.bRandWord);
            this.splitContainer1.Panel1.Controls.Add(this.labelWordDisplay);
            this.splitContainer1.Panel1.Controls.Add(this.bNextWord);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(582, 439);
            this.splitContainer1.SplitterDistance = 239;
            this.splitContainer1.TabIndex = 5;
            // 
            // bExample
            // 
            this.bExample.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bExample.BackColor = System.Drawing.Color.MintCream;
            this.bExample.FlatAppearance.BorderSize = 0;
            this.bExample.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bExample.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.bExample.Location = new System.Drawing.Point(54, 220);
            this.bExample.Name = "bExample";
            this.bExample.Size = new System.Drawing.Size(129, 35);
            this.bExample.TabIndex = 5;
            this.bExample.Text = "Példamondat";
            this.bExample.UseVisualStyleBackColor = false;
            this.bExample.Click += new System.EventHandler(this.bExample_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.Aquamarine;
            this.splitContainer2.Panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer2.Panel1.BackgroundImage")));
            this.splitContainer2.Panel1.Controls.Add(this.bCheck);
            this.splitContainer2.Panel1.Controls.Add(this.tbSolution);
            this.splitContainer2.Panel1.Controls.Add(this.tbAnswer);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tbExample);
            this.splitContainer2.Size = new System.Drawing.Size(339, 439);
            this.splitContainer2.SplitterDistance = 218;
            this.splitContainer2.TabIndex = 6;
            // 
            // bCheck
            // 
            this.bCheck.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bCheck.BackColor = System.Drawing.Color.MintCream;
            this.bCheck.FlatAppearance.BorderSize = 0;
            this.bCheck.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCheck.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.bCheck.Location = new System.Drawing.Point(102, 90);
            this.bCheck.Name = "bCheck";
            this.bCheck.Size = new System.Drawing.Size(129, 35);
            this.bCheck.TabIndex = 5;
            this.bCheck.Text = "Ellenőriz";
            this.bCheck.UseVisualStyleBackColor = false;
            this.bCheck.Click += new System.EventHandler(this.bCheck_Click);
            this.bCheck.MouseHover += new System.EventHandler(this.bCheck_MouseHover);
            // 
            // tbSolution
            // 
            this.tbSolution.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbSolution.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSolution.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.tbSolution.Location = new System.Drawing.Point(74, 154);
            this.tbSolution.Name = "tbSolution";
            this.tbSolution.Size = new System.Drawing.Size(189, 25);
            this.tbSolution.TabIndex = 0;
            this.tbSolution.Text = "Megoldás";
            // 
            // tbExample
            // 
            this.tbExample.BackColor = System.Drawing.Color.GhostWhite;
            this.tbExample.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbExample.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbExample.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.tbExample.Location = new System.Drawing.Point(0, 0);
            this.tbExample.Multiline = true;
            this.tbExample.Name = "tbExample";
            this.tbExample.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbExample.Size = new System.Drawing.Size(339, 217);
            this.tbExample.TabIndex = 0;
            // 
            // újToolStripMenuItem1
            // 
            this.újToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.szóToolStripMenuItem1,
            this.szótárToolStripMenuItem1});
            this.újToolStripMenuItem1.Name = "újToolStripMenuItem1";
            this.újToolStripMenuItem1.Size = new System.Drawing.Size(30, 20);
            this.újToolStripMenuItem1.Text = "Új";
            // 
            // szóToolStripMenuItem1
            // 
            this.szóToolStripMenuItem1.Name = "szóToolStripMenuItem1";
            this.szóToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.szóToolStripMenuItem1.Text = "Szó (Ctrl+N)";
            this.szóToolStripMenuItem1.Click += new System.EventHandler(this.szóToolStripMenuItem1_Click);
            // 
            // szótárToolStripMenuItem1
            // 
            this.szótárToolStripMenuItem1.Name = "szótárToolStripMenuItem1";
            this.szótárToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.szótárToolStripMenuItem1.Text = "Szótár";
            // 
            // bDelete
            // 
            this.bDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bDelete.BackColor = System.Drawing.Color.MintCream;
            this.bDelete.FlatAppearance.BorderSize = 0;
            this.bDelete.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDelete.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.bDelete.Location = new System.Drawing.Point(55, 364);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(129, 35);
            this.bDelete.TabIndex = 6;
            this.bDelete.Text = "Szó törlése";
            this.bDelete.UseVisualStyleBackColor = false;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // szólistaToolStripMenuItem
            // 
            this.szólistaToolStripMenuItem.Name = "szólistaToolStripMenuItem";
            this.szólistaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.szólistaToolStripMenuItem.Text = "Szólista";
            this.szólistaToolStripMenuItem.Click += new System.EventHandler(this.szólistaToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 463);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Vocabulary Beta";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TextBox tbAnswer;
        private System.Windows.Forms.Button bNextWord;
        private System.Windows.Forms.Button bRandWord;
        private System.Windows.Forms.Label labelWordDisplay;
        private System.Windows.Forms.ToolStripMenuItem menüToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem szótárakToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem angolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem finnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nemetToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox tbSolution;
        private System.Windows.Forms.Button bCheck;
        private System.Windows.Forms.ToolStripMenuItem kilépToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem csereToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TextBox tbExample;
        private System.Windows.Forms.Button bExample;
        private System.Windows.Forms.ToolStripMenuItem újToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem szóToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem szótárToolStripMenuItem1;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.ToolStripMenuItem szólistaToolStripMenuItem;
    }
}

