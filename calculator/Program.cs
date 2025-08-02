using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstNumber;
            double secondNumber;

            string userOpiration = "qwerty";
            bool statusCalculator = true;

            while (statusCalculator)
            {
                Console.WriteLine("Привет, я твой калькулятор!");
                
                Console.Write("\nВведите первое число: ");
                firstNumber = Convert.ToDouble(Console.ReadLine());
                
                while (userOpiration != "-" & userOpiration != "+" & userOpiration != "/" & userOpiration != "*")
                {
                    Console.Write("\nВыберите операцию которую хотите сделать с этим числом: +, -, *, / : ");
                    userOpiration = Console.ReadLine();
                    if (userOpiration == "-" & userOpiration == "+" & userOpiration == "/" & userOpiration == "*")
                    {
                        break;
                    }
                }
                Console.Write($"\nВведите второе число с которым хотите провести операцию \"{userOpiration}\" : ");
                secondNumber = Convert.ToDouble(Console.ReadLine());
                switch (userOpiration)
                {
                    case "+":
                        Console.WriteLine($"{firstNumber} {userOpiration} {secondNumber} = {firstNumber + secondNumber}");
                        statusCalculator = false;
                        break;
                    case "-":
                        Console.WriteLine($"{firstNumber} {userOpiration} {secondNumber} = {firstNumber - secondNumber}");
                        statusCalculator = false;
                        break;
                    case "/":
                        Console.WriteLine($"{firstNumber} {userOpiration} {secondNumber} = {firstNumber / secondNumber}");
                        statusCalculator = false;
                        break;
                    case "*":
                        Console.WriteLine($"{firstNumber} {userOpiration} {secondNumber} = {firstNumber * secondNumber}");
                        statusCalculator = false;
                        break;
                }
                
            }
        }
    }
}
