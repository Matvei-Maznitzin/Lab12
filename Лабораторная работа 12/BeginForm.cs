using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лабораторная_работа_12
{
    public partial class BeginForm : Form
    {
        public BeginForm()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            MainForm form1 = this.Owner as MainForm;
            form1.InputText = textBox.Text;
            form1.IsFirstLetter = firstLetterRadioButton.Checked;
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
