using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Пользователь вводит строку.
// Необходимо каждый четный символ сделать верхнего регистра и вывести в консоль.
namespace Homework_3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int chInt = 0;
            Console.WriteLine("Задание 2\n");
            while (true)
            {
                Console.Write("Введите строку, состоящую из букв: ");
                string str = Console.ReadLine();
                foreach (char ch in str)
                {
                    if ((ch > 'a' && ch < 'z') || (ch > 'A' && ch < 'Z') ||
                            (ch > 'а' && ch < 'я') || (ch > 'А' && ch < 'Я'))
                    {
                        MakeUpper(str, chInt);
                        Console.ReadLine();
                    }
                }
                Console.WriteLine("Введена не буква");
            }
        }
        static void MakeUpper(string str, int chInt)
        {
            foreach (char ch in str)
            {
                chInt += 1;
                char newChar = Char.ToUpper(ch);
                if (chInt % 2 == 1)
                {
                    continue;
                }
                Console.Write(newChar);
            }
        }
    }
}
