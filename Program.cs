using System;

namespace DelegatesDemo
{
    class Program3
    {
        static void Main()
        {
            string[] words = { "hello", "world", "delegates" };

            Action<string> upper = s => Console.WriteLine(s.ToUpper());
            Action<string> length = s => Console.WriteLine("Length: " + s.Length);
            Action<string> decorate = s => Console.WriteLine("*" + s + "*");

            Action<string> combined = upper + length + decorate;

            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine("Word: " + words[i]);
                combined(words[i]);
                Console.WriteLine();
            }
        }
    }
}