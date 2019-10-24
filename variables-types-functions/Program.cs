using System;

namespace VariablesTypesFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            ZwrocLiczbe();
            ZwrocPodwojna(44);
            CzyParzysta(37);
            Potega(2, 10);
            Podziel(246, 3);
            SprawdzWartosc('G');
            Zlacz("Gabrysia", "Coder");
            IleZnakow("Garysia", "Programista");

            Console.ReadKey(true);
        }

        static int ZwrocLiczbe() {
            int wymyslonaLiczba = 6;
            Console.WriteLine($"Zwracam liczbę wymyśloną przez twórce funkcji - ({wymyslonaLiczba})");
            return wymyslonaLiczba;
        }

        static int ZwrocPodwojna(int a) {
            Console.WriteLine($"Zwracam liczbę zwracam podwójna wartość liczby {a} - ({a*2})");
            return a * 2;
        }

        static bool CzyParzysta(int a) {
            bool jestParzysta = (a % 2 == 0);
            Console.WriteLine($"Zwracam czy podana liczba jest parzysta {a} - ({((jestParzysta)? "jest parzysta" : "nie jest parzysta")})");
            return jestParzysta;
        }

        static int Potega(int a, int b) {
            double wynikPotegowania = Math.Pow(Convert.ToDouble(a), Convert.ToDouble(b));
            Console.WriteLine($"Zwracam wynik potegowania {a}^{b} - ({wynikPotegowania})");
            return Convert.ToInt32(wynikPotegowania);
        }

        static double Podziel(int x, int y) {
            int wynikDzielenia = (x/y);
            Console.WriteLine($"Zwracam wynik dzielenia {x}/{y} - ({wynikDzielenia})");
            return Convert.ToDouble(wynikDzielenia);
        }

        static int SprawdzWartosc(char znak) {
            int reprezentacjaLiczbowa = Convert.ToInt32(znak);
            Console.WriteLine($"Zwracam reprezentacje liczbową znaku {znak} - ({reprezentacjaLiczbowa})");
            return reprezentacjaLiczbowa;
        }

        static void Zlacz(string tekst1, string tekst2) {
            string zlaczoneTeksty = $"{tekst1} {tekst2}";
            Console.WriteLine($"Tworze jeden tekst z {tekst1} oraz {tekst2}, oddzielając je spacją - ({zlaczoneTeksty})");
        }

        static int IleZnakow(string tekst1, string tekst2) {
            string zlaczoneTeksty = $"{tekst1}{tekst2}";
            int dlugoscZlaczonychTekstow = zlaczoneTeksty.Length;
            Console.WriteLine($"Zwracam dlugosc zlączonych tekstów {tekst1} oraz {tekst2} - ({dlugoscZlaczonychTekstow})");
            return dlugoscZlaczonychTekstow;
        }
    }
}
