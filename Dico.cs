using System;

class Dico
{
    private static string[] dictionnary = {"un", "deux", "trois", "quatre", "cinq"};
    public static string[] GetWords
    {
        get
        {
            Random rand = new Random();

            for(int i = 0, size = dictionnary.Length; i < size; i++)
            {
                int newIndex = rand.Next(0,size);
                string flag = dictionnary[i];

                dictionnary[i] = dictionnary[newIndex];
                dictionnary[newIndex] = flag;

            }
            return dictionnary;
        }
    }
}