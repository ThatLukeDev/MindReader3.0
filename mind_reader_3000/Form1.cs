using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mind_reader_3000
{
    public partial class Form1 : Form
    {
        bool isCorrectInputParametersIvNemesisLedueIV(string s)
        {
            try
            {
                int paRsedIntegerInput = int.Parse(s);
                if (paRsedIntegerInput < 1 || paRsedIntegerInput > 10)
                    int.Parse("a");
            }
            catch { return false; }
            return true;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numberBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = numberBox.Text;
            if (isCorrectInputParametersIvNemesisLedueIV(text))
            {
                Form2 instance = new Form2(int.Parse(numberBox.Text));
                instance.Show();
            }
            else
            {
                MessageBox.Show("You are an absolute idiot, read the caption dunce!", "Come on, you had one job.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
