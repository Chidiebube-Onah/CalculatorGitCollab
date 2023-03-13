using System;
namespace CaluculatorCollab.BLL.UI
{
    public class CalculatorOperations
    {
        public void UserChoice()
        {
            Console.WriteLine("Welcome to CalculatorCollab");
           Operation: Console.WriteLine("Enter the operation you want to carry out\n1.Addition\n2.Subtraction\n3.Multiplication\n4.Division");
            string userInput = Console.ReadLine();
            if (int.TryParse(userInput, out int value))
            {
                switch (value)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. pick from the numbers above");
                goto Operation;
            }

            
        }
    }
}

