using System;

namespace UniCode
{
    class Program
    {
        static void Main(string[] args)
        {
            String unicodedString = "This Unicode string has 2 characters outside the" +
            "ASCII range:\n" +
            "pi (\u03A0),and Sigma (\u03A3).";
            Console.WriteLine("inserisci una stringa");
            Console.WriteLine("original string:");
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine(unicodedString);
            Console.WriteLine();

        }
    }
}
