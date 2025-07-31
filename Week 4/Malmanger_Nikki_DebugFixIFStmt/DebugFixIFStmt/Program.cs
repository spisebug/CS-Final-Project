using System;

namespace DebugFixIFStmt
{
    class Program
    {
        static void Main(string[] args)
        {
            // runs programs
            (new Program()).Run();
        }


        void Run()
        {
            // my name!
            System.Console.WriteLine("Nikki Malmanger's Copy");

            // initialize choices
            int firstChoice = 0, secondChoice = 0, thirdChoice = 0;

            // first line
            firstChoice = 0; secondChoice = 0; thirdChoice = 0;
            WriteCurrentChoices(firstChoice, secondChoice, thirdChoice);

            // second line
            firstChoice = 2; secondChoice = 0; thirdChoice = 0;
            WriteCurrentChoices(firstChoice, secondChoice, thirdChoice);

            // third line
            firstChoice = 2; secondChoice = 5; thirdChoice = 0;
            WriteCurrentChoices(firstChoice, secondChoice, thirdChoice);

            // fourth line
            firstChoice = 2; secondChoice = 5; thirdChoice = 7;
            WriteCurrentChoices(firstChoice, secondChoice, thirdChoice);
        }


        void WriteCurrentChoices(int firstChoice, int secondChoice, int thirdChoice)
        {
            // if all choices equal 0, then there are no choices
            if (firstChoice == 0 && secondChoice == 0 && thirdChoice == 0)
                Console.WriteLine("Choices are: {0}, {1}, {2} => There are no choices yet", firstChoice, secondChoice, thirdChoice);

            // if the second choice is 0, then prints out the first choice
            else if (secondChoice == 0)
                Console.WriteLine("Choices are: {0}, {1}, {2} => Currently choices are {0}", firstChoice, secondChoice, thirdChoice, firstChoice);

            // if the third choice is 0, then prints out the first and second choice
            else if (thirdChoice == 0)
                Console.WriteLine("Choices are: {0}, {1}, {2} => Currently choices are {0}, {1}", firstChoice, secondChoice, thirdChoice, firstChoice, secondChoice);

            // if none of the choices are 0, then prints all of the choices
            else if (firstChoice != 0 && secondChoice != 0 && thirdChoice != 0)
                Console.WriteLine("Choices are: {0}, {1}, {2} => Currently choices are {0}, {1}, {2}", firstChoice, secondChoice, thirdChoice, firstChoice, secondChoice, thirdChoice);
        }
    }
}
