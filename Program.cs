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
            string[] dictionnary = {"un", "deux"};

            // loop over word array (1 loop = 1 word = 1 game)
            for(int i = 0, dicoSize = dictionnary.Length; i < dicoSize; i++)          
            {
                char[] word = dictionnary[i].ToCharArray();
                char[] hangman = new char[word.Length];
                
                //  create a blank word
                for(int j = 0; j < word.Length; j++) 
                    hangman[j] = '-';

                while(true)
                {
                    Console.Clear();
                    Console.WriteLine($"Mot à trouver {String.Join("", hangman)}");
                    Console.Write("Tapez votre lettre ");
                    ConsoleKeyInfo userGuess = Console.ReadKey();

                    for(int k = 0; k < word.Length; k++)
                    {
                        if(userGuess.KeyChar == word[k]) hangman[k] = userGuess.KeyChar;                        
                    }

                    if(String.Join("", word) == String.Join("", hangman)) 
                    {
                        Console.WriteLine("\nBien joué");                        

                        if(i == dicoSize-1)
                        {
                            Console.Write("Bravo, vous avez trouvé tous les mots!");
                            {
                                i = dicoSize;
                                break;
                            }                            
                        }
                        else
                        {
                            Console.Write("Jouer un autre mot ? Y(es) N(o) ");
                            ConsoleKeyInfo playAgain = Console.ReadKey();
                            if(playAgain.KeyChar == 'n' || playAgain.KeyChar == 'N') 
                            {
                                i = dicoSize;
                                break;
                            }
                            else break;
                        }
                    }                   
                }
            }            
            Console.WriteLine("\nAu revoir");
        }
    }
}
