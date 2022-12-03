namespace Лабораторная_работа_12
{
    partial class MainForm
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
            this.beginButton = new System.Windows.Forms.Button();
            this.workButton = new System.Windows.Forms.Button();
            this.aboutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // beginButton
            // 
            this.beginButton.Location = new System.Drawing.Point(177, 50);
            this.beginButton.Name = "beginButton";
            this.beginButton.Size = new System.Drawing.Size(117, 39);
            this.beginButton.TabIndex = 0;
            this.beginButton.Text = "Begin";
            this.beginButton.UseVisualStyleBackColor = true;
            this.beginButton.Click += new System.EventHandler(this.beginButton_Click);
            // 
            // workButton
            // 
            this.workButton.Location = new System.Drawing.Point(300, 50);
            this.workButton.Name = "workButton";
            this.workButton.Size = new System.Drawing.Size(117, 39);
            this.workButton.TabIndex = 1;
            this.workButton.Text = "Work";
            this.workButton.UseVisualStyleBackColor = true;
            this.workButton.Click += new System.EventHandler(this.workButton_Click);
            // 
            // aboutButton
            // 
            this.aboutButton.Location = new System.Drawing.Point(423, 50);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(117, 39);
            this.aboutButton.TabIndex = 2;
            this.aboutButton.Text = "About";
            this.aboutButton.UseVisualStyleBackColor = true;
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.aboutButton);
            this.Controls.Add(this.workButton);
            this.Controls.Add(this.beginButton);
            this.Name = "MainForm";
            this.Text = "Мазницин Матвей Андреевич, гр. 32919/3, 16 вариант";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button beginButton;
        private System.Windows.Forms.Button workButton;
        private System.Windows.Forms.Button aboutButton;
    }
}

