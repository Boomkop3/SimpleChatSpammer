namespace SimpleChatSpammer
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.bnGo = new System.Windows.Forms.Button();
            this.checkRemoveLines = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.numStart = new System.Windows.Forms.NumericUpDown();
            this.numLine = new System.Windows.Forms.NumericUpDown();
            this.numLetter = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLetter)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.numLetter);
            this.panel1.Controls.Add(this.numLine);
            this.panel1.Controls.Add(this.numStart);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.checkRemoveLines);
            this.panel1.Controls.Add(this.bnGo);
            this.panel1.Controls.Add(this.picLogo);
            this.panel1.Location = new System.Drawing.Point(12, 487);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1297, 128);
            this.panel1.TabIndex = 0;
            // 
            // picLogo
            // 
            this.picLogo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.picLogo.InitialImage = global::SimpleChatSpammer.Properties.Resources.VBird_mid_square;
            this.picLogo.Location = new System.Drawing.Point(3, 3);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(159, 122);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 1;
            this.picLogo.TabStop = false;
            // 
            // bnGo
            // 
            this.bnGo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bnGo.Location = new System.Drawing.Point(1080, 3);
            this.bnGo.Name = "bnGo";
            this.bnGo.Size = new System.Drawing.Size(214, 122);
            this.bnGo.TabIndex = 2;
            this.bnGo.Text = "Go!";
            this.bnGo.UseVisualStyleBackColor = true;
            this.bnGo.Click += new System.EventHandler(this.bnGo_Click);
            // 
            // checkRemoveLines
            // 
            this.checkRemoveLines.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkRemoveLines.AutoSize = true;
            this.checkRemoveLines.Checked = true;
            this.checkRemoveLines.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkRemoveLines.Location = new System.Drawing.Point(898, 81);
            this.checkRemoveLines.Name = "checkRemoveLines";
            this.checkRemoveLines.Size = new System.Drawing.Size(15, 14);
            this.checkRemoveLines.TabIndex = 6;
            this.checkRemoveLines.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(785, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Start delay";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(785, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Line delay";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(785, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Letter delay";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(785, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Removed typed lines";
            // 
            // textBox1
            // 
            this.textBox1.AcceptsReturn = true;
            this.textBox1.AcceptsTab = true;
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(15, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1291, 469);
            this.textBox1.TabIndex = 1;
            // 
            // numStart
            // 
            this.numStart.Location = new System.Drawing.Point(897, 6);
            this.numStart.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numStart.Name = "numStart";
            this.numStart.Size = new System.Drawing.Size(176, 20);
            this.numStart.TabIndex = 11;
            this.numStart.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            // 
            // numLine
            // 
            this.numLine.Location = new System.Drawing.Point(897, 30);
            this.numLine.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numLine.Name = "numLine";
            this.numLine.Size = new System.Drawing.Size(176, 20);
            this.numLine.TabIndex = 12;
            this.numLine.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // numLetter
            // 
            this.numLetter.Location = new System.Drawing.Point(897, 55);
            this.numLetter.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numLetter.Name = "numLetter";
            this.numLetter.Size = new System.Drawing.Size(176, 20);
            this.numLetter.TabIndex = 13;
            this.numLetter.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1321, 627);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(720, 420);
            this.Name = "Form1";
            this.Text = "Simple Spambot";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLetter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Button bnGo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkRemoveLines;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NumericUpDown numLetter;
        private System.Windows.Forms.NumericUpDown numLine;
        private System.Windows.Forms.NumericUpDown numStart;
    }
}

