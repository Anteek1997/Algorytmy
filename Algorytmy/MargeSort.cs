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
    public partial class MargeSort : Form
    {
        public MargeSort()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var cyfry = maskedTextBox1.Text;
            int[] cyfryInt = Konwersja(cyfry);
            int r = cyfryInt.Length - 1;

            cyfryInt = Sortowanie(cyfryInt, 0, r);


            wynik.Text = string.Join(" ", cyfryInt);
            label4.Text = wynik.Text;

        }
        int[] Sortowanie(int[] tab, int p, int r)
        {
            if (p < r)
            {
                int q = (p + r) / 2;
                Sortowanie(tab, p, q);
                Sortowanie(tab, q + 1, r);
                Scalanie(tab, p, q, r);
            }
            return tab;
        }
        static void Scalanie(int[] tab, int p, int q, int r)
        {

            int[] pom = new int[tab.Length];

            for (int i = p; i <= r; i++)
            {
                pom[i] = tab[i];
            }

            int j = p;
            int k = q + 1;

            for (int l = p; l <= r; l++)
            {
                if (j <= q)
                {
                    if (k <= r)
                    {
                        if (pom[k] < pom[j])
                        {
                            tab[l] = pom[k++];
                        }
                        else
                        {
                            tab[l] = pom[j++];
                        }
                    }
                    else
                    {
                        tab[l] = pom[j++];
                    }
                }
                else
                {
                    tab[l] = pom[k++];
                }
            }
        }
        int[] Konwersja(string cyfryS)
        {
            string[] cyfry = cyfryS.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] cyfryInt = new int[cyfry.Length];

            for (int i = 0; i < cyfry.Length; i++)
            {
                cyfryInt[i] = int.Parse(cyfry[i].Trim());
            }
            return cyfryInt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            wynik.Text = String.Empty;
            maskedTextBox1.Text = String.Empty;
            label4.Text = String.Empty;
            
        }
    }
}
