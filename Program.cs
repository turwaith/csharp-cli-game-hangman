/*
    A tiny wordToFind console game
*/
using System;

namespace csharp_game_wordToFind
{
    class Program
    {
        static void Main(string[] args)
        {
            Hangman hangman = new Hangman();

            // loop over word array (1 loop = 1 word = 1 game)
            for (int i = 0, dicoSize = Dico.dictionnary.Length; i < dicoSize; i++)
            {
                char[] word = Dico.dictionnary[i].ToCharArray();
                char[] wordToFind = new char[word.Length];
                int life = 0;
                bool winOrLose = false;

                //  create a blank word
                for (int j = 0; j < word.Length; j++)
                    wordToFind[j] = '-';

                while (true)
                {
                    Console.Clear();
                    hangman.DrawHangman(0, 0, life);

                    if (String.Join("", word) == String.Join("", wordToFind))
                    {
                        Console.WriteLine("Bien joué");
                        winOrLose = true;
                    }
                    else if (life == 7)
                    {
                        Console.WriteLine($"Perdu le mot était \"{String.Join("", word)}\"");
                        winOrLose = true;
                    }


                    if (winOrLose && i == dicoSize - 1)
                    {
                        Console.Write("Vous avez joué tous les mots!");
                        i = dicoSize;
                        break;
                    }
                    else if (winOrLose)
                    {
                        Console.Write("Jouer un autre mot ? Y(es) N(o) ");
                        ConsoleKeyInfo playAgain = Console.ReadKey();
                        if (playAgain.KeyChar == 'n' || playAgain.KeyChar == 'N')
                        {
                            i = dicoSize;
                            break;
                        }
                        else break;
                    }
                    Console.WriteLine($"Mot à trouver {String.Join("", wordToFind)}");

                    Console.Write("Tapez votre lettre ");
                    ConsoleKeyInfo userGuess = Console.ReadKey();

                    if (!String.Join("", word).Contains(userGuess.KeyChar)) life++;

                    for (int k = 0; k < word.Length; k++)
                    {
                        if (userGuess.KeyChar == word[k]) wordToFind[k] = userGuess.KeyChar;
                    }
                }
            }
            Console.WriteLine("\nMerci d'avoir joué");
        }
    }
}
