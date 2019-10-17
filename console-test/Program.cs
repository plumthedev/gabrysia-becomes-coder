using System;

namespace ConsoleTest
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Wciśnij dowolny klawisz aby ustawić kolor tła konsoli");
			Console.ReadKey(true);
			Console.BackgroundColor = ConsoleColor.Magenta;
			Console.Clear();
			Console.WriteLine("Kolor tła konsoli został ustawiony");

			Console.WriteLine("Wciśnij dowolny klawisz aby ustawić kolor tła tekstu");
			Console.ReadKey(true);
			Console.BackgroundColor = ConsoleColor.Cyan;
			Console.WriteLine("Kolor tekstu został ustawiony");

			try
			{
				Console.WriteLine("Wciśnij dowolny klawisz aby zmienić rozmiar okna");
				Console.ReadKey(true);
				Console.SetWindowSize(600, 800);
				Console.WriteLine("Zmieniono rozmiar okna");
			}
			catch (Exception e)
			{
				Console.WriteLine("Nie udało się zmienić rozmiaru okna z powodu ograniczeń systemowych");
				Console.WriteLine(e.Message);
			}

			Console.WriteLine("Wciśnij dowolny klawisz aby uruchomić dzwięk ");
			Console.ReadKey(true);
			Console.Beep();
			Console.WriteLine("Uruchomiono dzwięk");

			Console.WriteLine("Wciśnij dowolny klawisz aby wyczyścić konsole");
			Console.ReadKey(true);
			Console.Clear();
			Console.WriteLine("Wyczyszczono konsole");

			try
			{
				Console.WriteLine("Wciśnij dowolny klawisz aby ustawić wielkość kursora");
				Console.ReadKey(true);
				Console.CursorSize = 25;
				Console.WriteLine("Ustawiono wielkość kursora");
			}
			catch (Exception e)
			{
				Console.WriteLine("Nie udało się zmienić rozmiaru kursora z powodu ograniczeń systemowych");
				Console.WriteLine(e.Message);
			}
		}
	}
}
