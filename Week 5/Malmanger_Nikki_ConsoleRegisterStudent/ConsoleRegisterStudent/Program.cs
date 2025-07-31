using System;

namespace ConsoleRegisterStudent
{
    class Program
    {
        static void Main(string[] args)
        {
            // runs void method
            new Program().Run();
        }


        void Run()
        {
            // input choice
            int choice;

            // first, second, and third choice
            int firstChoice = 0, secondChoice = 0, thirdChoice = 0;

            // keeps track of credits
            int totalCredit = 0;

            // input of whether user wants to continue adding courses
            string yesOrNo = "";

            System.Console.WriteLine("Nikki Malmanger's Copy");

            do
            {
                WritePrompt();
                choice = Convert.ToInt32(Console.ReadLine());

                switch (ValidateChoice(choice, firstChoice, secondChoice, thirdChoice, totalCredit))
                {
                    // if user enters a number that isn't between 1 and 7
                    case -1:
                        Console.WriteLine("Your entered selection {0} is not a recognized course.", choice);
                        break;

                    // if user enters a course number they're already registered for
                    case -2:
                        Console.WriteLine("You have already registered for this {0} course.", ChoiceToCourse(choice));
                        break;

                    // if user enters more than 3 course numbers that they're already registered for
                    case -3:
                        Console.WriteLine("You can not register for more than 9 credit hours.");
                        break;

                    // if user enters a course number and doesn't apply to the previous 3 cases
                    case -4:
                        Console.WriteLine("Registration confirmed for course {0}.", ChoiceToCourse(choice));
                        
                        // increments total credits by 3 each time a new one is added
                        totalCredit += 3;

                        // if first course is empty, input will equal first choice
                        if (firstChoice == 0)
                            firstChoice = choice;

                        // if second course is empty, input will equal second choice
                        else if (secondChoice == 0)
                            secondChoice = choice;

                        // if third course is empty, input will equal third choice
                        else if (thirdChoice == 0)
                            thirdChoice = choice;

                        break;
                }

                WriteCurrentRegistration(firstChoice, secondChoice, thirdChoice);

                // asks whether the user wants to continue adding courses or not
                Console.Write("\nDo you want to try again? (Y|N)? : ");
                yesOrNo = (Console.ReadLine()).ToUpper();
            } while (yesOrNo == "Y");

            // if user doesn't type "Y," program exits
            Console.WriteLine("Thank you for registering with us");
        }

        void WritePrompt()
        {
            // initial writing prompt when program first starts
            Console.WriteLine("Please select a course for which you want to register by typing the number inside []");
            Console.WriteLine("[1]IT 145\n[2]IT 200\n[3]IT 201\n[4]IT 270\n[5]IT 315\n[6]IT 328\n[7]IT 330");
            Console.Write("Enter your choice : ");
        }

        int ValidateChoice(int choice, int firstChoice, int secondChoice, int thirdChoice, int totalCredit)
        {
            // returns the related case number back in the Run method
            if (choice < 1 || choice > 7)
                return -1;

            else if (choice == firstChoice || choice == secondChoice || choice == thirdChoice)
                return -2;

            else if (totalCredit >= 9)
                return -3;

            return -4;
        }


        // method that prints all the user's courses
        void WriteCurrentRegistration(int firstChoice, int secondChoice, int thirdChoice)
        {
            if (secondChoice == 0)
                Console.WriteLine("You are currently registered for {0}", ChoiceToCourse(firstChoice));

            else if (thirdChoice == 0)
                Console.WriteLine("You are currently registered for {0}, {1}", ChoiceToCourse(firstChoice), ChoiceToCourse(secondChoice));

            else
                Console.WriteLine("You are currently registered for {0}, {1}, {2}", ChoiceToCourse(firstChoice), ChoiceToCourse(secondChoice), ChoiceToCourse(thirdChoice));
        }

        // method with all the available courses
        string ChoiceToCourse(int choice)
        {
            string course = "";
            switch (choice)
            {
                case 1:
                    course = "IT 145";
                    break;
                case 2:
                    course = "IT 200";
                    break;
                case 3:
                    course = "IT 201";
                    break;
                case 4:
                    course = "IT 270";
                    break;
                case 5:
                    course = "IT 315";
                    break;
                case 6:
                    course = "IT 328";
                    break;
                case 7:
                    course = "IT 330";
                    break;
                default:
                    break;
            }
            return course;
        }
    }
}
