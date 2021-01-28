using System;

namespace Zadanko
{
    public class Palindrom
    {
        public string Check(string var)
        {
            int size = var.Length;
            int iteracje = size / 2;


            for (int i = 0; i < size / 2; i++)
            {
                if (var.ToLower()[i] != var.ToLower()[size - i - 1])
                    return "Nope, to nie jest palindrom";
            }
            return "Tak, to jest palindrom";
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Witaj w programie koleś , wprowadź słowo:");
            string entered = Console.ReadLine();

            var pd = new Palindrom();

            Console.WriteLine(pd.Check(entered));
        }

    }
}
