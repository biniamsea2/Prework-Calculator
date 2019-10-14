using System;

namespace Prework_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool displayMenu = true;
            while (displayMenu)
            {
                displayMenu = MainMenu();
            }
        }
        private static bool MainMenu()
        {
            //created a main menu b/c I know how to do it, and because it looks better 
            Console.Clear();
            Console.WriteLine("Prework-Calculator");
            Console.WriteLine("1) To Add");
            Console.WriteLine("2) To Subtract");
            Console.WriteLine("3) To Multiply");
            Console.WriteLine("4) To Divide");
            Console.WriteLine("5) Exit");
            Console.Write("Please select an option: ");
            string result = Console.ReadLine();
            //created if statement, depending on what user enters it will direct them to that method.
            if (result == "1")
            {
                Add();
                return true;
            }
            else if (result == "2")
            {
                Subtract();
                return true;
            }
            else if (result == "3")
            {
                Multiply();
                return true;
            }
            else if(result == "4" )
            {
                Divide();
                return true;
            }
            else if(result == "5")
            {
                return false;
            }
            else
            {
                return true;
            }

        }
        private static void Add()
        {
            //this is the add method where it takes the user's first number and second number and adds them together.
            //added the console.clear for visual purpose
            Console.Clear();
            Console.Write("What is the first number you would like to add: ");
            decimal firstNum = decimal.Parse(Console.ReadLine());
            Console.Write("What is the second number you would like to add: ");
            decimal secondNum = decimal.Parse(Console.ReadLine());
            decimal total = firstNum + secondNum;
            Console.WriteLine("{0} + {1} = {2}", firstNum, secondNum, total);
            Console.ReadLine();
         
        }
        private static void Subtract()
        {
            //this is the subtract method where it takes the user's first number and second number and subtracts them.
            //added the console.clear for visual purpose
            Console.Clear();
            Console.Write("What is the first number you would like to subtract: ");
            decimal firstNum = decimal.Parse(Console.ReadLine());
            Console.Write("What is the second number you would like to subtract: ");
            decimal secondNum = decimal.Parse(Console.ReadLine());
            decimal total = firstNum - secondNum;
            Console.WriteLine("{0} - {1} = {2}", firstNum, secondNum, total);
            Console.ReadLine();
        }
        private static void Multiply()
        {
            //this is the multiply method where it takes the user's first number and second number and multiplies them.
            //added the console.clear for visual purpose
            Console.Clear();
            Console.Write("What is the first number you would like to multiply: ");
            decimal firstNum = decimal.Parse(Console.ReadLine());
            Console.Write("What is the second number you would like to multiply: ");
            decimal secondNum = decimal.Parse(Console.ReadLine());
            decimal total = firstNum * secondNum;
            Console.WriteLine("{0} * {1} = {2}", firstNum, secondNum, total);
            Console.ReadLine();
        }
        private static void Divide()
        {
            //this is the divide method where it takes the user's first number and second number and divides them.
            //added the console.clear for visual purpose
            Console.Clear();
            Console.Write("What is the first number you would like to divide: ");
            decimal firstNum = decimal.Parse(Console.ReadLine());
            Console.Write("What is the second number you would like to divide: ");
            decimal secondNum = decimal.Parse(Console.ReadLine());
            decimal total = firstNum / secondNum;
            Console.WriteLine("{0} / {1} = {2}", firstNum, secondNum, total);
            Console.ReadLine();
        }
    }
}
