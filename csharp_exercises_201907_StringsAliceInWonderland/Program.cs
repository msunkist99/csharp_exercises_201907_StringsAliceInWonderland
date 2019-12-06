using System;

namespace csharp_exercises_201907_StringsAliceInWonderland
{
    class Program
    {
        static void Main(string[] args)
        {
            string aliceInWonderland = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'";

            Console.WriteLine("Enter your search string - ");
            string searchString = Console.ReadLine();

            int index = aliceInWonderland.ToUpper().IndexOf(searchString.ToUpper());

            //int index = aliceInWonderland.ToUpper().IndexOf(Console.ReadLine().ToUpper());

            if (index > 0)
            {
                Console.WriteLine("Your search string was found at index - " + index);
            }
            else
            {
                Console.WriteLine("Your search string was NOT found!");
            }

            Console.ReadLine();
        }
    }
}
