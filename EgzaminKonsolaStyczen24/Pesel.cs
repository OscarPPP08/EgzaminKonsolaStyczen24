using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgzaminKonsolaStyczen24
{
    public class Pesel
    {
        public string numerPesel;
        public int[] mnoznik = [1,3,7,9,1,3,7,9,1,3];

        public Pesel(string numerPesel)
        {
            this.numerPesel = numerPesel;
        }

        /*
         * nazwa funkcji:       SprawdzPlec
         * opis funkcji:        Funkcja zwraca znak 'k' lub znak 'm' w zależności od przedostatniej wartości numeru pesel
         * parametry:           Brak
         * zwracany typ i opis: Zwracany typ to char oznaczający płeć na podstawie numeru pesel
         * autor:               55030101193
         */
        public char SprawdzPlec()
        {
            if (int.Parse(numerPesel[9].ToString()) % 2 == 0) return 'K';
            
            return 'M';
        }

        public bool WalidacjaNumeruPesel()
        {
            int s = 0;

            for (int i = 0; i < 10; i++)
            {
                s += (int.Parse(numerPesel[i].ToString()) * mnoznik[i]);
            }

            int m = s % 10;
            int r = m == 0 ? 0 : 10 - m;

            return (r == int.Parse(numerPesel[10].ToString()));
        }
    }
}
