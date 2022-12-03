namespace Лабораторная_работа_12
{
    partial class BeginForm
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
            this.textBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.firstLetterRadioButton = new System.Windows.Forms.RadioButton();
            this.allLettersRadioButton = new System.Windows.Forms.RadioButton();
            this.okButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(12, 12);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(528, 20);
            this.textBox.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.allLettersRadioButton);
            this.groupBox1.Controls.Add(this.firstLetterRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(178, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 75);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Режим преобразования";
            // 
            // firstLetterRadioButton
            // 
            this.firstLetterRadioButton.AutoSize = true;
            this.firstLetterRadioButton.Location = new System.Drawing.Point(57, 19);
            this.firstLetterRadioButton.Name = "firstLetterRadioButton";
            this.firstLetterRadioButton.Size = new System.Drawing.Size(70, 17);
            this.firstLetterRadioButton.TabIndex = 0;
            this.firstLetterRadioButton.TabStop = true;
            this.firstLetterRadioButton.Text = "First letter";
            this.firstLetterRadioButton.UseVisualStyleBackColor = true;
            // 
            // allLettersRadioButton
            // 
            this.allLettersRadioButton.AutoSize = true;
            this.allLettersRadioButton.Location = new System.Drawing.Point(57, 42);
            this.allLettersRadioButton.Name = "allLettersRadioButton";
            this.allLettersRadioButton.Size = new System.Drawing.Size(67, 17);
            this.allLettersRadioButton.TabIndex = 1;
            this.allLettersRadioButton.TabStop = true;
            this.allLettersRadioButton.Text = "All letters";
            this.allLettersRadioButton.UseVisualStyleBackColor = true;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(230, 146);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // BeginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 181);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox);
            this.Name = "BeginForm";
            this.Text = "BeginForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton allLettersRadioButton;
        private System.Windows.Forms.RadioButton firstLetterRadioButton;
        private System.Windows.Forms.Button okButton;
    }
}