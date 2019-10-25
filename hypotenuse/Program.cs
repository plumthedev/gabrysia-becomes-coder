using System;

namespace Hypotenuse
{
    class Program
    {
        static void Main(string[] args)
        {
            string a, b;
            Console.WriteLine("Oblicz długość przeciwprostokątnej\n");

            Console.WriteLine("Podaj długość przyprostokątnej a:");
            a = Console.ReadLine();
            Console.WriteLine("Podaj długość przyprostokątnej b:");
            b = Console.ReadLine();

            CalculateHypotenuseLength(Convert.ToInt32(a), Convert.ToInt32(b));
            CalculateHypotenuseLength(Convert.ToDouble(a), Convert.ToDouble(b));
            CalculateHypotenuseLength(Convert.ToDecimal(a), Convert.ToDecimal(b));

            Console.ReadKey();
        }

        static int CalculateHypotenuseLength(int a, int b) {
            double pythagoreanTheoremResult = CalculatePythagoreanTheorem(Convert.ToDouble(a), Convert.ToDouble(b));
            double hypotenuseLength = Math.Sqrt(pythagoreanTheoremResult);
            int hypotenuseLengthInt = Convert.ToInt32(hypotenuseLength);
            Console.WriteLine($"Długość przeciwprostokątnej typu int wynosi {hypotenuseLengthInt}");
            return hypotenuseLengthInt;
        }

        static double CalculateHypotenuseLength(double a, double b) {
            double pythagoreanTheoremResult = CalculatePythagoreanTheorem(a, b);
            double hypotenuseLength = Math.Sqrt(pythagoreanTheoremResult);
            Console.WriteLine($"Długość przeciwprostokątnej typu double wynosi {hypotenuseLength}");
            return hypotenuseLength;
        }
        
        static decimal CalculateHypotenuseLength(decimal a, decimal b) {
            double pythagoreanTheoremResult = CalculatePythagoreanTheorem(Convert.ToDouble(a), Convert.ToDouble(b));
            double hypotenuseLength = Math.Sqrt(pythagoreanTheoremResult);
            decimal hypotenuseLengthDecimal = Convert.ToDecimal(hypotenuseLength);
            Console.WriteLine($"Długość przeciwprostokątnej typu decimal wynosi {hypotenuseLengthDecimal}");
            return hypotenuseLengthDecimal;
        }

        static double CalculatePythagoreanTheorem(double a, double b)
        {
            return Math.Pow(a, 2) + Math.Pow(b, 2);
        }

    }
}
