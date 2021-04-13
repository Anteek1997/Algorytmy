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
    public partial class SotrowanieBabelkowe : Form
    {
        

        public SotrowanieBabelkowe()
        {
            InitializeComponent();
        }

        private void wprowadz_Click(object sender, EventArgs e)
        {
            wypisane.Text = maskedTextBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var cyfryInt = maskedTextBox1.Text;
            int[] cyfry = Konwertuj(cyfryInt);


            cyfry = SortowanieB(cyfry);
            textBox_Input.Text = string.Join(" ", cyfry);
            posortowane.Text = textBox_Input.Text;



        }
        int[] Konwertuj(string cyfry)
        {
            var wynikS = cyfry.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            

            int[] wynik = new int[wynikS.Length];
            for (int i = 0; i < wynikS.Length; i++)
            {
                wynik[i] = int.Parse(wynikS[i].Trim());
            }

            return wynik;
        }
        int[] SortowanieB(int[] tab)
        {
            bool czyZamiana = false;

            do
            {
                czyZamiana = false;
                for (int i = 0; i < tab.Length - 1; i++)
                {
                    if (tab[i] > tab[i + 1])
                    {
                        var tmp = tab[i];
                        tab[i] = tab[i + 1];
                        tab[i + 1] = tmp;
                        czyZamiana = true;
                    }
                }
            } while (czyZamiana);

            return tab;
        }

        private void zamknij_Click(object sender, EventArgs e)
        {
            this.Close();
                

        }
    }

        


    }

