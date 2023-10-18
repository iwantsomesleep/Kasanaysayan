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
            Start();
            Foreword();
            ChapterOne();
            QuizGame();
            test();
        }
        static void Start()
        {
            // center book
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + ("_.--._  _.--._".Length / 2)) + "}", "_.--._  _.--._"));
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (@",-=.- "":;:;:;\':;:;:;""-._".Length / 2)) + "}", @",-=.- "":;:;:;\':;:;:;""-._"));
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (@"\\\:;:;:;:;:;\:;:;:;:;:;\".Length / 2)) + "}", @"\\\:;:;:;:;:;\:;:;:;:;:;\"));
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (@" \\\:;:;:;:;:;\:;:;:;:;:;\".Length / 2)) + "}", @"\\\:;:;:;:;:;\:;:;:;:;:;\"));
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (@"  \\\:;:;:;:;:;\:;:;:;:;:;\".Length / 2)) + "}", @"\\\:;:;:;:;:;\:;:;:;:;:;\"));
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (@"   \\\:;:;:;:;:;\:;::;:;:;:\".Length / 2)) + "}", @"\\\:;:;:;:;:;\:;::;:;:;:\"));
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (@"    \\\;:;::;:;:;\:;:;:;::;:\".Length / 2)) + "}", @"\\\;:;::;:;:;\:;:;:;::;:\"));
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (@"     \\\;;:;:_:--:\:_:--:_;:;\".Length / 2)) + "}", @"\\\;;:;:_:--:\:_:--:_;:;\"));
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (@"      \\\_.-""      :      ""-._\".Length / 2)) + "}", @"\\\_.-""      :      ""-._\"));
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (@"       \`_..--""""--.;.--""""--.._=>".Length / 2)) + "}", @"\`_..--""""--.;.--""""--.._=>"));

            // center title
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (@" __                                                                                            ".Length / 2)) + "}", @" __                                                                                            "));
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (@"[  |  _                                                                                        ".Length / 2)) + "}", @"[  |  _                                                                                        "));
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (@" | | / ]  ,--.   .--.   ,--.   _ .--.   ,--.    _   __  .--.   ,--.    _   __  ,--.   _ .--.   ".Length / 2)) + "}", @" | | / ]  ,--.   .--.   ,--.   _ .--.   ,--.    _   __  .--.   ,--.    _   __  ,--.   _ .--.   "));
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (@" | '' <  `'_\ : ( (`\] `'_\ : [ `.-. | `'_\ :  [ \ [  ]( (`\] `'_\ :  [ \ [  ]`'_\ : [ `.-. |  ".Length / 2)) + "}", @" | '' <  `'_\ : ( (`\] `'_\ : [ `.-. | `'_\ :  [ \ [  ]( (`\] `'_\ :  [ \ [  ]`'_\ : [ `.-. |  "));
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (@" | |`\ \ // | |, `'.'. // | |, | | | | // | |,  \ '/ /  `'.'. // | |,  \ '/ / // | |, | | | |  ".Length / 2)) + "}", @" | |`\ \ // | |, `'.'. // | |, | | | | // | |,  \ '/ /  `'.'. // | |,  \ '/ / // | |, | | | |  "));
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (@"[__|  \_]\'-;__/[\__) )\'-;__/[___||__]\'-;__/[\_:  /  [\__) )\'-;__/[\_:  /  \'-;__/[___||__] ".Length / 2)) + "}", @"[__|  \_]\'-;__/[\__) )\'-;__/[___||__]\'-;__/[\_:  /  [\__) )\'-;__/[\_:  /  \'-;__/[___||__] "));
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (@"                                               \__.'                  \__.'                    ".Length / 2)) + "}", @"                                               \__.'                  \__.'                    "));
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n");

            // press any key to start 
            string pressAnyKey = "PRESS ANY KEY TO START.";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (pressAnyKey.Length / 2)) + "}", pressAnyKey));
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey(true);
            Thread.Sleep(500);
            Console.Clear();

            Console.Write("This is the story of... ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            currentPlayer.name = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(currentPlayer.name);
        }

        static void Foreword()
        {
            Console.WriteLine("hi!");
        }
        static void ChapterOne()
        {
            string chapterOneTitle = "CHAPTER ONE: MAJOHA";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (chapterOneTitle.Length / 2)) + "}", chapterOneTitle));
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("You open your eyes to a colosseum-like scene, wherein ");
        }

        static void QuizGame()
        {
            Console.WriteLine("A history book appears in front of you, with blank pages for you to seemingly fill in.");

            while (true)
            {
                // 

                Console.WriteLine("The three priests who were martyred are collectively called _____. These priests are ___, ____, and _____.");
                string[] correctAnswers = { "GOMBURZA", "Gomez", "Burgos", "Zamora" };

                string userAnswers = Console.ReadLine();

                if (currentPlayer.revisionismPoints == 3)
                {
                    Console.WriteLine("You have received 3 revisionism points. You must restart the chapter.");
                    currentPlayer.revisionismPoints = 0;
                    QuizGame();
                }
                else if (userAnswers == correctAnswers[0])
                {
                    Console.WriteLine("You are correct!");

                    Console.Write(correctAnswers[0] + " ");
                    Console.Write(correctAnswers[1] + " ");
                    Console.Write(correctAnswers[2] + " ");
                    Console.Write(correctAnswers[3] + " ");
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