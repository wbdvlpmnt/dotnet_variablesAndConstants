namespace variableAndConstants;
using System;

class Program
{
    static void Main(string[] args)
    {
        byte number = 2;
        int count = 10;
        float totalPrice = 20.95f; // treat as float without we recieve error
        char charecter = 'A'; // single quote for charecter
        string firstName = "Jai"; // double quote for string
        // bool isWorking = false;
        var figureOutTheType = 2;

        Console.WriteLine(number);
        Console.WriteLine(count);
        Console.WriteLine(totalPrice);
        Console.WriteLine(charecter);
        Console.WriteLine(firstName);

        Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
        Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);

    }
}
