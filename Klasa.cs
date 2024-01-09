using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    class Klasa
    {
        double liczba1;
        char znak;
        double liczba2;
        int[] tablica = {1,2,3,4,5,6,7,8,9,10};
        ArrayList arrayList = new ArrayList() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        Klasa(double liczba1)
        {
            this.liczba1 = liczba1;
        }

        Klasa(char znak)
        {
            this.znak = znak;
        }

        Klasa(double liczba1, char znak)
        {
            this.liczba1 = liczba1;
            this.znak = znak;
        }

        Klasa(double liczba1, double liczba2)
        {
            this.liczba1 = liczba1;
            this.liczba2 = liczba2;
        }

        Klasa(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
        }

        Klasa()
        {
            arrayList.Sort();
        }
    }
}
