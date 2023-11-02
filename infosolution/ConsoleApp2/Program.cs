using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputString = "Suleyman Semed Tural Mirqubad";
            string reversedString = ReverseString(inputString);

            Console.WriteLine(reversedString);
        }
        // Verilen mətni ters çevirən  metod
        static string ReverseString(string input)
        {
            char[] charArray = input.ToCharArray(); 
            int start = 0;
            int end = input.Length - 1;

            
            while (start < end)
            {
                char temp = charArray[start];
                charArray[start] = charArray[end];
                charArray[end] = temp;
                start++;
                end--;
            }

            return new string(charArray); 
        }

    }
}
