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

        char[] symbols = new char[] { '*', '&', '^', '%', '$', '#', '@', '!', '(', '<', ')', '>', '-', '+', '{', '}', '[', ']', '?' };
        Dictionary<string, double> metrica;
        

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
            int n = rnd.Next(Convert.ToInt32(nudMinRandomRange.Value), Convert.ToInt32(nudMaxRandomRange.Value) + 1);
            lblRandom.Text = n.ToString();
            if (cbRandomIsRepeat.Checked)
            {
                int i = 0;
                while (tbRandomList.Text.IndexOf(n.ToString()) != -1)
                {
                    n = rnd.Next(Convert.ToInt32(nudMinRandomRange.Value), Convert.ToInt32(nudMaxRandomRange.Value) + 1);
                    i++;
                    if (i > 1000) break;

                }
                if (i <= 1000) tbRandomList.AppendText(n + Environment.NewLine);

            }
            else
            {
                tbRandomList.AppendText(n + Environment.NewLine);
            }
        }

        private void BtnRandomClear_Click(object sender, EventArgs e)
        {
            tbRandomList.Clear();
        }

        private void BtnRandomCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tbRandomList.Text);
        }

        private void TsmiInsertDate_Click(object sender, EventArgs e)
        {
            rtbNotepad.AppendText(DateTime.Now.ToShortDateString() + "\n");
        }

        private void TsmiInsertTime_Click(object sender, EventArgs e)
        {
            rtbNotepad.AppendText(DateTime.Now.ToShortTimeString() + "\n");
        }

        public void LoadFile()
        {
            try
            {
                rtbNotepad.LoadFile("notepad.rtf");
            }
            catch
            {
                rtbNotepad.Clear();
            }
            
        }
        private void TsmiSaveNotepad_Click(object sender, EventArgs e)
        {
            try
            {
                rtbNotepad.SaveFile("notepad.rtf");
            }
            catch
            {
                MessageBox.Show("Ошибка сохранения документа!", "Ошибка");
            }
        }

        private void TsmiLoadNotepad_Click(object sender, EventArgs e)
        {
            LoadFile();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadFile();
            cblPassword.SetItemChecked(0, true);
            cblPassword.SetItemChecked(1, true);
        }

        private void BtnPasswordCreate_Click(object sender, EventArgs e)
        {
            string password = "";
            if (cblPassword.CheckedItems.Count == 0) return;
            for(int i=0; i < Convert.ToInt32(nudPasswordLenght.Value); i++)
            {
                string check_name = cblPassword.CheckedItems[rnd.Next(0, cblPassword.CheckedItems.Count)].ToString();
                switch (check_name)
                {
                    case "Цифры":
                        password += rnd.Next(10).ToString();
                        break;
                    case "Прописные буквы":
                        password += Convert.ToChar(rnd.Next(65, 90));
                        break;
                    case "Строчные буквы":
                        password += Convert.ToChar(rnd.Next(97, 122));
                        break;
                    default:
                        password += symbols[rnd.Next(symbols.Length)];
                        break;

                }   
            }
            tbPassword.Text = password;
            Clipboard.SetText(password);
        }

        private void BtnConvert_Click(object sender, EventArgs e)
        {
            Double m1 = metrica[cbFrom.Text];
            Double m2 = metrica[cbTo.Text];
            Double n = Convert.ToDouble(tbFrom.Text);
            tbTo.Text = (n * m1 / m2).ToString();

        }

        private void CbSwitchConverter_SelectedValueChanged(object sender, EventArgs e)
        {
            string current_mode = cbSwitchConverter.Text;
            switch(current_mode)
            {
                case "длина":
                metrica = new Dictionary<string, double>() {
                {"mm", 1 },
                { "cm", 10},
                {"dm", 100 },
                { "m", 1000},
                {"km", 1000000}
               };
                    cbFrom.Items.Clear();
                    cbTo.Items.Clear();
               cbFrom.Items.AddRange(new string[] { "mm", "cm", "dm", "m", "km" });
               cbTo.Items.AddRange(new string[] { "mm", "cm", "dm", "m", "km" });
                    cbFrom.Text = cbFrom.Items[0].ToString();
                    cbTo.Text = cbTo.Items[0].ToString();
                    break;
                case "вес":
                    metrica = new Dictionary<string, double>() {
                {"g", 1 },
                { "kg", 1000},
                {"c", 100000},
                { "t", 1000000}
               };
                    cbFrom.Items.Clear();
                    cbTo.Items.Clear();
                    cbFrom.Items.AddRange(new string[] { "g", "kg", "c", "t"});
                    cbTo.Items.AddRange(new string[] { "g", "kg", "c", "t"});
                    cbFrom.Text = cbFrom.Items[0].ToString();
                    cbTo.Text = cbTo.Items[0].ToString();
                    break;
                default:
                    break;
            }
        }
    }
}
