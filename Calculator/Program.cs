using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    interface ICalculator
    {
        int solution(int a, int b);
    }
    class Add : ICalculator
    {
        public int solution (int a, int b)
        {
            return a + b;
        }
    }
    class Multiply : ICalculator
    {
        public int solution (int a, int b)
        {
            return a * b;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Add add = new Add();
            Multiply multiply = new Multiply();
            bool isCheck = true;

            int num1 = 0;
            while (isCheck)
            {
                Console.WriteLine("Enter first number ");
                try
                {
                    num1 = Convert.ToInt32(Console.ReadLine());
                    //int number1 = Convert.ToInt32(num1);
                    isCheck = false;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Incorrect input. Please enter number");
                }
            }isCheck = true;

            int num2 = 0;
            while (isCheck)
            {
                Console.WriteLine("Enter second number");
                try
                {
                    num2 = Convert.ToInt32(Console.ReadLine());
                    isCheck = false;
                }
                catch
                {
                    Console.WriteLine("Incorrect input. Please enter number");
                }
                //int number2 = Convert.ToInt32(num2);
            }
            Console.WriteLine("Enter your choice- '1' To add \n '2' To multiply");
            string choice = Console.ReadLine();
            int myChoice = Convert.ToInt16(choice);

            if(myChoice==1)
            {
                Console.WriteLine(add.solution(num1, num2));
            }
            else if (myChoice==2)
            {
                Console.WriteLine(multiply.solution(num1, num2));
            }
            else
            {
                Console.WriteLine("Wrong Choice");
            }
            Console.ReadLine();
        }
    }
}
