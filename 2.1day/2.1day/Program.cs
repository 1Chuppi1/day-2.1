using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1day
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Введите номер задания от 1 до 9: ");
                int zad = int.Parse(Console.ReadLine());
                Console.WriteLine("________________________");
                switch (zad)
                {
                    case 1:
                        Console.WriteLine("Вы выбрали задание #1");
                        Console.WriteLine("________________________");
                        Console.Write("Введите число: ");
                        int number = int.Parse(Console.ReadLine());

                        if (number >= 0)
                        {
                            number += 5;
                            Console.WriteLine("Вы ввели положительное число. Прибавим к данному числу - 5.");
                        }
                        else
                        {
                            number -= 5;
                            Console.WriteLine("Вы ввели отрицательное число. Вычтем от данного числа - 5.");
                        }
                        Console.WriteLine($"Результат: {number}");
                        Console.WriteLine("________________________");
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("Вы выбрали задание #2");
                        Console.WriteLine("________________________");
                        Console.Write("Введите 1-ое число: ");
                        int firstNum = int.Parse(Console.ReadLine());
                        Console.Write("Введите 2-ое число: ");
                        int secondNum = int.Parse(Console.ReadLine());
                        Console.Write("Введите 3-ие число: ");
                        int thirdNum = int.Parse(Console.ReadLine());


                        int maxNum = firstNum;
                        if (maxNum < secondNum)
                        {
                            maxNum = secondNum;
                        }
                        if (maxNum < thirdNum)
                        {
                            maxNum = thirdNum;
                        }
                        Console.WriteLine($"Максимальное число: {maxNum}");
                        Console.WriteLine("________________________");
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.WriteLine("Вы выбрали задание #3");
                        Console.WriteLine("________________________");
                        Console.Write("Введите 1-ое число: ");
                        int fNum = int.Parse(Console.ReadLine());
                        Console.Write("Введите 2-ое число: ");
                        int sNum = int.Parse(Console.ReadLine());
                        Console.Write("Введите 3-ие число: ");
                        int thNum = int.Parse(Console.ReadLine());

                        int sum = 0;
                        if (fNum > 0)
                        {
                            sum += fNum;
                        }
                        if (sNum > 0)
                        {
                            sum += sNum;
                        }
                        if (thNum > 0)
                        {
                            sum += thNum;
                        }
                        Console.WriteLine($"Сумма положительных чисел = {sum}");
                        Console.WriteLine("________________________");
                        Console.ReadLine();
                        break;
                    case 4:
                        Console.WriteLine("Вы выбрали задание #4");
                        Console.WriteLine("________________________");
                        Console.Write("Введите число x = ");
                        int x = int.Parse(Console.ReadLine());
                        if (x > 10)
                        {
                            x *= 2;
                        }
                        Console.WriteLine($"Результат: {x}");
                        Console.WriteLine("________________________");
                        Console.ReadLine();
                        break;
                    case 5:

                        Console.WriteLine("Вы выбрали задание #5");
                        Console.WriteLine("________________________");
                        Console.Write("Введите число от 1 до 7: ");
                        int dayOfWeek = int.Parse(Console.ReadLine());

                        switch (dayOfWeek)
                        {
                            case 1:
                                Console.WriteLine("Понедельник");
                                break;
                            case 2:
                                Console.WriteLine("Вторник");
                                break;
                            case 3:
                                Console.WriteLine("Среда");
                                break;
                            case 4:
                                Console.WriteLine("Четверг");
                                break;
                            case 5:
                                Console.WriteLine("Пятница");
                                break;
                            case 6:
                                Console.WriteLine("Суббота");
                                break;
                            case 7:
                                Console.WriteLine("Воскресенье");
                                break;
                            default:
                                Console.WriteLine("Неверный ввод. Введите число от 1 до 7.");
                                break;

                        }
                        Console.WriteLine("________________________");
                        Console.ReadLine();
                        break;
                    case 6:
                        Console.WriteLine("Вы вбрали задание #6");
                        Console.WriteLine("________________________");
                        Console.Write("Введите число: ");
                        int num = int.Parse(Console.ReadLine());
                        while (num % 17 != 0)
                        {
                            num++;
                        }
                        Console.WriteLine($"Минимальное число, большее 200 и которое делится нацело на 17 = {num}");
                        Console.WriteLine("________________________");
                        Console.ReadLine();
                        break;

                    case 7:
                        Console.WriteLine("Вы вбрали задание #7");
                        Console.WriteLine("________________________");
                        Console.Write("Введите кол-во дней: ");
                        int day = int.Parse(Console.ReadLine());
                        double distance = 10;
                        double totalDistance = 10;
                        while (distance < 20 || totalDistance < 100)
                        {
                            distance *= 1.05;
                            totalDistance += distance;
                            day++;
                        }
                        Console.WriteLine($"Человек пробежит 20км на {day} день и пробежит более 100км за {day - 1} дней.");
                        Console.WriteLine("________________________");
                        Console.ReadLine();
                        break;

                    case 8:
                        Console.WriteLine("Вы вбрали задание #8");
                        Console.WriteLine("________________________");
                        Console.WriteLine("Введите число, для расчета факториала:");
                        int inputNumber = int.Parse(Console.ReadLine());
                        int factorial = 1;
                        for (int i = 2; i <= inputNumber; i++)
                        {
                            factorial *= i;
                        }
                        Console.WriteLine($"Факториал числа {inputNumber} равен {factorial}");
                        Console.WriteLine("________________________");
                        Console.ReadLine();
                        break;

                    case 9:
                        Console.WriteLine("Вы вбрали задание #9");
                        Console.WriteLine("________________________");
                        Console.WriteLine("Введите натуральное число:");
                        int num1 = int.Parse(Console.ReadLine());
                        for (int i = 2; i <= num1; i++)
                        {
                            if (num1 % i == 0)
                            {
                                Console.WriteLine($"Наименьший делитель числа {num1} = {i}");
                                break;
                            }
                        }
                        Console.WriteLine("________________________");
                        Console.ReadLine();
                        break;
                }

                Console.WriteLine("Вы хотите запустить программу заново? (Y/N)");
                string userInput = Console.ReadLine();

                if (userInput.ToLower() == "y")
                {
                    Console.WriteLine("Программа будет запущена заново.");
                    // Используем оператор continue для перехода к первой строке кода
                    continue;
                }
                else if (userInput.ToLower() == "n")
                {
                    Console.WriteLine("Программа будет завершена.");
                    // Используем оператор break для завершения цикла и программы
                    break;
                }
                else
                {
                    Console.WriteLine("Введен некорректный ответ. Пожалуйста, повторите попытку.");
                    // Используем оператор continue для перехода к первой строке кода
                    continue;
                }
            }
           


            
        }
    }
}