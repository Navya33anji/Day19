using System;

namespace Day19_Regex
{
    class Program
    {
        static void Main(string[] args)
        {
            //UC1-----------------------------------------------------------------------------
            string name1;
            bool result1;

            UC1 firstname = new UC1();
            Console.WriteLine("Enter First Character in Bolt Latters...");
            Console.WriteLine("Enter the First Name");

            name1 = Console.ReadLine();

            result1 = firstname.FirstNameCheck(name1);
            Console.WriteLine(result1);

            Console.WriteLine("******************");
}
}
}
