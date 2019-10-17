using System;

namespace RegistrationProcess
{
    class Program
    {
        static void Main(string[] args)
        {
            string userLogin, userEmail, userGender, userPassword;
            int userAge;

            Console.WriteLine("Formularz rejestracyjny\n");

            Console.WriteLine("Podaj login");
            userLogin = Console.ReadLine();

            Console.WriteLine("Podaj adres e-mail");
            userEmail = Console.ReadLine();

            Console.WriteLine("Podaj swoją płeć");
            userGender = Console.ReadLine();

            Console.WriteLine("Podaj swoje hasło");
            userPassword = Console.ReadLine();

            Console.WriteLine("Podaj swój wiek");
            userAge = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n");

            Console.WriteLine("Dziękujemy za rejestracje! Oto Twoje dane:");
            Console.WriteLine($"Login: {userLogin}");
            Console.WriteLine($"E-mail: {userEmail}");
            Console.WriteLine($"Płeć: {userGender}");
            Console.WriteLine($"Hasło: {userPassword}");
            Console.WriteLine($"Wiek: {userAge}");
            Console.WriteLine("\n");

            Console.WriteLine("Czas na edycje danych");
            Console.WriteLine($"Edytuj login (obecnie: {userLogin})");
            userLogin = Console.ReadLine();

            Console.WriteLine($"Edytuj email (obecnie: {userEmail})");
            userEmail = Console.ReadLine();

            Console.WriteLine($"Edytuj hasło (obecnie: {userPassword})");
            userPassword = Console.ReadLine();

            Console.WriteLine("\n");

            Console.WriteLine("Dziękujemy za edycje danych! Oto Twoje dane:");
            Console.WriteLine($"Login: {userLogin}");
            Console.WriteLine($"E-mail: {userEmail}");
            Console.WriteLine($"Płeć: {userGender}");
            Console.WriteLine($"Hasło: {userPassword}");
            Console.WriteLine($"Wiek: {userAge}");
            Console.WriteLine("\n");


            Console.ReadKey(true);
        }
    }
}
