using System;

namespace ReturnIndivisible

{
    class Program
    {
        static void Main(string[] args)
        {
            uint n = 30;
            Console.WriteLine(ZwrocNiepodzielne(n)); ;
            Console.ReadKey();
        }

        static string ZwrocNiepodzielne(uint n)
        {
            bool greaterThanZero = (n > 0);
            bool dividedByThree = (n % 3 == 0);
            bool dividedByFive = (n % 5 == 0);

            if (greaterThanZero)
            {
                if (!dividedByThree && !dividedByFive)
                {
                    string spacing = (n - 1 > 0) ? " " : "";
                    return ZwrocNiepodzielne(n - 1) + spacing + n;
                }

                return ZwrocNiepodzielne(n - 1);
            }

            return "";
        }
    }
}
