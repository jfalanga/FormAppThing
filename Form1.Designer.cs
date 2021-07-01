
namespace FormAppThing
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtNum = new System.Windows.Forms.TextBox();
            this.Txt1stName = new System.Windows.Forms.TextBox();
            this.TxtLstName = new System.Windows.Forms.TextBox();
            this.ChkC101 = new System.Windows.Forms.CheckBox();
            this.ChkC102 = new System.Windows.Forms.CheckBox();
            this.ChkP101 = new System.Windows.Forms.CheckBox();
            this.ChkP110 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LblScores = new System.Windows.Forms.Label();
            this.TxtC101 = new System.Windows.Forms.TextBox();
            this.TxtC102 = new System.Windows.Forms.TextBox();
            this.TxtP101 = new System.Windows.Forms.TextBox();
            this.TxtP110 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RadPrg = new System.Windows.Forms.RadioButton();
            this.RadWeb = new System.Windows.Forms.RadioButton();
            this.RadPhil = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // TxtNum
            // 
            this.TxtNum.Location = new System.Drawing.Point(135, 6);
            this.TxtNum.Name = "TxtNum";
            this.TxtNum.Size = new System.Drawing.Size(274, 27);
            this.TxtNum.TabIndex = 3;
            this.TxtNum.TextChanged += new System.EventHandler(this.TxtNum_TextChanged);
            // 
            // Txt1stName
            // 
            this.Txt1stName.Location = new System.Drawing.Point(135, 65);
            this.Txt1stName.Name = "Txt1stName";
            this.Txt1stName.Size = new System.Drawing.Size(274, 27);
            this.Txt1stName.TabIndex = 4;
            // 
            // TxtLstName
            // 
            this.TxtLstName.Location = new System.Drawing.Point(135, 128);
            this.TxtLstName.Name = "TxtLstName";
            this.TxtLstName.Size = new System.Drawing.Size(274, 27);
            this.TxtLstName.TabIndex = 5;
            this.TxtLstName.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // ChkC101
            // 
            this.ChkC101.AutoSize = true;
            this.ChkC101.Location = new System.Drawing.Point(107, 217);
            this.ChkC101.Name = "ChkC101";
            this.ChkC101.Size = new System.Drawing.Size(80, 24);
            this.ChkC101.TabIndex = 6;
            this.ChkC101.Text = "CIS 101";
            this.ChkC101.UseVisualStyleBackColor = true;
            this.ChkC101.CheckedChanged += new System.EventHandler(this.CheckChange);
            // 
            // ChkC102
            // 
            this.ChkC102.AutoSize = true;
            this.ChkC102.Location = new System.Drawing.Point(107, 261);
            this.ChkC102.Name = "ChkC102";
            this.ChkC102.Size = new System.Drawing.Size(80, 24);
            this.ChkC102.TabIndex = 7;
            this.ChkC102.Text = "CIS 102";
            this.ChkC102.UseVisualStyleBackColor = true;
            this.ChkC102.CheckedChanged += new System.EventHandler(this.CheckChange);
            // 
            // ChkP101
            // 
            this.ChkP101.AutoSize = true;
            this.ChkP101.Location = new System.Drawing.Point(107, 302);
            this.ChkP101.Name = "ChkP101";
            this.ChkP101.Size = new System.Drawing.Size(83, 24);
            this.ChkP101.TabIndex = 8;
            this.ChkP101.Text = "Phil 101";
            this.ChkP101.UseVisualStyleBackColor = true;
            this.ChkP101.CheckedChanged += new System.EventHandler(this.CheckChange);
            // 
            // ChkP110
            // 
            this.ChkP110.AutoSize = true;
            this.ChkP110.Location = new System.Drawing.Point(107, 347);
            this.ChkP110.Name = "ChkP110";
            this.ChkP110.Size = new System.Drawing.Size(83, 24);
            this.ChkP110.TabIndex = 9;
            this.ChkP110.Text = "Phil 110";
            this.ChkP110.UseVisualStyleBackColor = true;
            this.ChkP110.CheckedChanged += new System.EventHandler(this.CheckChange);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(107, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Courses:";
            // 
            // LblScores
            // 
            this.LblScores.AutoSize = true;
            this.LblScores.Location = new System.Drawing.Point(264, 173);
            this.LblScores.Name = "LblScores";
            this.LblScores.Size = new System.Drawing.Size(52, 20);
            this.LblScores.TabIndex = 11;
            this.LblScores.Text = "Scores";
            this.LblScores.Visible = false;
            // 
            // TxtC101
            // 
            this.TxtC101.Location = new System.Drawing.Point(252, 214);
            this.TxtC101.Name = "TxtC101";
            this.TxtC101.Size = new System.Drawing.Size(125, 27);
            this.TxtC101.TabIndex = 12;
            this.TxtC101.Visible = false;
            this.TxtC101.TextChanged += new System.EventHandler(this.TxtNum_TextChanged);
            // 
            // TxtC102
            // 
            this.TxtC102.Location = new System.Drawing.Point(252, 258);
            this.TxtC102.Name = "TxtC102";
            this.TxtC102.Size = new System.Drawing.Size(125, 27);
            this.TxtC102.TabIndex = 13;
            this.TxtC102.Visible = false;
            this.TxtC102.TextChanged += new System.EventHandler(this.TxtNum_TextChanged);
            // 
            // TxtP101
            // 
            this.TxtP101.Location = new System.Drawing.Point(252, 300);
            this.TxtP101.Name = "TxtP101";
            this.TxtP101.Size = new System.Drawing.Size(125, 27);
            this.TxtP101.TabIndex = 14;
            this.TxtP101.Visible = false;
            this.TxtP101.TextChanged += new System.EventHandler(this.TxtNum_TextChanged);
            // 
            // TxtP110
            // 
            this.TxtP110.Location = new System.Drawing.Point(252, 344);
            this.TxtP110.Name = "TxtP110";
            this.TxtP110.Size = new System.Drawing.Size(125, 27);
            this.TxtP110.TabIndex = 15;
            this.TxtP110.Visible = false;
            this.TxtP110.TextChanged += new System.EventHandler(this.TxtNum_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RadPrg);
            this.groupBox1.Controls.Add(this.RadWeb);
            this.groupBox1.Controls.Add(this.RadPhil);
            this.groupBox1.Location = new System.Drawing.Point(451, 226);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 145);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Major:";
            // 
            // RadPrg
            // 
            this.RadPrg.AutoSize = true;
            this.RadPrg.Checked = true;
            this.RadPrg.Location = new System.Drawing.Point(102, 83);
            this.RadPrg.Name = "RadPrg";
            this.RadPrg.Size = new System.Drawing.Size(121, 24);
            this.RadPrg.TabIndex = 2;
            this.RadPrg.TabStop = true;
            this.RadPrg.Text = "Programming";
            this.RadPrg.UseVisualStyleBackColor = true;
            // 
            // RadWeb
            // 
            this.RadWeb.AutoSize = true;
            this.RadWeb.Location = new System.Drawing.Point(51, 53);
            this.RadWeb.Name = "RadWeb";
            this.RadWeb.Size = new System.Drawing.Size(110, 24);
            this.RadWeb.TabIndex = 1;
            this.RadWeb.Text = "Web Design";
            this.RadWeb.UseVisualStyleBackColor = true;
            // 
            // RadPhil
            // 
            this.RadPhil.AutoSize = true;
            this.RadPhil.Location = new System.Drawing.Point(3, 23);
            this.RadPhil.Name = "RadPhil";
            this.RadPhil.Size = new System.Drawing.Size(102, 24);
            this.RadPhil.TabIndex = 0;
            this.RadPhil.Text = "Philosophy";
            this.RadPhil.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(344, 398);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 29);
            this.button1.TabIndex = 18;
            this.button1.Text = "Submit to ME!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(469, 32);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(232, 161);
            this.textBox8.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TxtP110);
            this.Controls.Add(this.TxtP101);
            this.Controls.Add(this.TxtC102);
            this.Controls.Add(this.TxtC101);
            this.Controls.Add(this.LblScores);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ChkP110);
            this.Controls.Add(this.ChkP101);
            this.Controls.Add(this.ChkC102);
            this.Controls.Add(this.ChkC101);
            this.Controls.Add(this.TxtLstName);
            this.Controls.Add(this.Txt1stName);
            this.Controls.Add(this.TxtNum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtNum;
        private System.Windows.Forms.TextBox Txt1stName;
        private System.Windows.Forms.TextBox TxtLstName;
        private System.Windows.Forms.CheckBox ChkC101;
        private System.Windows.Forms.CheckBox ChkC102;
        private System.Windows.Forms.CheckBox ChkP101;
        private System.Windows.Forms.CheckBox ChkP110;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblScores;
        private System.Windows.Forms.TextBox TxtC101;
        private System.Windows.Forms.TextBox TxtC102;
        private System.Windows.Forms.TextBox TxtP101;
        private System.Windows.Forms.TextBox TxtP110;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RadPhil;
        private System.Windows.Forms.RadioButton RadPrg;
        private System.Windows.Forms.RadioButton RadWeb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox8;
    }
}

