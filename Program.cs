using System;

class Program
{
    static void Main(string[] args)
    {
        
        //Invertendo uma String
        Console.Write("Digite algo para ser invertido: ");
        string originalString = Console.ReadLine();
        string invertedString = InvertString(originalString);

        Console.WriteLine("String original: " + originalString);
        Console.WriteLine("String invertida: " + invertedString);

        Console.WriteLine(" ______     ________      ___ __ __\r\n/_____/\\   /_______/\\    /__//_//_/\\\r\n\\::::_\\/_  \\__.::._\\/    \\::\\| \\| \\ \\\r\n \\:\\/___/\\    \\::\\ \\      \\:.      \\ \\\r\n  \\:::._\\/    _\\::\\ \\__    \\:.\\-/\\  \\ \\\r\n   \\:\\ \\     /__\\::\\__/\\    \\. \\  \\  \\ \\\r\n    \\_\\/     \\________\\/     \\__\\/ \\__\\/");
        Console.Beep();
        Console.ReadKey();
    }
    static string InvertString(string str)
    {

        char[] charArray = str.ToCharArray();
        int endIndex = charArray.Length - 1;
        char temp;
        for (int i = 0; i < endIndex; i++, endIndex--)
        {
            temp = charArray[i];
            charArray[i] = charArray[endIndex];
            charArray[endIndex] = temp;
        }
        return new string(charArray);
    }
}
