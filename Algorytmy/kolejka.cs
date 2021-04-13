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
    public partial class kolejka : Form
    {
        class ksiazki
        {
            string nazwa;

            public static int Licznik = 1;

            public ksiazki(string na)
            {
                Licznik++;
                nazwa = na;

                this.nazwa = "Ksiażka nr " + Licznik;


            }
            public string Dane()
            {
                string Tekst;
                Tekst = nazwa;
                return Tekst;
            }

        }

        Queue<ksiazki> Kolekcja = new Queue<ksiazki>();
        ksiazki ksiazka;

        public kolejka()
        {
            InitializeComponent();
        }
        void pokaz()
        {
            richTextBox1.Clear();

            foreach (ksiazki Element in Kolekcja)
            {
                richTextBox1.AppendText(Element.Dane() + "\n");

            }
 
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ksiazka = new ksiazki("lala");
            Kolekcja.Enqueue(ksiazka);
            pokaz();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            ksiazka = Kolekcja.Dequeue();
            MessageBox.Show(ksiazka.Dane(), "Usunieto element:");
            pokaz();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


