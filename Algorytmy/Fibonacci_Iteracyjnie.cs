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
    public partial class Fibonacci_Iteracyjnie : Form
    {
        public Fibonacci_Iteracyjnie()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox1.Text);

            textBox2.Text = fib(n).ToString();
            label5.Text = textBox2.Text;
        }
        int fib(int n)
        {
            int m1 = 1, m2 = 1, wynik = 1;

            for (int i = 2; i < n; i++)
            {
                wynik = m1 + m2;
                m1 = m2;
                m2 = wynik;
            }
            if (n == 0)
            {
                return 0;
            }
            else
            {
                return wynik;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
    
        
}
