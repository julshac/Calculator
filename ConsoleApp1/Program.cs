using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int user_choice = 0;
            int numb_first;
            int numb_second;
            {
                do
                {
                    Console.WriteLine("\nChoose number: \n1 - Multiplication \n2 - Division \n3 - Subtraction \n4 - Addition \n5-Exit");
                    user_choice = Convert.ToInt32(Console.ReadLine());
                    switch (user_choice)
                    {
                        case 1:
                            Console.Write("Enter first number: ");
                            numb_first = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter second number: ");
                            numb_second = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Result: {0}", numb_first * numb_second);
                            break;
                        case 2:
                            Console.Write("Enter first number: ");
                            numb_first = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter second number: ");
                            numb_second = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Result: {0}", numb_first / numb_second);
                            break;
                        case 3:
                            Console.Write("Enter first number: ");
                            numb_first = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter second number: ");
                            numb_second = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Result: {0}", numb_first - numb_second);
                            break;
                        case 4:
                            Console.Write("Enter first number: ");
                            numb_first = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter second number: ");
                            numb_second = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Result: {0}", numb_first + numb_second);
                            break;
                    }
                } while (user_choice != 5);

            }
        }
    }
}
