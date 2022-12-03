using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Лабораторная_работа_12
{
    public partial class ResultForm : Form
    {
        public ResultForm()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ResultForm_Load(object sender, EventArgs e)
        {
            MainForm form1 = this.Owner as MainForm;
            CultureInfo cultureInfo = Thread.CurrentThread.CurrentCulture;
            TextInfo textInfo = cultureInfo.TextInfo;
            if (form1.IsFirstLetter)
                resultTextBox.Text = form1.InputText.Substring(0, 1).ToUpper() + form1.InputText.Substring(1);
            else
                resultTextBox.Text = textInfo.ToTitleCase(form1.InputText);
        }
    }
}
