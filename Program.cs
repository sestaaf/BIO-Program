using System;

namespace BIO_Program
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = "";
			bool klart0 = false;
			bool test = false;
			int ageOneVisitor = 0;
			int numberOfVisitors = 0;

			do
			{

				Console.WriteLine("HUVUDMENY");
				Console.WriteLine("============================================");
				Console.WriteLine("Välj ett alternativ (1 - 3 eller Q + Enter):\n\n");
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

						bool klart1 = false;

						do
						{
							Console.WriteLine("UNDERMENY BIO-Biljetter");
							Console.WriteLine("============================================");
							Console.WriteLine("Välj ett alternativ (1 - 2 eller Q + Enter):\n\n");
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
										klart1 = false;
									}
									else
									{
										if (ageOneVisitor < 5 || ageOneVisitor > 100) Console.WriteLine("\nBiobesöket är GRATIS! Välkommen.");
										else if (ageOneVisitor < 20) Console.WriteLine("\nUngdomspris: 80 kr, Välkommen.");
										else if (ageOneVisitor > 64) Console.WriteLine("\nPensionärspris:  90 kr, Välkommen.");
										else Console.WriteLine("\nStandardpris: 120 kr, Välkommen.");
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
										klart1 = false;
									}
									else
									{

										for (int i = 1; i < numberOfVisitors + 1; i++)
										{

											bool klart12 = false;

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
													klart12 = true;
												}
											} while (!klart12);

											if (ageOneVisitor < 5 || ageOneVisitor > 100)
											{
												Console.WriteLine($"\nBesökare {i} är {ageOneVisitor} år och går GRATIS på Bio!");
											}
											else if (ageOneVisitor < 20)
											{
												Console.WriteLine($"\nBesökare {i} är {ageOneVisitor} år och har Ungdomspris: 80 kr.");
												sumTickets += ticketPrice;
											}
											else if (ageOneVisitor > 64)
											{
												Console.WriteLine($"\nBesökare {i} är {ageOneVisitor} år och har Pensionärspris: 90 kr.");
												sumTickets += ticketPrice;
											}
											else
											{
												Console.WriteLine($"\nBesökare {i} är {ageOneVisitor} år och har Standardpris: 120 kr.");
												sumTickets += ticketPrice;
											}
											sumVisitors++;
										}
										Console.WriteLine($"\nNi är {sumVisitors} personer och den totala kostnaden är {sumTickets} kr. Välkomna!");
										Console.ReadLine();
									}
									break;
								case "Q":
									klart1 = true;
									break;
								case "q":
									klart1 = true;
									break;
								default:
									Console.WriteLine("\nFel val - försök igen");
									break;
							}
						} while (!klart1);
						break;
					
					case "2":

						bool klart2 = false;

						do
						{
							Console.WriteLine("\nSkriv in något och tryck Enter.");
							input = Console.ReadLine();

							if (String.IsNullOrWhiteSpace(input))
							{
								Console.WriteLine("Får inte vara tomt!\n");
								klart2 = true;
								break;
							}

							int j = 0;
							Console.WriteLine();
							
							for (j = 1; j < 10; j++)
							{
								Console.Write($"{j}.{input}, ");
							}
							Console.Write($"{j}.{input}.\n"); 
							Console.WriteLine();
							klart2 = true;

						} while (!klart2);

						break;
					
					case "3":
						
						bool klart3 = false;
						string output = "";

						do
						{
							Console.WriteLine("\nSkriv in en mening med tre (3) ord ");
							Console.WriteLine("avskiljda med mellanslag och tryck Enter.");
							Console.WriteLine("Punkt på slutet räknas ej.\n");
							input = Console.ReadLine();

							if (String.IsNullOrWhiteSpace(input))
							{
								Console.WriteLine("Får inte vara tomt!\n");
								klart3 = true;
								break;
							}

							string[] mening = input.Split(' ', input.Length);

							if (mening.Length == 3)
							{
								for (int k = 0; k < mening.Length; k++)
								{
									if (String.IsNullOrWhiteSpace(mening[k]))
									{
										Console.WriteLine("\nFattas ett eller flera ord!\n");
										klart3 = true;
										break;
									}
									else
									{
										if (input.EndsWith('.'))
										{
											output = mening[2].Remove(mening[2].LastIndexOf('.'));
										}
									}
								}

								output = mening[2];

								Console.WriteLine($"\nTredje ordet är \"{output}\".");
								Console.WriteLine();
								klart3 = true;
							}

							else
							{
								Console.WriteLine("Fattas ett eller flera ord!\n");
								klart3 = true;
								break;
							}

						} while (!klart3);
						
						break;

					case "Q":
						klart0 = true;
						break;
					
					case "q":
						klart0 = true;
						break;
					
					default:
						Console.WriteLine("\nFel val - försök igen!\n");
						break;
				}
			} while (!klart0);
		}
	}
}
