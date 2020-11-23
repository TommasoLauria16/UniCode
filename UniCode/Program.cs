using System;

namespace UniCode
{
    class Program
    {
        static void Main(string[] args)
        {
            //String unicodedString = "This Unicode string has 2 characters outside the" +
            //"ASCII range:\n" +
            //"pi (\u03A0),and Sigma (\u03A3).";
            Console.WriteLine("inserisci una stringa");
            string unicode = Console.ReadLine();
            //Console.WriteLine("original string:");
            //Console.OutputEncoding = System.Text.Encoding.Unicode; questa riga di codice è necessaria al fine
            //di far apparire a video il simbolo che è rappresentato dal codice in unicode
            
            //Console.WriteLine(unicodedString);
            //Console.WriteLine();

        }
    }
}
