/*
    A tiny hangman console game
*/
using System;

namespace csharp_game_wordToFind
{
    class Program
    {
        static void Main(string[] args)
        {
            // loop over word array (1 loop = 1 word = 1 game)
            for (int i = 0, dicoSize = Dico.GetWords.Length; i < dicoSize; i++)
            {                
                char[] word = Dico.GetWords[i].ToCharArray();
                char[] wordToFind = new char[word.Length];
                int life = 0;
                bool winOrLose = false;

                //  create a blank word
                for (int j = 0; j < word.Length; j++)
                    wordToFind[j] = '-';

                while (true)
                {
                    Console.Clear();
                    Hangman.Draw(0,0,life);
                    
                    //  word found
                    if (String.Join("", word) == String.Join("", wordToFind))
                    {
                        Console.SetCursorPosition(15,3);
                        Console.WriteLine("Good game");
                        winOrLose = true;
                    }// word not
                    else if (life == 7)
                    {
                        Console.SetCursorPosition(15,3);
                        Console.WriteLine($"Lost ! The word was \"{String.Join("", word)}\"");
                        winOrLose = true;
                    }


                    if (winOrLose && i == dicoSize - 1)
                    {
                        Console.SetCursorPosition(15,3);
                        Console.Write("You played all the words");
                        i = dicoSize;
                        break;
                    }
                    else if (winOrLose)
                    {
                        Console.SetCursorPosition(15,4);
                        Console.Write("Play another word ? Y(es) N(o) ");
                        ConsoleKeyInfo playAgain = Console.ReadKey();
                        if (playAgain.KeyChar == 'n' || playAgain.KeyChar == 'N')
                        {
                            i = dicoSize;
                            break;
                        }
                        else break;
                    }

                    Console.SetCursorPosition(15,3);
                    Console.WriteLine($"    Word to find -> {String.Join("", wordToFind)}");

                    Console.SetCursorPosition(15,4);
                    Console.Write("Type your letter -> ");
                    ConsoleKeyInfo userGuess = Console.ReadKey();

                    if (!String.Join("", word).Contains(userGuess.KeyChar)) life++;

                    for (int k = 0; k < word.Length; k++)
                    {
                        if (userGuess.KeyChar == word[k]) wordToFind[k] = userGuess.KeyChar;
                    }
                }
            }

            Console.Clear();
            Console.SetCursorPosition(15,3);
            Console.WriteLine("Thanks for playing");
            Console.SetCursorPosition(15,4);
            Console.WriteLine("Press a key to exit");
            Console.ReadKey(true);
        }
    }
}
