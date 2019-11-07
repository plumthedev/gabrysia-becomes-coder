using System;

namespace CorrectOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            TestSuite();
            Console.ReadKey();
        }

        static char ZamienNaMala(char a)
        {
            return Convert.ToChar(Convert.ToString(a).ToLower());
        }

        static bool CzyWKolejnosci(char a, char b, char c)
        {
            if(a < b && a < c && b < c)
            {
                return true;
            }

            return false;
        }

        static void TestSuite() {
            char[,] testCases = new char[7, 3] { 
                {'a', 'B', 'C'}, // true
                {'A', 'b', 'C'}, // true
                {'A', 'B', 'c'}, // true
                {'A', 'a', 'C'}, // false
                {'a', 'b', 'B'}, // false
                {'a', 'A', 'C'}, // false
                {'a', 'B', 'b'}, // false
            };

            for(int i = 0; i < testCases.GetLength(0); i++)
            {
                char a = ZamienNaMala(testCases[i, 0]);
                char b = ZamienNaMala(testCases[i, 1]);
                char c = ZamienNaMala(testCases[i, 2]);
                bool wKolejnosci = CzyWKolejnosci(a, b, c);
                Console.WriteLine(wKolejnosci);
            }
        }
    }
}
