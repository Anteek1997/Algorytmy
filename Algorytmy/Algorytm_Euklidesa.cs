using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algorytmy
{
    public partial class Euklides : Form
    {
        public Euklides()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);

            wynik.Text = NWD(a, b).ToString();
            label5.Text = wynik.Text;
        }
        int NWD(int a, int b)
        {
            int c;
            c = a % b;
            if (c == 0)
            {
                return b;
            }
            return NWD(b, c);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
            label5.Text = String.Empty;
        }
    }


}
