using System;

namespace ConsoleApp5
{
    class Program5
    {
        static void Main(string[] args)
        {
            //Пользователь вводит двузначное число. Выведите в консоль прописную запись этого числа.
            //Например при вводе “25” в консоль будет выведено “двадцать пять”.
            
            int num = Convert.ToInt32(Console.ReadLine());

            int teens = num / 10;
            int units = num % 10;
            switch (teens)
            {
                case 1:
                    switch (units)
                    {
                        case 0:
                            Console.WriteLine("Десять");
                            break;
                        case 1:
                            Console.WriteLine("Одиннадцать");
                            break;
                        case 2:
                            Console.WriteLine("Двенадцать");
                            break;
                        case 3:
                            Console.WriteLine("Тринадцать");
                            break;
                        case 4:
                            Console.WriteLine("Четырнадцать");
                            break;
                        case 5:
                            Console.WriteLine("Пятнадцать");
                            break;
                        case 6:
                            Console.WriteLine("Шестнадцать");
                            break;
                        case 7:
                            Console.WriteLine("Семнадцать");
                            break;
                        case 8:
                            Console.WriteLine("Восемьнадцать");
                            break;
                        case 9:
                            Console.WriteLine("Девятнадцать");
                            break;
                        default:
                            Console.WriteLine("Default case");
                            break;
                    }
                    break;
                case 2:
                    Console.Write("Двадцать ");
                    break;
                case 3:
                    Console.Write("Тридцать ");
                    break;
                case 4:
                    Console.Write("Сорок ");
                    break;
                case 5:
                    Console.Write("Пятьдесят ");
                    break;
                case 6:
                    Console.Write("Шестьдесят ");
                    break;
                case 7:
                    Console.Write("Семьдесят ");
                    break;
                case 8:
                    Console.Write("Восемьдесят ");
                    break;
                case 9:
                    Console.Write("Девяносто ");
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }

            if (teens != 1)
            {
                switch (units)
                {
                    case 0:
                        break;
                    case 1:
                        Console.WriteLine("один");
                        break;
                    case 2:
                        Console.WriteLine("два");
                        break;
                    case 3:
                        Console.WriteLine("три");
                        break;
                    case 4:
                        Console.WriteLine("четыре");
                        break;
                    case 5:
                        Console.WriteLine("пять");
                        break;
                    case 6:
                        Console.WriteLine("шесть");
                        break;
                    case 7:
                        Console.WriteLine("семь");
                        break;
                    case 8:
                        Console.WriteLine("восемь");
                        break;
                    case 9:
                        Console.WriteLine("девять");
                        break;
                    default:
                        Console.WriteLine("Default case");
                        break;
                }
            }
        }
    }
}
