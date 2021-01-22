using System;

namespace BIO_Program
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = "";
			bool klart1 = false;
			bool test = false;
			int ageOneVisitor = 0;
			int numberOfVisitors = 0;

			do
			{

				Console.WriteLine("HUVUDMENY");
				Console.WriteLine("============================");
				Console.WriteLine("Välj ett alternativ (1 - 3):\n\n");
				Console.WriteLine("1 BIO-Biljetter.");
				Console.WriteLine("2 Text x 10.");
				Console.WriteLine("3 Lek med ord.");
				Console.WriteLine("\nQ Avslutar Meny.");
				Console.Write("\n: ");
				string val1 = Console.ReadLine();
				Console.WriteLine();

				switch (val1)
				{
					case "1":

						bool klart2 = false;

						do
						{
							Console.WriteLine("UNDERMENY BIO-Biljetter");
							Console.WriteLine("============================");
							Console.WriteLine("Välj ett alternativ (1 - 2):\n\n");
							Console.WriteLine("1 En person.");
							Console.WriteLine("2 Flera personer i sällskap.");
							Console.WriteLine("\nQ Avslutar Meny.");
							Console.Write("\n: ");
							string val2 = Console.ReadLine();
							Console.WriteLine();

							switch (val2)
							{
								case "1":
									Console.Write("\nÅlder? ");
									input = Console.ReadLine();
									test = int.TryParse(input, out ageOneVisitor);
									if (!test)
									{
										Console.WriteLine("Bara siffror!");
										klart2 = false;
									}
									else
									{
										if (ageOneVisitor < 5 || ageOneVisitor > 100) Console.WriteLine("\nBiobesöket är GRATIS! Välkommen.");
										else if (ageOneVisitor < 20) Console.WriteLine("\nUngdomspris: 80 kr, Välkommen.");
										else if (ageOneVisitor > 64) Console.WriteLine("\nPensionärspris:  90 kr, Välkommen.");
										else Console.WriteLine("\nStandardpris: 120 kr.");
										Console.ReadLine();
										test = true;
									}
									break;

								case "2":

									ageOneVisitor = 0;
									int ticketPrice = 0;
									int sumTickets = 0;
									int sumVisitors = 0;

									Console.WriteLine("\nHur många i sällskapet?");
									input = Console.ReadLine();
									test = int.TryParse(input, out numberOfVisitors);
									if (!test)
									{
										Console.WriteLine("Bara siffror!");
										klart2 = false;
									}
									else
									{

										for (int i = 1; i < numberOfVisitors + 1; i++)
										{

											bool klart3 = false;

											do
											{
												Console.Write($"\nÅlder besökare {i}? ");
												input = Console.ReadLine();
												test = int.TryParse(input, out ageOneVisitor);
												if (!test)
												{
													Console.WriteLine("Bara siffror!");
												}
												else
												{
													if (ageOneVisitor < 5 || ageOneVisitor > 100) ticketPrice = 0;
													else if (ageOneVisitor < 20) ticketPrice = 80;
													else if (ageOneVisitor > 64) ticketPrice = 90;
													else ticketPrice = 120;
													klart3 = true;
												}
											} while (!klart3);

											if (ageOneVisitor < 5 || ageOneVisitor > 100)
											{
												Console.WriteLine($"\nBesökare {i} är {ageOneVisitor} och går GRATIS på Bio!");
											}
											else if (ageOneVisitor < 20)
											{
												Console.WriteLine($"\nBesökare {i} är {ageOneVisitor} och har Ungdomspris: 80 kr.");
												sumTickets += ticketPrice;
											}
											else if (ageOneVisitor > 64)
											{
												Console.WriteLine($"\nBesökare {i} är {ageOneVisitor} och har Pensionärspris: 90 kr.");
												sumTickets += ticketPrice;
											}
											else
											{
												Console.WriteLine($"\nBesökare {i} är {ageOneVisitor} och har Standardpris: 120 kr.");
												sumTickets += ticketPrice;
											}
											sumVisitors++;
										}
										Console.WriteLine($"\nNi är {sumVisitors} personer och den totala kostnaden är {sumTickets} kr. Välkomna!");
										Console.ReadLine();
									}
									break;
								case "Q":
									klart2 = true;
									break;
								case "q":
									klart2 = true;
									break;
								default:
									Console.WriteLine("\nFel val - försök igen");
									break;
							}
						} while (!klart2);
						break;
					case "2":
						break;
					case "3":
						break;
					case "Q":
						klart1 = true;
						break;
					case "q":
						klart1 = true;
						break;
					default:
						Console.WriteLine("\nFel val - försök igen!\n");
						break;
				}
			} while (!klart1);
		}
	}
}
