/*
    A tiny hangman console game
*/
using System;

namespace csharp_game_hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dictionnary = {"computer"};

            for(int i = 0, dicoSize = dictionnary.Length; i < dicoSize; i++)          
            {
                char[] word = dictionnary[i].ToCharArray();
                char[] hangman = new char[word.Length];

                for(int j = 0; j < word.Length; j++) hangman[j] = '-';

                while(true)
                {
                    Console.WriteLine($"Mot à trouver {String.Join("", hangman)}");
                    Console.Write("Tapez votre lettre ");
                    ConsoleKeyInfo userGuess = Console.ReadKey();
                    for(int k = 0; k < word.Length; k++)
                    {
                        if(userGuess.KeyChar == word[k]) hangman[k] = userGuess.KeyChar;
                    }
                    Console.WriteLine();
                    if(String.Join("", word) == String.Join("", hangman)) 
                    {
                        Console.WriteLine("Bien joué");
                        break;
                    }                   
                }
            }

        }
    }
}
