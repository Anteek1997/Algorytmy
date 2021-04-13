using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorytmy
{
    
        class Drzewo
        {
            public Wezel korzen;
            public int length;
            public int glebokosc;

            public Drzewo(int wartosc)
            {
                this.korzen = new Wezel(wartosc);
                this.korzen.wartosc = wartosc;
                this.length = 1;
                this.glebokosc = 0;
            }

            public void Push(int wartosc)
            {
                Wezel rodzic = this.ZnajdzRodzica(this.length);
                Wezel dziecko = new Wezel(wartosc);



                if (this.length % 2 == 1)
                {
                    rodzic.lewe = dziecko;
                }
                else
                {
                    rodzic.prawe = dziecko;
                }
                dziecko.rodzic = rodzic;
                this.length += 1;
                this.glebokosc = JakGlebokie();

            }
            public Wezel ZnajdzRodzica(int numer)
            {
                int id = numer;
                List<int> droga = new List<int>();

                while (numer > 0)
                {
                    numer = (numer - 1) / 2;
                    droga.Add(numer);
                }

                droga.Reverse();
                var rodzic = this.korzen;
                for (int i = 1; i < droga.Count; i++)
                {
                    if (droga[i] % 2 == 1)
                    {
                        rodzic = rodzic.lewe;
                    }
                    else
                    {
                        rodzic = rodzic.prawe;
                    }
                }
                return rodzic;
            }
            public int Pop()
            {
                var rodzic = this.ZnajdzRodzica(this.length - 1);
                int x;
                if (rodzic.prawe == null)
                {
                    x = rodzic.lewe.wartosc;
                    rodzic.lewe = null;
                }
                else
                {
                    x = rodzic.prawe.wartosc;
                    rodzic.prawe = null;
                }
                this.length--;
                return x;
            }
            public int JakGlebokie()
            {
                int glebokosc = 0;
                int dlugosc = this.length - 1;
                while (dlugosc > 0)
                {
                    dlugosc /= 2;
                    glebokosc++;
                }
                this.glebokosc = glebokosc;
                return this.glebokosc;
            }
        }

    }
