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
    public partial class Fibonacci_Rekuren : Form
    {
        public Fibonacci_Rekuren()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox1.Text);
            wynik.Text = fib(n).ToString();
            wynciag.Text = wynik.Text; 
        }

        int fib(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            if (n == 1)
            {
                return 1;
            }
            return fib(n - 1) + fib(n - 2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
