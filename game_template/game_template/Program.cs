using System;

namespace console_app
{
	class Program
	{
		public static int score=0;
		public static int life=3;
		public static int count=0;
		public static void Main()
		
	{
			Menu();
			Genre();
			GameOver();

	}
		public static void Menu()
		{
			Console.ForegroundColor = ConsoleColor.White;
			int choose;
			Console.Clear();
			Console.WriteLine("");
			Console.WriteLine("");
			Console.WriteLine("");
			Console.WriteLine("");
			Console.WriteLine("");
			Console.WriteLine("");
			Console.WriteLine("            =======================================================");
			Console.WriteLine("");
			Console.ForegroundColor = ConsoleColor.Magenta;
			Console.WriteLine("                                 Guess The Movie ");
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("");
			Console.WriteLine("                                  |  1. Play   |");
			Console.WriteLine("                                  |  2. About  |");
			Console.WriteLine("                                  |  3. Exit   |");
			Console.WriteLine("");
			Console.WriteLine("");
			Console.WriteLine("            =======================================================");
			Console.Write("\t\t\t\tSelect Your Choice: ");
			Console.Write("\t\t\t\t\t\t\t\t\t ");
			choose = Convert.ToInt32(Console.ReadLine());
			if (choose == 1)
			{
				Genre();
			}
			else if (choose == 2)
			{
				Console.ForegroundColor = ConsoleColor.White;
				Console.Clear();
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.WriteLine("");
				Console.ForegroundColor = ConsoleColor.Yellow;
				Console.WriteLine("                                       About ");
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("                 This game is submitted to Mr. Ramil Kaharian as");
				Console.WriteLine("	           a project in our major subject Programming.");
				Console.WriteLine("");
				Console.WriteLine("                                  Submitted by:");
				Console.WriteLine("                            Kobie Oracion & Mae Mallari");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.WriteLine("                             Press 'Enter' to go back");
				Console.ReadLine();
				Menu();
			}
			
			else if (choose == 3)
			{
			Console.ForegroundColor = ConsoleColor.White;	
			int choosexit;
			Console.Clear();
			Console.WriteLine("");
			Console.WriteLine("");
			Console.WriteLine("");
			Console.WriteLine("");
			Console.WriteLine("");
			Console.WriteLine("");
			Console.WriteLine("            =======================================================");
			Console.WriteLine("");
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine("                          Do you really want to exit? ");
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("");
			Console.WriteLine("                                  |  1. Yes  |");
			Console.WriteLine("                                  |  2. No   |");
			Console.WriteLine("");
			Console.WriteLine("");
			Console.WriteLine("            =======================================================");
			Console.Write("\t\t\t\tSelect Your Choice: ");
			Console.Write("\t\t\t\t\t\t\t\t\t ");
			choosexit = Convert.ToInt32(Console.ReadLine());
			if (choosexit == 1)
			{
				Environment.Exit(0);
			}
			else
			{
				Menu();
			}						
		}

	}
		public static void Genre()
		{
			Console.ForegroundColor = ConsoleColor.White;
			int choosegenre;
			Console.Clear();
			Console.WriteLine("");
			Console.WriteLine("");
			Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine("                           Score: "+score+"           Life: "+life+"");
            Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("            =======================================================");
			Console.WriteLine("");
			Console.ForegroundColor = ConsoleColor.Magenta;
			Console.WriteLine("                                   Select Genre: ");
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("");
			Console.WriteLine("                                 |  1.       |");
			Console.WriteLine("                                 |  2.       |");
			Console.WriteLine("                                 |  3.       |");
			Console.WriteLine("                                 |  4.       |");
			Console.WriteLine("                                 |  5.       |");
			Console.WriteLine("                                 |  6.       |");
			Console.WriteLine("                                 |  7.       |");
			Console.WriteLine("                                 |  8. Exit  |");
			Console.WriteLine("");
			Console.WriteLine("");
			Console.WriteLine("            =======================================================");
			Console.Write("\t\t\t\tSelect Your Choice: ");
			Console.Write("\t\t\t\t\t\t\t\t\t ");
			choosegenre = Convert.ToInt32(Console.ReadLine());
			if (choosegenre == 1)
			{
				Console.Clear();
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.WriteLine("");
				Console.ForegroundColor = ConsoleColor.Yellow;
				Console.WriteLine("                               Genre Category! ");
				Console.WriteLine("");
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("                              Press 'Enter' to Play..");
				Console.WriteLine("");
				Console.WriteLine("                         Note: This game is key sensitive");
				Console.WriteLine("                           So be careful on your answer.");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.ReadLine();
				Action();
			}
			else if (choosegenre == 2)
			{
				Console.Clear();
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.WriteLine("");
				Console.ForegroundColor = ConsoleColor.Yellow;
				Console.WriteLine("                               Genre Category! ");
				Console.WriteLine("");
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("                              Press 'Enter' to Play..");
				Console.WriteLine("");
				Console.WriteLine("                         Note: This game is key sensitive");
				Console.WriteLine("                           So be careful on your answer.");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.ReadLine();
				();
			}			
			else if (choosegenre == 3)
			{
				Console.Clear();
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.WriteLine("");
				Console.ForegroundColor = ConsoleColor.Yellow;
				Console.WriteLine("                                Genre Category! ");
				Console.WriteLine("");
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("                              Press 'Enter' to Play..");
				Console.WriteLine("");
				Console.WriteLine("                         Note: This game is key sensitive");
				Console.WriteLine("                           So be careful on your answer.");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.ReadLine();
				();
			}			
			else if (choosegenre == 4)
			{
				Console.Clear();
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.WriteLine("");
				Console.ForegroundColor = ConsoleColor.Yellow;
				Console.WriteLine("                                Genre Category! ");
				Console.WriteLine("");
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("                              Press 'Enter' to Play..");
				Console.WriteLine("");
				Console.WriteLine("                         Note: This game is key sensitive");
				Console.WriteLine("                           So be careful on your answer.");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.ReadLine();
				();
			}
			else if (choosegenre == 5)
			{
				Console.Clear();
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.WriteLine("");
				Console.ForegroundColor = ConsoleColor.Yellow;
				Console.WriteLine("                               Genre Category! ");
				Console.WriteLine("");
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("                              Press 'Enter' to Play..");
				Console.WriteLine("");
				Console.WriteLine("                         Note: This game is key sensitive");
				Console.WriteLine("                           So be careful on your answer.");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.ReadLine();
				();
			}
			else if (choosegenre == 6)
			{
				Console.Clear();
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.WriteLine("");
				Console.ForegroundColor = ConsoleColor.Yellow;
				Console.WriteLine("                                Genre Category! ");
				Console.WriteLine("");
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("                              Press 'Enter' to Play..");
				Console.WriteLine("");
				Console.WriteLine("                         Note: This game is key sensitive");
				Console.WriteLine("                           So be careful on your answer.");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.ReadLine();
				();
			}			
			else if (choosegenre == 7)
			{
				Console.Clear();
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.WriteLine("");
				Console.ForegroundColor = ConsoleColor.Yellow;
				Console.WriteLine("                                Genre Category! ");
				Console.WriteLine("");
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("                              Press 'Enter' to Play..");
				Console.WriteLine("");
				Console.WriteLine("                         Note: This game is key sensitive");
				Console.WriteLine("                           So be careful on your answer.");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.ReadLine();
				();
			}
			
		}
			public static void ()
			{
				Console.ForegroundColor = ConsoleColor.White;
				string ans;
				Console.Clear();
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.ForegroundColor = ConsoleColor.Cyan;				
				Console.Write("\t\t\tScore:"+score+"\t\t\tLife:"+life+"\n\n");
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("");
				Console.WriteLine("            1.");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.WriteLine("                              Enter Your Answer:");
				Console.Write("     \t\t\t\t ");
				ans = Console.ReadLine();
				if (ans == "")
				{
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("");
				Console.WriteLine("                           Your Answer is Correct!");
				Console.ForegroundColor = ConsoleColor.White;
				Console.ReadLine();
				score+=5;
				count++;
				}
				else
				{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("");
				Console.WriteLine("                            Your Answer is Wrong!");
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("                            The correct answer is:");
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("");
				Console.WriteLine("                                   answer");
				Console.ForegroundColor = ConsoleColor.White;  
				Console.ReadLine();
				life--;
				}
				if (life <= 0)
				{
					GameOver();
				}
				

				Console.Clear();
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.ForegroundColor = ConsoleColor.Cyan;
				Console.Write("\t\t\tScore:"+score+"\t\t\tLife:"+life+"\n\n");
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("");
				Console.WriteLine("            2.");
				Console.WriteLine(" ");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.WriteLine("                              Enter Your Answer:");
				Console.Write("     \t\t\t\t ");
				ans = Console.ReadLine();
				if (ans == "")
				{
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("");
				Console.WriteLine("                           Your Answer is Correct!");
				Console.ForegroundColor = ConsoleColor.White;
				Console.ReadLine();
				score+=5;
				count++;
				}
				else
				{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("");
				Console.WriteLine("                            Your Answer is Wrong!");
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("                            The correct answer is:");
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("");
				Console.WriteLine("                                    answer");
				Console.ForegroundColor = ConsoleColor.White;
				Console.ReadLine();
				life--;
				}
				if (life <= 0)
				{
					GameOver();
				}
				
				Console.Clear();
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.ForegroundColor = ConsoleColor.Cyan;
				Console.Write("\t\t\tScore:"+score+"\t\t\tLife:"+life+"\n\n");
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("");
				Console.WriteLine("            3.");
				Console.WriteLine(" ");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.WriteLine("                              Enter Your Answer:");
				Console.Write("     \t\t\t\t ");
				ans = Console.ReadLine();
				if (ans == "")
				{
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("");
				Console.WriteLine("                           Your Answer is Correct!");
				Console.ForegroundColor = ConsoleColor.White;
				Console.ReadLine();
				score+=5;
				count++;
				}
				else
				{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("");
				Console.WriteLine("                            Your Answer is Wrong!");
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("                            The correct answer is:");
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("");
				Console.WriteLine("                                   answer");
				Console.ForegroundColor = ConsoleColor.White;
				Console.ReadLine();
				life--;
				}
				if (life <= 0)
				{
					GameOver();
				}
				
				Console.Clear();
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.ForegroundColor = ConsoleColor.Cyan;
				Console.Write("\t\t\tScore:"+score+"\t\t\tLife:"+life+"\n\n");
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("");
				Console.WriteLine("            4.  ");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.WriteLine("                              Enter Your Answer:");
				Console.Write("     \t\t\t\t ");
				ans = Console.ReadLine();
				if (ans == "")
				{
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("");
				Console.WriteLine("                           Your Answer is Correct!");
				Console.ForegroundColor = ConsoleColor.White;
				Console.ReadLine();
				score+=5;
				count++;
				}
				else
				{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("");
				Console.WriteLine("                            Your Answer is Wrong!");
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("                            The correct answer is:");
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("");
				Console.WriteLine("                                   answer");
				Console.ForegroundColor = ConsoleColor.White;
				Console.ReadLine();
				life--;
				}
				if (life <= 0)
				{
					GameOver();
				}
				
				Console.Clear();
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.ForegroundColor = ConsoleColor.Cyan;
				Console.Write("\t\t\tScore:"+score+"\t\t\tLife:"+life+"\n\n");
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("");
				Console.WriteLine("            5. ");
				Console.WriteLine(");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.WriteLine("                              Enter Your Answer:");
				Console.Write("     \t\t\t\t ");
				ans = Console.ReadLine();
				if (ans == "")
				{
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("");
				Console.WriteLine("                           Your Answer is Correct!");
				Console.ForegroundColor = ConsoleColor.White;
				Console.ReadLine();
				score+=5;
				count++;
				}
				else
				{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("");
				Console.WriteLine("                            Your Answer is Wrong!");
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("                            The correct answer is:");
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("");
				Console.WriteLine("                                    answer");
				Console.ForegroundColor = ConsoleColor.White;
				Console.ReadLine();;
				life--;
				}
				if (life <= 0)
				{
					GameOver();
				}
				
				Console.Clear();
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.WriteLine("");
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("                                 Congratulations! ");
				Console.WriteLine("");
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("                        You finished the  Genre!");
				Console.WriteLine("                          with the total score of "+score+"");
				Console.WriteLine("");
				Console.WriteLine("                           Press 'Enter' to Continue..");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.ReadLine();
				Genre();
			}
			public static void ()
			{
				Console.ForegroundColor = ConsoleColor.White;
				string ans;
				Console.Clear();
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.ForegroundColor = ConsoleColor.Cyan;				
				Console.Write("\t\t\tScore:"+score+"\t\t\tLife:"+life+"\n\n");
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("");
				Console.WriteLine("            1.");
				Console.WriteLine(" ");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.WriteLine("                              Enter Your Answer:");
				Console.Write("     \t\t\t\t ");
				ans = Console.ReadLine();
				if (ans == "")
				{
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("");
				Console.WriteLine("                           Your Answer is Correct!");
				Console.ForegroundColor = ConsoleColor.White;
				Console.ReadLine();
				score+=5;
				count++;
				}
				else
				{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("");
				Console.WriteLine("                            Your Answer is Wrong!");
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("                            The correct answer is:");
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("");
				Console.WriteLine("                                   answer");
				Console.ForegroundColor = ConsoleColor.White;
				Console.ReadLine();;
				life--;
				}
				if (life <= 0)
				{
					GameOver();
				}
				

				Console.Clear();
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.ForegroundColor = ConsoleColor.Cyan;
				Console.Write("\t\t\tScore:"+score+"\t\t\tLife:"+life+"\n\n");
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("");
				Console.WriteLine("            2.");
				Console.WriteLine(" ");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.WriteLine("                              Enter Your Answer:");
				Console.Write("     \t\t\t\t ");
				ans = Console.ReadLine();
				if (ans == "")
				{
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("");
				Console.WriteLine("                           Your Answer is Correct!");
				Console.ForegroundColor = ConsoleColor.White;
				Console.ReadLine();
				score+=5;
				count++;
				}
				else
				{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("");
				Console.WriteLine("                            Your Answer is Wrong!");
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("                            The correct answer is:");
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("");
				Console.WriteLine("                                   answer");
				Console.ForegroundColor = ConsoleColor.White;
				Console.ReadLine();;
				life--;
				}
				if (life <= 0)
				{
					GameOver();
				}
				
				Console.Clear();
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.ForegroundColor = ConsoleColor.Cyan;
				Console.Write("\t\t\tScore:"+score+"\t\t\tLife:"+life+"\n\n");
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("");
				Console.WriteLine("            3.");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.WriteLine("                              Enter Your Answer:");
				Console.Write("     \t\t\t\t ");
				ans = Console.ReadLine();
				if (ans == "")
				{
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("");
				Console.WriteLine("                           Your Answer is Correct!");
				Console.ForegroundColor = ConsoleColor.White;
				Console.ReadLine();
				score+=5;
				count++;
				}
				else
				{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("");
				Console.WriteLine("                            Your Answer is Wrong!");
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("                            The correct answer is:");
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("");
				Console.WriteLine("                                    answer");
				Console.ForegroundColor = ConsoleColor.White;
				Console.ReadLine();;
				life--;
				}
				if (life <= 0)
				{
					GameOver();
				}
				
				Console.Clear();
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.ForegroundColor = ConsoleColor.Cyan;
				Console.Write("\t\t\tScore:"+score+"\t\t\tLife:"+life+"\n\n");
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("");
				Console.WriteLine("            4.");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.WriteLine("                              Enter Your Answer:");
				Console.Write("     \t\t\t\t ");
				ans = Console.ReadLine();
				if (ans == "")
				{
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("");
				Console.WriteLine("                           Your Answer is Correct!");
				Console.ForegroundColor = ConsoleColor.White;
				Console.ReadLine();
				score+=5;
				count++;
				}
				else
				{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("");
				Console.WriteLine("                            Your Answer is Wrong!");
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("                            The correct answer is:");
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("");
				Console.WriteLine("                                    answer");
				Console.ForegroundColor = ConsoleColor.White;
				Console.ReadLine();;
				life--;
				}
				if (life <= 0)
				{
					GameOver();
				}
				
				Console.Clear();
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.ForegroundColor = ConsoleColor.Cyan;
				Console.Write("\t\t\tScore:"+score+"\t\t\tLife:"+life+"\n\n");
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("");
				Console.WriteLine("            5. ");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.WriteLine("                              Enter Your Answer:");
				Console.Write("     \t\t\t\t ");
				ans = Console.ReadLine();
				if (ans == "")
				{
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("");	
				Console.WriteLine("                           Your Answer is Correct!");
				Console.ForegroundColor = ConsoleColor.White;
				Console.ReadLine();
				score+=5;
				count++;
				}
				else
				{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("");
				Console.WriteLine("                            Your Answer is Wrong!");
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("                            The correct answer is:");
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("");
				Console.WriteLine("                                   answer");
				Console.ForegroundColor = ConsoleColor.White;
				Console.ReadLine();
				life--;
				}
				if (life <= 0)
				{
					GameOver();
				}
				Console.Clear();
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.WriteLine("");
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("                                 Congratulations! ");
				Console.WriteLine("");
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("                         You finished the  Genre!");
				Console.WriteLine("                          with the total score of "+score+"");
				Console.WriteLine("");
				Console.WriteLine("                          Press 'Enter' to Continue..");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.ReadLine();
				Genre();
			}
			
			public static void ()
			{
				Console.ForegroundColor = ConsoleColor.White;
				string ans;
				Console.Clear();
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.ForegroundColor = ConsoleColor.Cyan;				
				Console.Write("\t\t\tScore:"+score+"\t\t\tLife:"+life+"\n\n");
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("");
				Console.WriteLine("            1.");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.WriteLine("                              Enter Your Answer:");
				Console.Write("     \t\t\t\t ");
				ans = Console.ReadLine();
				if (ans == "")
				{
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("");
				Console.WriteLine("                           Your Answer is Correct!");
				Console.ForegroundColor = ConsoleColor.White;
				Console.ReadLine();
				score+=5;
				count++;
				}
				else
				{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("");
				Console.WriteLine("                            Your Answer is Wrong!");
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("                            The correct answer is:");
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("");
				Console.WriteLine("                                   answer");
				Console.ForegroundColor = ConsoleColor.White;
				Console.ReadLine();
				life--;
				}
				if (life <= 0)
				{
					GameOver();
				}
				

				Console.Clear();
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.ForegroundColor = ConsoleColor.Cyan;
				Console.Write("\t\t\tScore:"+score+"\t\t\tLife:"+life+"\n\n");
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("");
				Console.WriteLine("                       2. ");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.WriteLine("                              Enter Your Answer:");
				Console.Write("     \t\t\t\t ");
				ans = Console.ReadLine();
				if (ans == "")
				{
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("");
				Console.WriteLine("                           Your Answer is Correct!");
				Console.ForegroundColor = ConsoleColor.White;
				Console.ReadLine();
				score+=5;
				count++;
				}
				else
				{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("");
				Console.WriteLine("                            Your Answer is Wrong!");
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("                            The correct answer is:");
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("");
				Console.WriteLine("                                    answer");
				Console.ForegroundColor = ConsoleColor.White;
				Console.ReadLine();
				life--;
				}
				if (life <= 0)
				{
					GameOver();
				}
				
				Console.Clear();
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.ForegroundColor = ConsoleColor.Cyan;
				Console.Write("\t\t\tScore:"+score+"\t\t\tLife:"+life+"\n\n");
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("");
				Console.WriteLine("            3. ");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.WriteLine("                              Enter Your Answer:");
				Console.Write("     \t\t\t\t ");
				ans = Console.ReadLine();
				if (ans == "")
				{
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("");
				Console.WriteLine("                           Your Answer is Correct!");
				Console.ForegroundColor = ConsoleColor.White;
				Console.ReadLine();
				score+=5;
				count++;
				}
				else
				{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("");
				Console.WriteLine("                            Your Answer is Wrong!");
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("                            The correct answer is:");
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("");
				Console.WriteLine("                                   answer");
				Console.ForegroundColor = ConsoleColor.White;
				Console.ReadLine();
				life--;
				}
				if (life <= 0)
				{
					GameOver();
				}
				
				Console.Clear();
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.ForegroundColor = ConsoleColor.Cyan;
				Console.Write("\t\t\tScore:"+score+"\t\t\tLife:"+life+"\n\n");
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("");
				Console.WriteLine("            4.");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.WriteLine("                              Enter Your Answer:");
				Console.Write("     \t\t\t\t ");
				ans = Console.ReadLine();
				if (ans == "")
				{
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("");
				Console.WriteLine("                           Your Answer is Correct!");
				Console.ForegroundColor = ConsoleColor.White;
				Console.ReadLine();
				score+=5;
				count++;
				}
				else
				{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("");
				Console.WriteLine("                            Your Answer is Wrong!");
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("                            The correct answer is:");
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("");
				Console.WriteLine("                                   answer");
				Console.ForegroundColor = ConsoleColor.White;
				Console.ReadLine();
				life--;
				}
				if (life <= 0)
				{
					GameOver();
				}
				
				Console.Clear();
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.ForegroundColor = ConsoleColor.Cyan;
				Console.Write("\t\t\tScore:"+score+"\t\t\tLife:"+life+"\n\n");
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("");
				Console.WriteLine("            5.");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.WriteLine("                              Enter Your Answer:");
				Console.Write("     \t\t\t\t ");
				ans = Console.ReadLine();
				if (ans == "")
				{
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("");	
				Console.WriteLine("                           Your Answer is Correct!");
				Console.ForegroundColor = ConsoleColor.White;
				Console.ReadLine();
				score+=5;
				count++;
				}
				else
				{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("");
				Console.WriteLine("                            Your Answer is Wrong!");
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("                            The correct answer is:");
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("");
				Console.WriteLine("                                   answer");
				Console.ForegroundColor = ConsoleColor.White;
				Console.ReadLine();
				life--;
				}
				if (life <= 0)
				{
					GameOver();
				}
				Console.Clear();
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.WriteLine("");
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("                                 Congratulations! ");
				Console.WriteLine("");
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("                         You finished the  Genre!");
				Console.WriteLine("                          with the total score of "+score+"");
				Console.WriteLine("");
				Console.WriteLine("                          Press 'Enter' to Continue..");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.ReadLine();
				Genre();
			}
			
			public static void ()
			{
				Console.ForegroundColor = ConsoleColor.White;
				string ans;
				Console.Clear();
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.ForegroundColor = ConsoleColor.Cyan;				
				Console.Write("\t\t\tScore:"+score+"\t\t\tLife:"+life+"\n\n");
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("");
				Console.WriteLine("            1.");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.WriteLine("                              Enter Your Answer:");
				Console.Write("     \t\t\t\t ");
				ans = Console.ReadLine();
				if (ans == "")
				{
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("");
				Console.WriteLine("                           Your Answer is Correct!");
				Console.ForegroundColor = ConsoleColor.White;
				Console.ReadLine();
				score+=5;
				count++;
				}
				else
				{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("");
				Console.WriteLine("                            Your Answer is Wrong!");
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("                            The correct answer is:");
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("");
				Console.WriteLine("                                   answer");
				Console.ForegroundColor = ConsoleColor.White;
				Console.ReadLine();
				life--;
				}
				if (life <= 0)
				{
					GameOver();
				}
				

				Console.Clear();
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.ForegroundColor = ConsoleColor.Cyan;
				Console.Write("\t\t\tScore:"+score+"\t\t\tLife:"+life+"\n\n");
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("");
				Console.WriteLine("            2.");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.WriteLine("                              Enter Your Answer:");
				Console.Write("     \t\t\t\t ");
				ans = Console.ReadLine();
				if (ans == "")
				{
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("");
				Console.WriteLine("                           Your Answer is Correct!");
				Console.ForegroundColor = ConsoleColor.White;
				Console.ReadLine();
				score+=5;
				count++;
				}
				else
				{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("");
				Console.WriteLine("                            Your Answer is Wrong!");
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("                            The correct answer is:");
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("");
				Console.WriteLine("                                   answer");
				Console.ForegroundColor = ConsoleColor.White;
				Console.ReadLine();
				life--;
				}
				if (life <= 0)
				{
					GameOver();
				}
				
				Console.Clear();
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.ForegroundColor = ConsoleColor.Cyan;
				Console.Write("\t\t\tScore:"+score+"\t\t\tLife:"+life+"\n\n");
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("");
				Console.WriteLine("            3.");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.WriteLine("                              Enter Your Answer:");
				Console.Write("     \t\t\t\t ");
				ans = Console.ReadLine();
				if (ans == "")
				{
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("");
				Console.WriteLine("                           Your Answer is Correct!");
				Console.ForegroundColor = ConsoleColor.White;
				Console.ReadLine();
				score+=5;
				count++;
				}
				else
				{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("");
				Console.WriteLine("                            Your Answer is Wrong!");
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("                            The correct answer is:");
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("");
				Console.WriteLine("                                   answer");
				Console.ForegroundColor = ConsoleColor.White;
				Console.ReadLine();
				life--;
				}
				if (life <= 0)
				{
					GameOver();
				}
				
				Console.Clear();
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.ForegroundColor = ConsoleColor.Cyan;
				Console.Write("\t\t\tScore:"+score+"\t\t\tLife:"+life+"\n\n");
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("");
				Console.WriteLine("            4.");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.WriteLine("                              Enter Your Answer:");
				Console.Write("     \t\t\t\t ");
				ans = Console.ReadLine();
				if (ans == "")
				{
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("");
				Console.WriteLine("                           Your Answer is Correct!");
				Console.ForegroundColor = ConsoleColor.White;
				Console.ReadLine();
				score+=5;
				count++;
				}
				else
				{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("");
				Console.WriteLine("                            Your Answer is Wrong!");
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("                            The correct answer is:");
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("");
				Console.WriteLine("                                   answer");
				Console.ForegroundColor = ConsoleColor.White;
				Console.ReadLine();
				life--;
				}
				if (life <= 0)
				{
					GameOver();
				}
				
				Console.Clear();
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.ForegroundColor = ConsoleColor.Cyan;
				Console.Write("\t\t\tScore:"+score+"\t\t\tLife:"+life+"\n\n");
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("");
				Console.WriteLine("            5.");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.WriteLine("                              Enter Your Answer:");
				Console.Write("     \t\t\t\t ");
				ans = Console.ReadLine();
				if (ans == "")
				{
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("");	
				Console.WriteLine("                           Your Answer is Correct!");
				Console.ForegroundColor = ConsoleColor.White;
				Console.ReadLine();
				score+=5;
				count++;
				}
				else
				{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("");
				Console.WriteLine("                            Your Answer is Wrong!");
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("                            The correct answer is:");
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("");
				Console.WriteLine("                                  answer");
				Console.ForegroundColor = ConsoleColor.White;
				Console.ReadLine();
				life--;
				}
				if (life <= 0)
				{
					GameOver();
				}
				Console.Clear();
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.WriteLine("");
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("                                 Congratulations! ");
				Console.WriteLine("");
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("                         You finished the  Genre!");
				Console.WriteLine("                          with the total score of "+score+"");
				Console.WriteLine("");
				Console.WriteLine("                          Press 'Enter' to Continue..");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.ReadLine();
				Genre();
			}
			
			public static void ()
			{
				Console.ForegroundColor = ConsoleColor.White;
				string ans;
				Console.Clear();
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.ForegroundColor = ConsoleColor.Cyan;				
				Console.Write("\t\t\tScore:"+score+"\t\t\tLife:"+life+"\n\n");
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("");
				Console.WriteLine("            1.");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.WriteLine("                              Enter Your Answer:");
				Console.Write("     \t\t\t\t ");
				ans = Console.ReadLine();
				if (ans == "")
				{
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("");
				Console.WriteLine("                           Your Answer is Correct!");
				Console.ForegroundColor = ConsoleColor.White;
				Console.ReadLine();
				score+=5;
				count++;
				}
				else
				{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("");
				Console.WriteLine("                            Your Answer is Wrong!");
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("                            The correct answer is:");
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("");
				Console.WriteLine("                                    answer");
				Console.ForegroundColor = ConsoleColor.White;
				Console.ReadLine();
				life--;
				}
				if (life <= 0)
				{
					GameOver();
				}
				

				Console.Clear();
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.ForegroundColor = ConsoleColor.Cyan;
				Console.Write("\t\t\tScore:"+score+"\t\t\tLife:"+life+"\n\n");
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("");
				Console.WriteLine("            2. ");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.WriteLine("                              Enter Your Answer:");
				Console.Write("     \t\t\t\t ");
				ans = Console.ReadLine();
				if (ans == "")
				{
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("");
				Console.WriteLine("                           Your Answer is Correct!");
				Console.ForegroundColor = ConsoleColor.White;
				Console.ReadLine();
				score+=5;
				count++;
				}
				else
				{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("");
				Console.WriteLine("                            Your Answer is Wrong!");
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("                            The correct answer is:");
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("");
				Console.WriteLine("                                    answer");
				Console.ForegroundColor = ConsoleColor.White;
				Console.ReadLine();
				life--;
				}
				if (life <= 0)
				{
					GameOver();
				}
				
				Console.Clear();
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.ForegroundColor = ConsoleColor.Cyan;
				Console.Write("\t\t\tScore:"+score+"\t\t\tLife:"+life+"\n\n");
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("");
				Console.WriteLine("            3.");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.WriteLine("                              Enter Your Answer:");
				Console.Write("     \t\t\t\t ");
				ans = Console.ReadLine();
				if (ans == "Friends with Benefits" || ans == "friends with benefits")
				{
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("");
				Console.WriteLine("                           Your Answer is Correct!");
				Console.ForegroundColor = ConsoleColor.White;
				Console.ReadLine();
				score+=5;
				count++;
				}
				else
				{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("");
				Console.WriteLine("                            Your Answer is Wrong!");
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("                            The correct answer is:");
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("");
				Console.WriteLine("                                   answer");
				Console.ForegroundColor = ConsoleColor.White;
				Console.ReadLine();
				life--;
				}
				if (life <= 0)
				{
					GameOver();
				}
				
				Console.Clear();
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.ForegroundColor = ConsoleColor.Cyan;
				Console.Write("\t\t\tScore:"+score+"\t\t\tLife:"+life+"\n\n");
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("");
				Console.WriteLine("            4.");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.WriteLine("                              Enter Your Answer:");
				Console.Write("     \t\t\t\t ");
				ans = Console.ReadLine();
				if (ans == "")
				{
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("");
				Console.WriteLine("                           Your Answer is Correct!");
				Console.ForegroundColor = ConsoleColor.White;
				Console.ReadLine();
				score+=5;
				count++;
				}
				else
				{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("");
				Console.WriteLine("                            Your Answer is Wrong!");
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("                            The correct answer is:");
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("");
				Console.WriteLine("                                   answer");
				Console.ForegroundColor = ConsoleColor.White;
				Console.ReadLine();
				life--;
				}
				if (life <= 0)
				{
					GameOver();
				}
				
				Console.Clear();
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.ForegroundColor = ConsoleColor.Cyan;
				Console.Write("\t\t\tScore:"+score+"\t\t\tLife:"+life+"\n\n");
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("");
				Console.WriteLine("            5.");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.WriteLine("                              Enter Your Answer:");
				Console.Write("     \t\t\t\t ");
				ans = Console.ReadLine();
				if (ans == "Neighbors" || ans == "neighbors")
				{
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("");	
				Console.WriteLine("                           Your Answer is Correct!");
				Console.ForegroundColor = ConsoleColor.White;
				Console.ReadLine();
				score+=5;
				count++;
				}
				else
				{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("");
				Console.WriteLine("                            Your Answer is Wrong!");
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("                            The correct answer is:");
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("");
				Console.WriteLine("                                   answer");
				Console.ForegroundColor = ConsoleColor.White;
				Console.ReadLine();
				life--;
				}
				if (life <= 0)
				{
					GameOver();
				}
				Console.Clear();
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.WriteLine("");
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("                                 Congratulations! ");
				Console.WriteLine("");
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("                         You finished the  Genre!");
				Console.WriteLine("                          with the total score of "+score+"");
				Console.WriteLine("");
				Console.WriteLine("                          Press 'Enter' to Continue..");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.ReadLine();
				Genre();
			}
			
			public static void ()
			{
				Console.ForegroundColor = ConsoleColor.White;
				string ans;
				Console.Clear();
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.ForegroundColor = ConsoleColor.Cyan;				
				Console.Write("\t\t\tScore:"+score+"\t\t\tLife:"+life+"\n\n");
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("");
				Console.WriteLine("            1.");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.WriteLine("                              Enter Your Answer:");
				Console.Write("     \t\t\t\t ");
				ans = Console.ReadLine();
				if (ans == "")
				{
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("");
				Console.WriteLine("                           Your Answer is Correct!");
				Console.ForegroundColor = ConsoleColor.White;
				Console.ReadLine();
				score+=5;
				count++;
				}
				else
				{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("");
				Console.WriteLine("                            Your Answer is Wrong!");
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("                            The correct answer is:");
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("");
				Console.WriteLine("                                   answer");
				Console.ForegroundColor = ConsoleColor.White;
				Console.ReadLine();
				life--;
				}
				if (life <= 0)
				{
					GameOver();
				}
				

				Console.Clear();
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.ForegroundColor = ConsoleColor.Cyan;
				Console.Write("\t\t\tScore:"+score+"\t\t\tLife:"+life+"\n\n");
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("");
				Console.WriteLine("            2. ");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.WriteLine("                              Enter Your Answer:");
				Console.Write("     \t\t\t\t ");
				ans = Console.ReadLine();
				if (ans == ")
				{
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("");
				Console.WriteLine("                           Your Answer is Correct!");
				Console.ForegroundColor = ConsoleColor.White;
				Console.ReadLine();
				score+=5;
				count++;
				}
				else
				{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("");
				Console.WriteLine("                            Your Answer is Wrong!");
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("                            The correct answer is:");
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("");
				Console.WriteLine("                                    answer");
				Console.ForegroundColor = ConsoleColor.White;
				Console.ReadLine();
				life--;
				}
				if (life <= 0)
				{
					GameOver();
				}
				
				Console.Clear();
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.ForegroundColor = ConsoleColor.Cyan;
				Console.Write("\t\t\tScore:"+score+"\t\t\tLife:"+life+"\n\n");
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("");
				Console.WriteLine("            3.");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.WriteLine("                              Enter Your Answer:");
				Console.Write("     \t\t\t\t ");
				ans = Console.ReadLine();
				if (ans == "")
				{
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("");
				Console.WriteLine("                           Your Answer is Correct!");
				Console.ForegroundColor = ConsoleColor.White;
				Console.ReadLine();
				score+=5;
				count++;
				}
				else
				{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("");
				Console.WriteLine("                            Your Answer is Wrong!");
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("                            The correct answer is:");
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("");
				Console.WriteLine("                                   answer");
				Console.ForegroundColor = ConsoleColor.White;
				Console.ReadLine();
				life--;
				}
				if (life <= 0)
				{
					GameOver();
				}
				
				Console.Clear();
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.ForegroundColor = ConsoleColor.Cyan;
				Console.Write("\t\t\tScore:"+score+"\t\t\tLife:"+life+"\n\n");
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("");
				Console.WriteLine("            4.");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.WriteLine("                              Enter Your Answer:");
				Console.Write("     \t\t\t\t ");
				ans = Console.ReadLine();
				if (ans == "")
				{
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("");
				Console.WriteLine("                           Your Answer is Correct!");
				Console.ForegroundColor = ConsoleColor.White;
				Console.ReadLine();
				score+=5;
				count++;
				}
				else
				{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("");
				Console.WriteLine("                            Your Answer is Wrong!");
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("                            The correct answer is:");
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("");
				Console.WriteLine("                                   answer");
				Console.ForegroundColor = ConsoleColor.White;
				Console.ReadLine();
				life--;
				}
				if (life <= 0)
				{
					GameOver();
				}
				
				Console.Clear();
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.ForegroundColor = ConsoleColor.Cyan;
				Console.Write("\t\t\tScore:"+score+"\t\t\tLife:"+life+"\n\n");
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("");
				Console.WriteLine("            5. ");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.WriteLine("                              Enter Your Answer:");
				Console.Write("     \t\t\t\t ");
				ans = Console.ReadLine();
				if (ans == "")
				{
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("");	
				Console.WriteLine("                           Your Answer is Correct!");
				Console.ForegroundColor = ConsoleColor.White;
				Console.ReadLine();
				score+=5;
				count++;
				}
				else
				{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("");
				Console.WriteLine("                            Your Answer is Wrong!");
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("                            The correct answer is:");
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("");
				Console.WriteLine("                                   answer ");
				Console.ForegroundColor = ConsoleColor.White;
				Console.ReadLine();
				}
				if (life <= 0)
				{
					GameOver();
				}
				Console.Clear();
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.WriteLine("");
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("                                 Congratulations! ");
				Console.WriteLine("");
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("                         You finished the Comedy Genre!");
				Console.WriteLine("                          with the total score of "+score+"");
				Console.WriteLine("");
				Console.WriteLine("                          Press 'Enter' to Continue..");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.ReadLine();
				Genre();
			}
			
			public static void ()
			{
				Console.ForegroundColor = ConsoleColor.White;
				string ans;
				Console.Clear();
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.ForegroundColor = ConsoleColor.Cyan;				
				Console.Write("\t\t\tScore:"+score+"\t\t\tLife:"+life+"\n\n");
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("");
				Console.WriteLine("            1. ");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.WriteLine("                              Enter Your Answer:");
				Console.Write("     \t\t\t\t ");
				ans = Console.ReadLine();
				if (ans == "Cam" || ans == "cam")
				{
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("");
				Console.WriteLine("                           Your Answer is Correct!");
				Console.ForegroundColor = ConsoleColor.White;
				Console.ReadLine();
				score+=5;
				count++;
				}
				else
				{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("");
				Console.WriteLine("                            Your Answer is Wrong!");
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("                            The correct answer is:");
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine(""); 
				Console.WriteLine("                                    answer");
				Console.ForegroundColor = ConsoleColor.White;
				Console.ReadLine();
				life--;
				}
				if (life <= 0)
				{
					GameOver();
				}
				

				Console.Clear();
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.ForegroundColor = ConsoleColor.Cyan;
				Console.Write("\t\t\tScore:"+score+"\t\t\tLife:"+life+"\n\n");
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("");
				Console.WriteLine("            2. ");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.WriteLine("                              Enter Your Answer:");
				Console.Write("     \t\t\t\t ");
				ans = Console.ReadLine();
				if (ans == "")
				{
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("");
				Console.WriteLine("                           Your Answer is Correct!");
				Console.ForegroundColor = ConsoleColor.White;
				Console.ReadLine();
				score+=5;
				count++;
				}
				else
				{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("");
				Console.WriteLine("                            Your Answer is Wrong!");
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("                            The correct answer is:");
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("");
				Console.WriteLine("                                   answer");
				Console.ForegroundColor = ConsoleColor.White;
				Console.ReadLine();
				life--;
				}
				if (life <= 0)
				{
					GameOver();
				}
				
				Console.Clear();
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.ForegroundColor = ConsoleColor.Cyan;
				Console.Write("\t\t\tScore:"+score+"\t\t\tLife:"+life+"\n\n");
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("");
				Console.WriteLine("            3.");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.WriteLine("                              Enter Your Answer:");
				Console.Write("     \t\t\t\t ");
				ans = Console.ReadLine();
				if (ans == "")
				{
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("");
				Console.WriteLine("                           Your Answer is Correct!");
				Console.ForegroundColor = ConsoleColor.White;
				Console.ReadLine();
				score+=5;
				count++;
				}
				else
				{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("");
				Console.WriteLine("                            Your Answer is Wrong!");
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("                            The correct answer is:");
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("");
				Console.WriteLine("                                   answer");
				Console.ForegroundColor = ConsoleColor.White;
				Console.ReadLine();
				life--;
				}
				if (life <= 0)
				{
					GameOver();
				}
				
				Console.Clear();
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.ForegroundColor = ConsoleColor.Cyan;
				Console.Write("\t\t\tScore:"+score+"\t\t\tLife:"+life+"\n\n");
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("");
				Console.WriteLine("            4. ");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.WriteLine("                              Enter Your Answer:");
				Console.Write("     \t\t\t\t ");
				ans = Console.ReadLine();
				if (ans == "")
				{
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("");
				Console.WriteLine("                           Your Answer is Correct!");
				Console.ForegroundColor = ConsoleColor.White;
				Console.ReadLine();
				score+=5;
				count++;
				}
				else
				{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("");
				Console.WriteLine("                            Your Answer is Wrong!");
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("                            The correct answer is:");
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("");
				Console.WriteLine("                                   answer");
				Console.ForegroundColor = ConsoleColor.White;
				Console.ReadLine();
				life--;
				}
				if (life <= 0)
				{
					GameOver();
				}
				
				Console.Clear();
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.ForegroundColor = ConsoleColor.Cyan;
				Console.Write("\t\t\tScore:"+score+"\t\t\tLife:"+life+"\n\n");
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("");
				Console.WriteLine("            5.   ");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.WriteLine("                              Enter Your Answer:");
				Console.Write("     \t\t\t\t ");
				ans = Console.ReadLine();
				if (ans == "")
				{
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("");	
				Console.WriteLine("                           Your Answer is Correct!");
				Console.ForegroundColor = ConsoleColor.White;
				Console.ReadLine();
				score+=5;
				count++;
				}
				else
				{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("");
				Console.WriteLine("                            Your Answer is Wrong!");
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("                            The correct answer is:");
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("");
				Console.WriteLine("                                    answer");
				Console.ForegroundColor = ConsoleColor.White;
				Console.ReadLine();
				life--;
				}
				if (life <= 0)
				{
					GameOver();
				}
				Console.Clear();
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.WriteLine("");
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("                                 Congratulations! ");
				Console.WriteLine("");
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("                         You finished the Random Genre!");
				Console.WriteLine("                          with the total score of "+score+"");
				Console.WriteLine("");
				Console.WriteLine("                          Press 'Enter' to Continue..");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.ReadLine();
				Genre();
			}
			
			public static void GameOver()
			{	
			int choosexit;
			Console.Clear();
			Console.WriteLine("");
			Console.WriteLine("");
			Console.WriteLine("");
			Console.WriteLine("");
			Console.WriteLine("");
			Console.WriteLine("");
			Console.WriteLine("            =======================================================");
			Console.WriteLine("");
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine("                                   Game Over! ");
			Console.WriteLine("");
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("                         You've got a total score of "+score+"");
			Console.WriteLine("");
			Console.WriteLine("                               |  1. Main Menu  |");
			Console.WriteLine("                               |    2. Exit     |");
			Console.WriteLine("");
			Console.WriteLine("");
			Console.WriteLine("            =======================================================");
			Console.Write("\t\t\t\tSelect Your Choice: ");
			Console.Write("\t\t\t\t\t\t\t\t\t ");
			choosexit = Convert.ToInt32(Console.ReadLine());
			if (choosexit == 1)
			{
				life = 3;
				score = 0;
				Menu();
			}
			else
			{
			Console.ForegroundColor = ConsoleColor.White;	
			int lastexit;
			Console.Clear();
			Console.WriteLine("");
			Console.WriteLine("");
			Console.WriteLine("");
			Console.WriteLine("");
			Console.WriteLine("");
			Console.WriteLine("");
			Console.WriteLine("            =======================================================");
			Console.WriteLine("");
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine("                          Do you really want to exit? ");
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("");
			Console.WriteLine("                                  |  1. Yes  |");
			Console.WriteLine("                                  |  2. No   |");
			Console.WriteLine("");
			Console.WriteLine("");
			Console.WriteLine("            =======================================================");
			Console.Write("\t\t\t\tSelect Your Choice: ");
			Console.Write("\t\t\t\t\t\t\t\t\t ");
			lastexit = Convert.ToInt32(Console.ReadLine());
			if (lastexit == 1)
			{
				Environment.Exit(0);
			}
			
			}
		}
	}
}