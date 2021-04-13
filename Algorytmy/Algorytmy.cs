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
    public partial class Algorytmy : Form
    {
        SotrowanieBabelkowe Okno1;
        MargeSort Okno2;
        Euklides Okno3;
        Fibonacci_Iteracyjnie Okno4;
        Fibonacci_Rekuren Okno5;
        Fibonacci_Listy Okno6;
        stos Okno7;
        kolejka Okno8;
        drzew Okno9;
        

        public Algorytmy()
        {
            InitializeComponent();
            Okno1 = new SotrowanieBabelkowe();
            Okno2 = new MargeSort();
            Okno3 = new Euklides();
            Okno4 = new Fibonacci_Iteracyjnie();
            Okno5 = new Fibonacci_Rekuren();
            Okno6 = new Fibonacci_Listy();
            Okno7 = new stos();
            Okno8 = new kolejka();
            Okno9 = new drzew();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Okno1.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Okno8.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Okno7.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Okno9.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Okno3.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Okno4.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Okno5.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Okno6.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Okno2.ShowDialog();
        }
    }
}
