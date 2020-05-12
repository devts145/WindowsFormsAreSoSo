using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Практическое_задание__4
{
    public partial class Form1 : Form
    {
        int numatt = 0, i = 0;
        public Form1()
        {
            InitializeComponent();
            MaximizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            StartPosition = FormStartPosition.CenterScreen;
            label2.Left -= 200;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int chance = rnd.Next(0, 11);
            numatt++;
            if (numatt <= 10)
            {
                if (Convert.ToString(chance) == textBox1.Text)
                {
                    label2.Text = "Вы угадали! Ясновидящий ((";
                }
                else
                {
                    label2.Text = "Да уж, не угадал(a)! " + " Было: " + chance;
                    label2.Left += 50;
                    i++;
                }
            }
            if (numatt > 10)
            {
                label3.Text = "Коэффициент невезучести: " + i / 10 + "," + i % 10;
                label2.Text = "";
            }
        }
    }
}
