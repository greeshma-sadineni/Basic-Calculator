using System;

namespace Basic_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0; int num2 = 0;
           
           Console.WriteLine("Type a number num1:");
            num1= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Type a number num2:");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Type the operator:");
           // Console.WriteLine("Choose an option from the following list:");
            //Console.WriteLine("+");
            //Console.WriteLine("-");
            //Console.WriteLine("*");
            //Console.WriteLine("/");
            //Console.Write("Your option? ");

            // Use a switch statement to do the math.
            switch (Console.ReadLine())
            {
                case "+":
                    Console.WriteLine("Addition = " + (num1 + num2));
                    break;
                case "-":
                    Console.WriteLine("Substration " + (num1 - num2));
                    break;
                case "*":
                    Console.WriteLine("Multiplication = " + (num1 * num2));
                    break;
                case "/":
                    Console.WriteLine("Divison= " + (num1 / num2));
                    break;
            }

        }
    }
}
