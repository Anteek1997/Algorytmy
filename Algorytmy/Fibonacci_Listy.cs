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
    public partial class Fibonacci_Listy : Form
    {
        public Fibonacci_Listy()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(ciag.Text);

            wynik.Text = fib(n).ToString();
            label2.Text = ciag.Text;
            label4.Text = wynik.Text;
        }
        int fib(int n)
        {
            List<int> wynik = new List<int> { 0, 1 };

            for (int i = 2; i <= n; i++)
            {
                wynik.Add(wynik[i - 1] + wynik[i - 2]);
            }
            return wynik[n];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ciag.Text = String.Empty;
            label2.Text = String.Empty;
            label4.Text = String.Empty;
        }
    }
}
