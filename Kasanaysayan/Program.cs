using System;
using System.Threading;

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
            QuizGame();
            test();
        }

        static void CenterText(string text) // function to center text!
        {
            Console.WriteLine(string.Format("{0," + ((Console.WindowWidth / 2) + (text.Length / 2)) + "}", text));
        }

        static void Print(string text, int speed)
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

            Console.ForegroundColor = ConsoleColor.Yellow;
            CenterText("PRESS ANY KEY TO START.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey(true);
            Thread.Sleep(500);
            Console.Clear();

            Console.Write(string.Format("{0," + ((Console.WindowWidth / 2) + ("This is the story of ".Length / 2)) + "}", "This is the story of "));
            Console.ForegroundColor = ConsoleColor.Yellow;
            currentPlayer.name = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            // press to continue
        }

        static void Foreword()
        {
            // Print("Welcome to Kasaysayan. By turning the cover, you have now been sucked inside the world of this storybook. Don’t be worried, though, because it is full of exciting and interesting stories of our own beloved country. The only thing is, we’re sure you’ll get tired after a while, and want to escape\r\n\r\nKasanaysayan is a short storybook focused on different events throughout Philippine history. The volume you are inside right now is focused on the period when the Philippines was fighting for independence from Spain. Read through the chapter, analyze their stories, then fill in the missing information at the end to make sure you got the right information before proceeding to the next chapter. Once you finish all 6 chapters, the book will finally let you out.\r\n\r\nBe warned, however! No one likes a historical revisionist. Filling in the wrong information too many times in one chapter will send you back to the start of that chapter\n\n", 10);
            Console.ForegroundColor = ConsoleColor.Yellow;
            CenterText("Are you ready to begin?");
            Console.ForegroundColor = ConsoleColor.White;
            Thread.Sleep(2000);
            CenterText("Press any key to continue.");
            Console.ReadKey(true);
            Console.Clear();
            Thread.Sleep(3000);
        }
        static void ChapterOne()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            CenterText("CHAPTER ONE: MAJOHA");
            Console.ForegroundColor = ConsoleColor.White;
            CenterText("You open your eyes to a colosseum-like scene, wherein you see ");
        }

        static void QuizGame()
        {
            Console.WriteLine("A history book appears in front of you, with blank pages for you to seemingly fill in.");

            string[] correctAnswers = { "GOMBURZA", "Gomez", "Burgos", "Zamora" };
            int score = 0;

            while (score < 4)
            {
                Console.Clear();
                CenterText(@"┌――――――――――――――――――┐");
                CenterText(@"│     GOMBURZA     │");
                CenterText(@"│      Gomez       │");
                CenterText(@"│      Burgos      │");
                CenterText(@"│      Zamora      │");
                CenterText(@"└――――――――――――――――――┘");

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

        static void test()
        {
            Console.WriteLine("Congrats! You made it.");
        }

    }
}