using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstNumber, secondNumber;
            string sign;
            double total;
            

            Console.Write("Enter the first number: ");
            firstNumber = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the second number: ");
            secondNumber = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the operator (+, *, -, /, %): ");
            sign = Console.ReadLine();

            total = firstNumber + secondNumber;

            switch(sign)
            {
                case "+":
                total = firstNumber + secondNumber;
                break;
                case "-":
                    total = firstNumber - secondNumber;
                break;
                case "*":
                    total = firstNumber * secondNumber;
                break;
                case "/":
                    total = firstNumber / secondNumber;
                break;
                case "%":
                    total = firstNumber % secondNumber;
                break;
                default:
                    Console.WriteLine("Does not exist");
                break;
            }

            Console.WriteLine("{0} {1} {2} is equal to {3}", firstNumber, sign, secondNumber, total);


       
        }
    }
}
