using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        
        static double Multiplication(double leftNumber, double rightNumber)
        {
            return leftNumber * rightNumber;
        }
        
        static double Division(double leftNumber, double rightNumber)
        {
            return leftNumber / rightNumber;
        }
        
        static double Subtraction(double leftNumber, double rightNumber)
        {
            return leftNumber - rightNumber;
        }
        
        static double Addition(double leftNumber, double rightNumber)
        {
            return leftNumber + rightNumber;
        }
        
        static void Enter(out double leftNumber, out double rightNumber)
        {
            Console.Write("Enter first number: ");
            leftNumber = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second number: ");
            rightNumber = Convert.ToDouble(Console.ReadLine());
        }      
        
        static void Main(string[] args)
        {
            int user_choice = 0;
            double numb_first;
            double numb_second;
            {
                do
                {
                    Console.WriteLine("\nChoose number: \n1 - Multiplication \n2 - Division \n3 - Subtraction \n4 - Addition \n5-Exit");
                    user_choice = Convert.ToInt32(Console.ReadLine());
                    switch (user_choice)
                    {
                        case 1:
                            Enter(out numb_first, out numb_second);
                            Console.Write("Result: {0}", Multiplication(numb_first, numb_second));
                            break;
                        case 2:
                            Enter(out numb_first, out numb_second);
                            Console.Write("Result: {0}", Division(numb_first, numb_second));
                            break;
                        case 3:
                            Enter(out numb_first, out numb_second);
                            Console.Write("Result: {0}", Subtraction(numb_first, numb_second));
                            break;
                        case 4:
                            Enter(out numb_first, out numb_second);
                            Console.Write("Result: {0}", Addition(numb_first, numb_second));
                            break;
                    }
                } while (user_choice != 5);

            }
        }
    }
}
