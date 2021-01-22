using System;

namespace BIO_Program
{
	class Program
	{
		static void Main(string[] args)
		{
			bool klart = false;

			do
			{
				Console.WriteLine("BIO-MENY");
				Console.WriteLine("================");
				Console.WriteLine("Välj ett alternativ (1 - 3):\n\n");
				Console.WriteLine("1 Biljetter.");
				Console.WriteLine("2 Text x 10.");
				Console.WriteLine("3 Lek med ord.");
				Console.WriteLine("\nQ Avslutar Meny.");
				Console.Write("\n: ");
				string inmatning = Console.ReadLine();
				Console.WriteLine();

				switch (inmatning)
				{
					case "1":
						
						
						break;
					case "2":
						break;
					case "3":
						break;
					case "Q":
						klart = true;
						break;
					case "q":
						klart = true;
						break;
					default:
						Console.WriteLine("\nFel val - försök igen!\n");
						break;
				}
			} while (!klart);

		}
	}
}
