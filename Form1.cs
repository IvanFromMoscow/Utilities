using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Utilities
{
    public partial class MainForm : Form
    {
        int count = 0;
        Random rnd;
        public MainForm()
        {
            InitializeComponent();
            rnd = new Random();
        }

        private void tsimExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsimAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа с набором утилит, которые помогут в освоении программирования.\nАвтор: Бусыгин И.А.", "О программе");
        }

        private void BtnPlus_Click(object sender, EventArgs e)
        {
            lblIndicator.Text = (++count).ToString();
        }

        private void BtnMinus_Click(object sender, EventArgs e)
        {
            lblIndicator.Text = Convert.ToString(--count);
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            count = 0;
            lblIndicator.Text = count.ToString();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            lblRandom.Text = rnd.Next(Convert.ToInt32(nudMinRandomRange.Value), Convert.ToInt32(nudMaxRandomRange.Value) + 1).ToString();
        }
    }
}
