using System;
class Hangman{
        private string[] hangman = {
@"  +---+
      |
      |
      |
      |
      |
=========",
@"  +---+
  |   |
      |
      |
      |
      |
=========",
@"  +---+
  |   |
  O   |
      |
      |
      |
=========",
@"  +---+
  |   |
  O   |
  |   |
      |
      |
=========",
@"  +---+
  |   |
  O   |
 /|   |
      |
      |
=========",
@"  +---+
  |   |
  O   |
 /|\  |
      |
      |
=========",
@"  +---+
  |   |
  O   |
 /|\  |
 /    |
      |
=========",
@"  +---+
  |   |
  O   |
 /|\  |
 / \  |
      |
========="
    };

    public void DrawHangman(int left, int top, int index)
    {
        Console.WriteLine(hangman[index]);
    }
}