using System;

namespace Calculator
{
    class Program
    {
        public static int add()
        {
            Console.Write("Enter first number:");
            string val1 = Console.ReadLine();
            int num1 = Int32.Parse(val1);
            Console.Write("Enter second number:");
            string val2 = Console.ReadLine();
            int num2 = Int32.Parse(val2);
            int sum = num1 + num2;
            Console.WriteLine("The sum of the number is: "+ sum);
            return sum;
        }
        public static int sub()
        {
            Console.Write("Enter first number:");
            string val1 = Console.ReadLine();
            int num1 = Int32.Parse(val1);
            Console.Write("Enter second number:");
            string val2 = Console.ReadLine();
            int num2 = Int32.Parse(val2);
            int difference = num1 - num2;
            Console.WriteLine("The difference of the number is: " + difference);
            return difference;
        }
        public static int product()
        {
            Console.Write("Enter first number:");
            string val1 = Console.ReadLine();
            int num1 = Int32.Parse(val1);
            Console.Write("Enter second number:");
            string val2 = Console.ReadLine();
            int num2 = Int32.Parse(val2);
            int mul = num1 * num2;
            Console.WriteLine("The product of the number is: "+ mul);
            return mul;
        }
        public static double divide()
        {
            Console.Write("Enter first number:");
            string val1 = Console.ReadLine();
            double num1 = double.Parse(val1);
            Console.Write("Enter second number:");
            string val2 = Console.ReadLine();
            double num2 = double.Parse(val2);
            double div = num1 / num2;
            Console.WriteLine("The divide between the number is: " + div);
            return div;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the operation between add, substract, multiply and divide you want to perform");
            string operation = Console.ReadLine();
            if (operation.Equals("add"))
            {
                add();
            }
            else if (operation.Equals("substract"))
            {
                sub();
            }
            else if (operation.Equals("multiply"))
            {
                product();
            }
            else if (operation.Equals("divide"))
            {
                divide();
            }

            Console.ReadLine();

        }
    }
}