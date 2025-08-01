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
            string userOpiration;

            bool statusCalculator = true;

            while (statusCalculator)
            {
                Console.WriteLine("Привет, я твой калькулятор!");
                
                Console.Write("\nВведите первое число: ");
                firstNumber = Convert.ToDouble(Console.ReadLine());
                Console.Write("\nВыберите операцию которую хотите сделать с этим числом: +, -, *, / : ");
                userOpiration = Console.ReadLine();
                
                while (userOpiration != "+" || userOpiration != "-" || userOpiration != "/" || userOpiration != "*")
                {
                    Console.WriteLine("В калькуляторе нет такой операции!!!");
                    Console.Write("Выберите операцию которую хотите сделать с этим числом: +, -, *, / : ");
                    Console.Write("\nЛибо же вы можете выключить калькулятор написав \"Отмена\"");
                    userOpiration = Console.ReadLine();
                    if (userOpiration == "Отмена")
                    {
                        statusCalculator = false;
                        break;
                    }
                    else if (userOpiration != "+" || userOpiration != "-" || userOpiration != "/" || userOpiration != "*")
                    {
                        break;
                    }
                }
                Console.Write($"Введите второе число с которым вы хотите сделать операцию \"{userOpiration}\": ");
                secondNumber = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"{firstNumber} {userOpiration} {secondNumber} = {firstNumber + secondNumber}");
                statusCalculator = false;
            }
        }
    }
}
