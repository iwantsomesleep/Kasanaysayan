using System;
using System.Threading;
using static System.Net.Mime.MediaTypeNames;

namespace Kasanaysayan
{
    class Program
    {
        public static Player currentPlayer = new Player();
			
        static void Main(string[] args)
        {
            Start();
            Foreword();
            ChapterOne();
						ChapterOneQuiz();
						/*ChapterTwo();
						ChapterThree();
						ChapterFour();
						ChapterFive();
						ChapterSix();
						Epilogue();
						Afterword();*/
        }

        static void CenterText(string text) // function to center text!
        {
            Console.WriteLine(string.Format("{0," + ((Console.WindowWidth / 2) + (text.Length / 2)) + "}", text));
        }

				static string CenterReadLine()
				{
						Console.SetCursorPosition((Console.WindowWidth - Console.CursorLeft) / 2, Console.CursorTop);
						return Console.ReadLine();
				}
        static void Choice(string choice1, string choice2, string choice3)
        {
            Console.Write("\nDo you ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(choice1.ToUpper());
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" or ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(choice2.ToUpper());
            Console.ForegroundColor = ConsoleColor.White;
						Console.Write(" or ");
						Console.ForegroundColor = ConsoleColor.Yellow;
						Console.Write(choice3.ToUpper());
						Console.ForegroundColor = ConsoleColor.White;
            Console.Write("?");
            Console.WriteLine("");
        }

        static void Title(string text)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            CenterText(text.ToUpper());
            Console.ForegroundColor = ConsoleColor.White;
        }
        static void Typewrite(string text, int speed)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(speed);
            }
        }

        static void Start()
        {
            CenterText(@"_.--._  _.--._");
            CenterText(@",-=.- "":;:;:;\':;:;:;""-._");
            CenterText(@"\\\:;:;:;:;:;\:;:;:;:;:;\");
            CenterText(@" \\\:;:;:;:;:;\:;:;:;:;:;\");
            CenterText(@"  \\\:;:;:;:;:;\:;:;:;:;:;\");
            CenterText(@"   \\\:;:;:;:;:;\:;::;:;:;:\");
            CenterText(@"    \\\;:;::;:;:;\:;:;:;::;:\");
            CenterText(@"     \\\;;:;:_:--:\:_:--:_;:;\");
            CenterText(@"      \\\_.-""      :      ""-._\");
            CenterText(@"       \`_..--""""--.;.--""""--.._=>");

            Console.ForegroundColor = ConsoleColor.Yellow;
            CenterText(@" __                                                                                            ");
            CenterText(@"[  |  _                                                                                        ");
            CenterText(@" | | / ]  ,--.   .--.   ,--.   _ .--.   ,--.    _   __  .--.   ,--.    _   __  ,--.   _ .--.   ");
            CenterText(@" | '' <  `'_\ : ( (`\] `'_\ : [ `.-. | `'_\ :  [ \ [  ]( (`\] `'_\ :  [ \ [  ]`'_\ : [ `.-. |  ");
            CenterText(@" | |`\ \ // | |, `'.'. // | |, | | | | // | |,  \ '/ /  `'.'. // | |,  \ '/ / // | |, | | | |  ");
            CenterText(@"[__|  \_]\'-;__/[\__) )\'-;__/[___||__]\'-;__/[\_:  /  [\__) )\'-;__/[\_:  /  \'-;__/[___||__] ");
            CenterText(@"                                               \__.'                  \__.'                    ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n");

            Thread.Sleep(500);

            Title("PRESS ANY KEY TO START.");
            Console.ReadKey(true);
            Thread.Sleep(1000);
            Console.Clear();
        }

        static void Foreword()
        {
            Typewrite("Welcome to Kasaysayan. By turning the cover, you have now been sucked inside the world of this storybook. Don’t be worried, though, because it is full of exciting and interesting stories of our own beloved country. The only thing is, we’re sure you’ll get tired after a while, and want to escape", 30);
            Typewrite("\n\nKasanaysayan is a short storybook focused on different events throughout Philippine history. The volume you are inside right now is focused on the period when the Philippines was fighting for independence from Spain. Read through the chapter, analyze their stories, then fill in the missing information at the end to make sure you got the right information before proceeding to the next chapter. Once you finish all 6 chapters, the book will finally let you out.", 30);
            Typewrite("\n\nBe warned, however! No one likes a historical revisionist. Filling in the wrong information too many times in one chapter will send you back to the start of that chapter, and filling too much wrong information throughout the book will alter your fate, and possibly give you a bad ending.\n", 30);

            Title("What is your name, dear reader?");
            currentPlayer.name = Console.ReadLine(); // understand the concept behind this pls
            Thread.Sleep(2000);

            CenterText("Press any key to continue.");
            Console.ReadKey(true);
            Console.Clear();
            Thread.Sleep(3000);
        }
        static void ChapterOne()
        {
            Title("CHAPTER ONE: MAJOHA\n");

            CenterText(@"      ':.");
            CenterText(@"         []_____");
            CenterText(@"        /\      \");
            CenterText(@"    ___/  \__/\__\__");
            CenterText(@"---/\___\ |''''''|__\-- ---");
            CenterText(@"   ||'''| |''||''|''|");
            CenterText(@"   ``""""""`""`""""))""""`""""`");
            Console.WriteLine("\nYou open your eyes to a colosseum-like scene, wherein you see three priests");
					
            Choice("cry", "scream", "cry some more");
					
            CenterText("Press any button to proceed.");
            Console.ReadKey(true);
            Thread.Sleep(1000);
            Console.Clear();

        }

        static void ChapterOneQuiz()
        {
						string[] correctAnswers = { "GOMBURZA", "Gomez", "Burgos", "Zamora" };
						int score = 0;
					
            Typewrite("A history book appears in front of you, with blank pages for you to seemingly fill in.", 50);
            Thread.Sleep(2000);

					CenterText(@"  __________________   __________________");
					CenterText(@".-/|                  \ /                  |\-.");
					CenterText(@"||||                   |                   ||||");
					CenterText(@"||||                   |     GOMBURZA      ||||");
					CenterText(@"||||      Gomez        |                   ||||");
					CenterText(@"||||                   |                   ||||");
					CenterText(@"||||                   |                   ||||");
					CenterText(@"||||                   |       Burgos      ||||");
					CenterText(@"||||                   |                   ||||");
					CenterText(@"||||      Zamora       |                   ||||");
					CenterText(@"||||                   |                   ||||");
					CenterText(@"||||__________________ | __________________||||");
					CenterText(@"||/===================\|/===================\||)");
					CenterText(@"`--------------------~___~-------------------''");

            while (score < 4)
            {
                Console.WriteLine("\nThe three priests who were martyred are collectively called _____. These priests are ___, ____, and _____.");
                string[] userAnswers = Console.ReadLine().Split(", ");

                if (userAnswers.Length != correctAnswers.Length)
                {
                    Console.WriteLine("Your input is incorrect. Please try again.");
                    Thread.Sleep(5000);
                    continue;
                }

                for (int i = 0; i < userAnswers.Length; i++)
                {
                    if (userAnswers[i].Trim().Equals(correctAnswers[i], StringComparison.OrdinalIgnoreCase))
                    {
                        score++;
                    }
                    else
                    {
                        score = 0;
                        Console.WriteLine($"{userAnswers[i]} is incorrect. Please try again.");
                        Thread.Sleep(1500);
                    }
                }
            }

            Console.WriteLine("You got all of the items correct!");
        }
    }
}