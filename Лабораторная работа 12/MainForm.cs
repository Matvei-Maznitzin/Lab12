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
    public partial class MainForm : Form
    {
        private string text;
        private bool isFirstLetter;

        public string InputText { get => text; set => text = value; }
        public bool IsFirstLetter { get => isFirstLetter; set => isFirstLetter = value; }

        public MainForm()
        {
            InitializeComponent();
        }

        private void beginButton_Click(object sender, EventArgs e)
        {
            BeginForm beginForm = new BeginForm();
            beginForm.Owner = this;
            beginForm.ShowDialog();
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Мазницин Матвей Андреевич\nгруппа 32919/3\n16 вариант", "Информация о пользователе");
        }

        private void workButton_Click(object sender, EventArgs e)
        {
            ResultForm resultForm = new ResultForm();
            resultForm.Owner = this;
            resultForm.ShowDialog();
        }
    }
}
