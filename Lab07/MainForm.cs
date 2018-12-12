using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab07
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Tbx1.Text) || (String.IsNullOrEmpty(Tbx2.Text)))
            {
                tby.Text = "Не введено даних!";
                return;
            }
            double x1 = double.Parse(Tbx1.Text);
            double x2 = double.Parse(Tbx2.Text);
            //double y = x1 * x2;
            double y = 45 * Math.Sin(x1 + x2 + Math.Log10(x1 * Math.Pow(x2, 2)));
            double avg = (x1 + x2) / 2;
            Tbx3.Text = avg.ToString("0.#####");
            tby.Text = y.ToString("0.#####");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Tbx1.Text = string.Empty;
            Tbx2.Text = string.Empty;
            tby.Text = string.Empty;
            Tbx3.Text = string.Empty;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Tbx1_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(Tbx1.Text, "[^0-9]"))
            {
                MessageBox.Show("Заборонено використання літер.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Tbx1.Text = Tbx1.Text.Remove(Tbx1.Text.Length - 1);
            }
        }

        private void Tbx2_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(Tbx2.Text, "[^0-9]"))
            {
                MessageBox.Show("Заборонено використання літер.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Tbx2.Text = Tbx2.Text.Remove(Tbx2.Text.Length - 1);
            }
        }


    }
}
