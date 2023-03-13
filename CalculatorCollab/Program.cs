using System;
using CaluculatorCollab.BLL.UI;

namespace CaluculatorCollab
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            CalculatorOperations calculator = new CalculatorOperations();
            calculator.UserChoice();
        }
    }
}