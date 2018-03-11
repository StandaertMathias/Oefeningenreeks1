using System;

namespace Oefeningenreeks1
{
    class Program
    {
        static void Main(string[] args)
        {
            Faculteit faculteit = new Faculteit(5);
            Console.WriteLine($"faculteit van 5 is {faculteit.Bereken()}");
        }
    }
}
