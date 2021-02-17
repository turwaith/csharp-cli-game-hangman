using System;
class Hangman{

      private static string[][] hangman = new string[][] {        
        new string[] {"   +---+","       |","       |","       |","       |","       |","========="},
        new string[] {"   +---+","   |   |","       |","       |","       |","       |","========="},
        new string[] {"   +---+","   |   |","   O   |","       |","       |","       |","========="},
        new string[] {"   +---+","   |   |","   O   |","   |   |","       |","       |","========="},
        new string[] {"   +---+","   |   |","   O   |","  /|   |","       |","       |","========="},
        new string[] {"   +---+","   |   |","   O   |","  /|\\  |","       |","       |","========="},
        new string[] {"   +---+","   |   |","   O   |","  /|\\  |","  /    |","       |","========="},
        new string[] {"   +---+","   |   |","   O   |","  /|\\  |","  / \\  |", "       |","========="}};


    public static void Draw(int left, int top, int index)
    {
       
      for(int i = 0, row = hangman[index].Length; i < row; i++)
      {           
        Console.SetCursorPosition(left, top+i);
        Console.WriteLine(String.Join("",hangman[index][i]));
      }
    }
}