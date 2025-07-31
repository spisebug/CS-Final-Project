using System;

namespace DebugFixMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            (new Program()).Run();
        }


        void Run()
        {
            int choice = 0;

            WritePrompt();
            choice = ReadChoice();
            WriteChoice(choice);

        }

        void WritePrompt()
        {
            Console.WriteLine("Nikki Malmanger's Copy");
            Console.WriteLine("Please select a course for which you want to register by typing the number inside []");
            Console.WriteLine("[1]IT 145\n[2]IT 200\n[3]IT 201\n[4]IT 270\n[5]IT 315\n[6]IT 328\n[7]IT 330");
            Console.Write("Enter your choice : ");
        }

        int ReadChoice()
        {
            string s = Console.ReadLine();
            return (int.Parse(s));
        }

        void WriteChoice(int choice)
        {
            Console.WriteLine($"Your choice is {choice}");
        }

    }
}
