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
				Console.WriteLine("                         Kobie Oracion & Jadee Mae Mallari");
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
			Console.WriteLine("                                 |  1. Action   |");
			Console.WriteLine("                                 |  2. Anime    |");
			Console.WriteLine("                                 |  3. Horror   |");
			Console.WriteLine("                                 |  4. Romance  |");
			Console.WriteLine("                                 |  5. Musical  |");
			Console.WriteLine("                                 |  6. Comedy   |");
			Console.WriteLine("                                 |  7. Random   |");
			Console.WriteLine("                                 |  8. Exit     |");
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
				Console.WriteLine("                              Action Genre Category! ");
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
				Console.WriteLine("                              Anime Genre Category! ");
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
				Anime();
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
				Console.WriteLine("                               Horror Genre Category! ");
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
				Horror();
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
				Console.WriteLine("                               Romance Genre Category! ");
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
				Romance();
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
				Console.WriteLine("                              Musical Genre Category! ");
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
				Musical();
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
				Console.WriteLine("                               Comedy Genre Category! ");
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
				Comedy();
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
				Console.WriteLine("                               Random Genre Category! ");
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
				Random();
			}
			else if (choosegenre == 8)
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
			public static void Action()
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
				Console.WriteLine("            1.The heroes are fighting a powerful being to stop him ");
				Console.WriteLine("            from collecting some magical stones that can destroy ");
				Console.WriteLine("                               half the universe.");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.WriteLine("                              Enter Your Answer:");
				Console.Write("     \t\t\t\t ");
				ans = Console.ReadLine();
				if (String.Compare(ans, "infinity war", true) == 0)
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
				Console.WriteLine("                                 Infinity War");
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
				Console.WriteLine("            2.A rich billionare from Gotham City that fights crime ");
				Console.WriteLine("                             and serves justice. ");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.WriteLine("                              Enter Your Answer:");
				Console.Write("     \t\t\t\t ");
				ans = Console.ReadLine();
				if (String.Compare(ans, "batman", true) == 0)
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
				Console.WriteLine("                                    Batman");
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
				Console.WriteLine("            3. An ex special forces that turned into mutant by a ");
				Console.WriteLine("            rouge experement which gives him the ability to heal. ");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.WriteLine("                              Enter Your Answer:");
				Console.Write("     \t\t\t\t ");
				ans = Console.ReadLine();
				if (String.Compare(ans, "deadpool", true) == 0)
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
				Console.WriteLine("                                  Deadpool");
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
				Console.WriteLine("            4. A time traveling machine that has a mission to kill  ");
				Console.WriteLine("                                a certain person.");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.WriteLine("                              Enter Your Answer:");
				Console.Write("     \t\t\t\t ");
				ans = Console.ReadLine();
				if (String.Compare(ans, "terminator", true) == 0)
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
				Console.WriteLine("                                 Terminator");
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
				Console.WriteLine("            5. He comes from the planet Krypton as he was sent to ");
				Console.WriteLine("            earth by his parents to save him from the destruction ");
				Console.WriteLine("                                 of their planet.");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.WriteLine("                              Enter Your Answer:");
				Console.Write("     \t\t\t\t ");
				ans = Console.ReadLine();
				if (String.Compare(ans, "superman", true) == 0)
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
				Console.WriteLine("                                   Superman");
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
				Console.WriteLine("                        You finished the Action Genre!");
				Console.WriteLine("                          with the total score of "+score+"");
				Console.WriteLine("");
				Console.WriteLine("                           Press 'Enter' to Continue..");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.ReadLine();
				Genre();
			}
			public static void Anime()
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
				Console.WriteLine("            1.The story of Saitama, a hero that does it just for ");
				Console.WriteLine("              fun & can defeat his enemies with a single punch. ");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.WriteLine("                              Enter Your Answer:");
				Console.Write("     \t\t\t\t ");
				ans = Console.ReadLine();
				if (String.Compare(ans, "one punch man", true) == 0)
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
				Console.WriteLine("                                One Punch Man");
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
				Console.WriteLine("            2.The story of a kid who is the son of the 4th Hokage ");
				Console.WriteLine("            Minato Uzumaki who dreams to be a hokage himself in ");
				Console.WriteLine("                                   the future");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.WriteLine("                              Enter Your Answer:");
				Console.Write("     \t\t\t\t ");
				ans = Console.ReadLine();
				if (String.Compare(ans, "naruto", true) == 0)
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
				Console.WriteLine("                                   Naruto");
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
				Console.WriteLine("            3.This is a story about a pirate named Monkey D. Luffy  ");
				Console.WriteLine("                who wants to be the King of the Pirates someday. ");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.WriteLine("                              Enter Your Answer:");
				Console.Write("     \t\t\t\t ");
				ans = Console.ReadLine();
				if (String.Compare(ans, "one piece", true) == 0)
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
				Console.WriteLine("                                  One Piece");
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
				Console.WriteLine("            4. Tokyo is haunted by mysterious ghouls who are");
				Console.WriteLine("            devouring humans. People are gripped by the fear of");
				Console.WriteLine("             hese ghouls whose identities are masked inmystery.");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.WriteLine("                              Enter Your Answer:");
				Console.Write("     \t\t\t\t ");
				ans = Console.ReadLine();
				if (String.Compare(ans, "tokyo ghoul", true) == 0)
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
				Console.WriteLine("                                 Tokyo Ghoul");
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
				Console.WriteLine("            5. Hinata Shouyou, a short middle school student, gained  ");
				Console.WriteLine("              a sudden love of volleyball after watching a national");
				Console.WriteLine("                           championship match on TV.");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.WriteLine("                              Enter Your Answer:");
				Console.Write("     \t\t\t\t ");
				ans = Console.ReadLine();
				if (String.Compare(ans, "haikyuu", true) == 0)
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
				Console.WriteLine("                                   Haikyuu");
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
				Console.WriteLine("                         You finished the Anime Genre!");
				Console.WriteLine("                          with the total score of "+score+"");
				Console.WriteLine("");
				Console.WriteLine("                          Press 'Enter' to Continue..");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.ReadLine();
				Genre();
			}
			
			public static void Horror()
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
				Console.WriteLine("            1.A young woman is involuntarily committed to a mental ");
				Console.WriteLine("             institution, where she is confronted by her greatest ");
				Console.WriteLine("              fear--but is it real or a product of her delusion?");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.WriteLine("                              Enter Your Answer:");
				Console.Write("     \t\t\t\t ");
				ans = Console.ReadLine();
				if (String.Compare(ans, "unsane", true) == 0)
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
				Console.WriteLine("                                   Unsane");
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
				Console.WriteLine("                       2.If they hear you, they hunt you. ");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.WriteLine("                              Enter Your Answer:");
				Console.Write("     \t\t\t\t ");
				ans = Console.ReadLine();
				if (String.Compare(ans, "a quiet place", true) == 0)
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
				Console.WriteLine("                                A Quiet Place");
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
				Console.WriteLine("            3. A violent teen and three others kidnap a young nurse ");
				Console.WriteLine("                  while escaping from a Texas mental institution.");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.WriteLine("                              Enter Your Answer:");
				Console.Write("     \t\t\t\t ");
				ans = Console.ReadLine();
				if (String.Compare(ans, "leatherface", true) == 0)
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
				Console.WriteLine("                                 Leatherface");
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
				Console.WriteLine("            4.After taking a wrong turn on the highway, a young couple ");
				Console.WriteLine("            decide to stop at a roadside diner for food and relaxation.");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.WriteLine("                              Enter Your Answer:");
				Console.Write("     \t\t\t\t ");
				ans = Console.ReadLine();
				if (String.Compare(ans, "the farm", true) == 0)
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
				Console.WriteLine("                                   The Farm");
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
				Console.WriteLine("            5.A group of their college friends travel to Mexico for  ");
				Console.WriteLine("            one last getaway before graduation. While there, a stranger ");
				Console.WriteLine("               convinces one of the students to play a harmless game.");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.WriteLine("                              Enter Your Answer:");
				Console.Write("     \t\t\t\t ");
				ans = Console.ReadLine();
				if (String.Compare(ans, "truth or dare", true) == 0)
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
				Console.WriteLine("                                Truth or Dare");
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
				Console.WriteLine("                         You finished the Horror Genre!");
				Console.WriteLine("                          with the total score of "+score+"");
				Console.WriteLine("");
				Console.WriteLine("                          Press 'Enter' to Continue..");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.ReadLine();
				Genre();
			}
			
			public static void Romance()
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
				Console.WriteLine("            1.A couple with a tumultuous romantic past finds married ");
				Console.WriteLine("                          life to be just as difficult.");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.WriteLine("                              Enter Your Answer:");
				Console.Write("     \t\t\t\t ");
				ans = Console.ReadLine();
				if (String.Compare(ans, "a second chance", true) == 0)
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
				Console.WriteLine("                                A Second Chance");
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
				Console.WriteLine("            2.A poor young woman becomes a personal maid for a rich ");
				Console.WriteLine("            and handsome young man. The two do not get along at first, ");
				Console.WriteLine("                       but as their lives become entangled.");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.WriteLine("                              Enter Your Answer:");
				Console.Write("     \t\t\t\t ");
				ans = Console.ReadLine();
				if (String.Compare(ans, "diary ng panget", true) == 0)
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
				Console.WriteLine("                               Diary ng Panget");
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
				Console.WriteLine("            3.As enigmatic as he is rich and powerful, finds himself  ");
				Console.WriteLine("              strangely drawn to her.Though sexually inexperienced.");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.WriteLine("                              Enter Your Answer:");
				Console.Write("     \t\t\t\t ");
				ans = Console.ReadLine();
				if (String.Compare(ans, "fifthy shades of grey", true) == 0)
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
				Console.WriteLine("                             Fifty Shades of Grey");
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
				Console.WriteLine("            4.A high school student finds herself face-to-face with ");
				Console.WriteLine("            her long-term crush when she signs up to run a kissing ");
				Console.WriteLine("                         booth at the spring carnival.");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.WriteLine("                              Enter Your Answer:");
				Console.Write("     \t\t\t\t ");
				ans = Console.ReadLine();
				if (String.Compare(ans, "the kissing booth", true) == 0)
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
				Console.WriteLine("                              The Kissing Booth");
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
				Console.WriteLine("            5.A woman struggling to meet airline baggage requirements  ");
				Console.WriteLine("            meets a man who comes to her aid. They form a friendship ");
				Console.WriteLine("                    that helps them mend each other's hearts. ");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.WriteLine("                              Enter Your Answer:");
				Console.Write("     \t\t\t\t ");
				ans = Console.ReadLine();
				if (String.Compare(ans, "that thing called tadhana", true) == 0)
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
				Console.WriteLine("                           That Thing Called Tadhana");
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
				Console.WriteLine("                         You finished the Romance Genre!");
				Console.WriteLine("                          with the total score of "+score+"");
				Console.WriteLine("");
				Console.WriteLine("                          Press 'Enter' to Continue..");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.ReadLine();
				Genre();
			}
			
			public static void Comedy()
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
				Console.WriteLine("            1.Kevin prompts Oz, Finch, Jim, and Kevin to pledge to no   ");
				Console.WriteLine("                longer be virgins by their high school graduation. ");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.WriteLine("                              Enter Your Answer:");
				Console.Write("     \t\t\t\t ");
				ans = Console.ReadLine();
				if (String.Compare(ans, "american pie", true) == 0)
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
				Console.WriteLine("                                American Pie");
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
				Console.WriteLine("            2. Beca reluctantly auditions by performing 'Cups (When");
				Console.WriteLine("                      I'm Gone)', and joins the Bellas.  ");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.WriteLine("                              Enter Your Answer:");
				Console.Write("     \t\t\t\t ");
				ans = Console.ReadLine();
				if (String.Compare(ans, "pitch perfect", true) == 0)
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
				Console.WriteLine("                                Pitch Perfect");
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
				Console.WriteLine("            3.One night, they get on the topic of sex and relationships.  ");
				Console.WriteLine("             They come to the conclusion that sex should not come with   ");
				Console.WriteLine("                         so many emotional attachments.");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.WriteLine("                              Enter Your Answer:");
				Console.Write("     \t\t\t\t ");
				ans = Console.ReadLine();
				if (String.Compare(ans, "friends with benefits", true) == 0)
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
				Console.WriteLine("                            Friends with Benefits");
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
				Console.WriteLine("            4.While fighting with and feeding on a human scavenger party,   ");
				Console.WriteLine("                  R meets Julie and feels an urge to protect her.  ");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.WriteLine("                              Enter Your Answer:");
				Console.Write("     \t\t\t\t ");
				ans = Console.ReadLine();
				if (String.Compare(ans, "warm bodies", true) == 0)
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
				Console.WriteLine("                                 Warm Bodies");
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
				Console.WriteLine("            5. Kelly and Mac are settling down in a quiet neighborhood    ");
				Console.WriteLine("                 with their newborn child, until the frat brothers ");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.WriteLine("                              Enter Your Answer:");
				Console.Write("     \t\t\t\t ");
				ans = Console.ReadLine();
				if (String.Compare(ans, "neighbors", true) == 0)
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
				Console.WriteLine("                                  Neighbors");
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
			
			public static void Musical()
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
				Console.WriteLine("            1.Thirsty for innovation and hungry for success, the son  ");
				Console.WriteLine("            of a tailor will manage to open a wax museum but will soon ");
				Console.WriteLine("                     shift focus to the unique and peculiar.");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.WriteLine("                              Enter Your Answer:");
				Console.Write("     \t\t\t\t ");
				ans = Console.ReadLine();
				if (String.Compare(ans, "the greatest showman", true) == 0)
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
				Console.WriteLine("                            The Greatest Showman");
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
				Console.WriteLine("            2. The only way to heal the island is to persuade Maui to  ");
				Console.WriteLine("               return Te Fiti's heart, so Moana sets off on an epic  ");
				Console.WriteLine("                          journey across the Pacific.");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.WriteLine("                              Enter Your Answer:");
				Console.Write("     \t\t\t\t ");
				ans = Console.ReadLine();
				if (String.Compare(ans, "moana", true) == 0)
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
				Console.WriteLine("                                    Moana");
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
				Console.WriteLine("            3.Her mounting emotions trigger the magic, accidentally ");
				Console.WriteLine("               setting off an eternal winter that she can't stop.  ");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.WriteLine("                              Enter Your Answer:");
				Console.Write("     \t\t\t\t ");
				ans = Console.ReadLine();
				if (String.Compare(ans, "frozen", true) == 0)
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
				Console.WriteLine("                                   Frozen");
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
				Console.WriteLine("            4.One day, the bandit Flynn Ryder scales the tower and is  ");
				Console.WriteLine("             taken captive by Rapunzel. Rapunzel strikes a deal with  ");
				Console.WriteLine("                              the charming thief.");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.WriteLine("                              Enter Your Answer:");
				Console.Write("     \t\t\t\t ");
				ans = Console.ReadLine();
				if (String.Compare(ans, "tangled", true) == 0)
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
				Console.WriteLine("                                   Tangled");
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
				Console.WriteLine("            5. A young prince, imprisoned in the form of a beast, can   ");
				Console.WriteLine("                  be freed only by true love. What may be his only  ");
				Console.WriteLine("                    opportunity arrives when he meets Belle. ");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.WriteLine("                              Enter Your Answer:");
				Console.Write("     \t\t\t\t ");
				ans = Console.ReadLine();
				if (String.Compare(ans, "beauty and the beast", true) == 0)
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
				Console.WriteLine("                             Beauty and the Beast");
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
			
			public static void Random()
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
				Console.WriteLine("            1.A camgirl has her principles, until a mysterious woman  ");
				Console.WriteLine("                who looks just like her takes over her channel.");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.WriteLine("                              Enter Your Answer:");
				Console.Write("     \t\t\t\t ");
				ans = Console.ReadLine();
				if (String.Compare(ans, "cam", true) == 0)
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
				Console.WriteLine("                                     Cam");
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
				Console.WriteLine("            2.A wedding planner has had a long string of boyfriends.  ");
				Console.WriteLine("                  Unfortunately for her, they've all been gay.");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.WriteLine("                              Enter Your Answer:");
				Console.Write("     \t\t\t\t ");
				ans = Console.ReadLine();
				if (String.Compare(ans, "bakit lahat ng gwapo may boyfriend", true) == 0)
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
				Console.WriteLine("                     Bakit Lahat ng Gwapo may Boyfriend?");
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
				Console.WriteLine("            3.Detective investigates an explosion that occurs on the");
				Console.WriteLine("            opening day of a large Tokyo resort and convention center.");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.WriteLine("                              Enter Your Answer:");
				Console.Write("     \t\t\t\t ");
				ans = Console.ReadLine();
				if (String.Compare(ans, "detective conan") == 0)
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
				Console.WriteLine("                               Detective Conan");
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
				Console.WriteLine("            4. In 19th-century France, who for decades has been hunted ");
				Console.WriteLine("            by the ruthless policeman after breaking parole, agrees to ");
				Console.WriteLine("                       care for a factory worker's daughter.");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.WriteLine("                              Enter Your Answer:");
				Console.Write("     \t\t\t\t ");
				ans = Console.ReadLine();
				if (String.Compare(ans, "les miserables", true) == 0)
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
				Console.WriteLine("                               Les Miserables");
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
				Console.WriteLine("            5. Must retrieve the legendary Trident of Atlan and embrace  ");
				Console.WriteLine("                       his destiny as protector of the deep. ");
				Console.WriteLine("");
				Console.WriteLine("            =======================================================");
				Console.WriteLine("                              Enter Your Answer:");
				Console.Write("     \t\t\t\t ");
				ans = Console.ReadLine();
				if (String.Compare(ans, "aquaman", true) == 0)
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
				Console.WriteLine("                                    Aquaman");
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