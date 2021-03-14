using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    public static class Task5
    {
        public static string ConvertToLetter(int num)
        {
            //Пользователь вводит двузначное число. Выведите в консоль прописную запись этого числа.
            //Например при вводе “25” в консоль будет выведено “двадцать пять”.

            if(num > 99 || num < 10)
            {
                throw new ArgumentOutOfRangeException("Out of Range");
            }

            int teens = num / 10;
            int units = num % 10;
            string teensByLetters = "";
            string numByLetters = "";

            switch (teens)
            {
                case 1:
                    switch (units)
                    {
                        case 0:
                            numByLetters = ("Десять");
                            break;
                        case 1:
                            numByLetters = ("Одиннадцать");
                            break;
                        case 2:
                            numByLetters = ("Двенадцать");
                            break;
                        case 3:
                            numByLetters = ("Тринадцать");
                            break;
                        case 4:
                            numByLetters = ("Четырнадцать");
                            break;
                        case 5:
                            numByLetters = ("Пятнадцать");
                            break;
                        case 6:
                            numByLetters = ("Шестнадцать");
                            break;
                        case 7:
                            numByLetters = ("Семнадцать");
                            break;
                        case 8:
                            numByLetters = ("Восемьнадцать");
                            break;
                        case 9:
                            numByLetters = ("Девятнадцать");
                            break;
                        default:
                            break;
                    }
                    break;
                case 2:
                    teensByLetters = ("Двадцать ");
                    break;
                case 3:
                    teensByLetters = ("Тридцать ");
                    break;
                case 4:
                    teensByLetters = ("Сорок ");
                    break;
                case 5:
                    teensByLetters = ("Пятьдесят ");
                    break;
                case 6:
                    teensByLetters = ("Шестьдесят ");
                    break;
                case 7:
                    teensByLetters = ("Семьдесят ");
                    break;
                case 8:
                    teensByLetters = ("Восемьдесят ");
                    break;
                case 9:
                    teensByLetters = "Девяносто ";
                    break;
                default:
                    break;
            }

            if (teens != 1)
            {
                switch (units)
                {
                    case 0:
                        break;
                    case 1:
                        numByLetters = teensByLetters + "один";
                        break;
                    case 2:
                        numByLetters = teensByLetters + ("два");
                        break;
                    case 3:
                        numByLetters = teensByLetters + ("три");
                        break;
                    case 4:
                        numByLetters = teensByLetters + ("четыре");
                        break;
                    case 5:
                        numByLetters = teensByLetters + ("пять");
                        break;
                    case 6:
                        numByLetters = teensByLetters + ("шесть");
                        break;
                    case 7:
                        numByLetters = teensByLetters + ("семь");
                        break;
                    case 8:
                        numByLetters = teensByLetters + ("восемь");
                        break;
                    case 9:
                        numByLetters = teensByLetters + ("девять");
                        break;
                    default:
                        numByLetters = teensByLetters + ("Default case");
                        break;
                }
            }

            return numByLetters;

        }
    }
}
