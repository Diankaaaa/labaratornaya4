using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labaratornaya4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                //Отображение названия программы
                Console.Title = "Лабараторная работа №4";

                //Отображение уровня сложности и номера задания
                Console.WriteLine("\t\tВысокий уровень сложности. Задание №11\n");

                //Взаимодействие с пользователем
                Console.Write("Введите трехзначное число: ");
                int number = int.Parse(Console.ReadLine());

                //Переменные для разложения числа на разряды
                int num1 = number / 100; //Первое число
                int num2 = number / 10 % 10; //Второе число
                int num3 = number % 10; //Третье число

                //Проверка выполнения пунктов а и б

                if (num1 == num2 && num2 == num3) //Пункт а)
                {
                    Console.WriteLine($"Цифры в числе {number} одинаковые");
                }
                else if (num1 == num2 || num1 == num3 || num2 == num3)
                { //Пункт б)                {
                    Console.WriteLine($"В числе {number} есть одинаковые числа");
                }

                Console.WriteLine("Для продолжения нажмите любую клавишу. . .");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
        }
    }
}
