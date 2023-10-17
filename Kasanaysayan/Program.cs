using System;
using System.Reflection.Metadata;
using System.Threading;
using System.Collections;

// to do: center book, add ascii art of title of the game; create introduction and sample quiz game

namespace Kasanaysayan
{
    class Program
    {
        public static Player currentPlayer = new Player();
        static void Main(string[] args)
        {
            Start(); // starting screen
            Introduction(); //
            ChapterOne();
            SampleQuizGame();
            test();
        }
        static void Start()
        {
            Console.WriteLine(@"      _.--._  _.--._
,-=.-"":;:;:;\':;:;:;""-._
\\\:;:;:;:;:;\:;:;:;:;:;\
 \\\:;:;:;:;:;\:;:;:;:;:;\
  \\\:;:;:;:;:;\:;:;:;:;:;\
   \\\:;:;:;:;:;\:;::;:;:;:\
    \\\;:;::;:;:;\:;:;:;::;:\
     \\\;;:;:_:--:\:_:--:_;:;\    
      \\\_.-""      :      ""-._\
       \`_..--""""--.;.--""""--.._=>");
            string pressAnyKey = "PRESS ANY KEY TO START.";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (pressAnyKey.Length / 2)) + "}", pressAnyKey));
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey(true);
            Thread.Sleep(1500);
            Console.Clear();
        }

        static void Introduction()
        {
            string test = "Once upon a time...";
            Console.WriteLine(test);
            Console.WriteLine("What is your name, dear traveler?");
            currentPlayer.name = Console.ReadLine();
            Console.Clear();
        }
        static void ChapterOne()
        {
            string chapterOneTitle = "CHAPTER ONE: MAJOHA";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (chapterOneTitle.Length / 2)) + "}", chapterOneTitle));
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("You see yourself ");

            Console.WriteLine(currentPlayer.name);
        }

        static void SampleQuizGame()
        {
            Console.WriteLine("A history book appears in front of you, with blank pages for you to seemingly fill in.");

            while (true)
            {

                Console.WriteLine("The three priests who were martyred are collectively called _____. These priests are ___, ____, and _____.");
                string[] correctAnswers = { "GOMBURZA", "Gomez", "Burgos", "Zamora" };

                string userAnswers = Console.ReadLine();

                if (currentPlayer.revisionismPoints == 3)
                {
                    Console.WriteLine("You have received 3 revisionism points. You must restart the chapter.");
                    currentPlayer.revisionismPoints = 0;
                    SampleQuizGame();
                }
                else if (userAnswers == correctAnswers[0])
                {
                    Console.WriteLine("You are correct!");

                    Console.WriteLine(correctAnswers[0]);
                    Console.WriteLine(correctAnswers[1]);
                    Console.WriteLine(correctAnswers[2]);
                    Console.WriteLine(correctAnswers[3]);
                    test();
                    break;
                    
                }
                else
                {
                    currentPlayer.revisionismPoints++;
                    Console.WriteLine("You are incorrect. You have received " + currentPlayer.revisionismPoints + " revisionism points.");
                }
            }

        }

        static void test()
        {
            Console.WriteLine("Congrats! You made it.");
            Console.WriteLine(currentPlayer.revisionismPoints);
        }

    }
}