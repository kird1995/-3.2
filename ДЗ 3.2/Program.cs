using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ДЗ_3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string zeile;
            int chInt = 0;
            Console.WriteLine(" Необходимо каждый четный символ сделать верхнего регистра и вывести в консоль.");
            {
                while (true)
                {
                    Console.Write("Введите строку: ");
                    zeile = Console.ReadLine();
                    foreach (char ch in zeile)
                    {
                        if (ch > 'a' && ch < 'z' || ch > 'а' && ch < 'я')
                        {
                            MakeUpper(zeile, chInt);
                            Console.ReadLine();
                            break;
                        }
                    }
                }
            }
            static void MakeUpper(string zeile, int chInt)
            {
                foreach (char ch in zeile)
                {
                    chInt += 1;
                    char newChar = Char.ToUpper(ch);
                    if (chInt % 2 == 1)
                    {
                        continue;
                    }
                    Console.Write(" ");
                    Thread.Sleep(120);
                    Console.Write(newChar);
                }
            }
        }
    }
}
