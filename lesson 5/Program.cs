﻿using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Text;

namespace lesson_5
{
    internal class Program
    {

        static int FindNums(string inputStr)
        {
            return inputStr.Count(char.IsDigit);
        }

        static int LongestWord(string inputStr)
        {
            string longestWord = "";
            foreach (string word in inputStr.Split(' '))
            {
                if(word.Length > longestWord.Length)
                {
                    longestWord = word;
                }
            }

            int count = 0;
            foreach (string word in inputStr.Split(' '))
            {
                if (word.ToLower() == longestWord.ToLower())
                {
                    count++;
                }
            }
            return count;
        }

        static string ChangeNums(string inputStr)
        {
            StringBuilder result = new StringBuilder();

            foreach (char c in inputStr)
            {
                if (char.IsDigit(c))
                {
                    switch (c)
                    {
                        case '0':
                            result.Append("ноль ");
                            break;
                        case '1':
                            result.Append("один ");
                            break;
                        case '2':
                            result.Append("два ");
                            break;
                        case '3':
                            result.Append("три ");
                            break;
                        case '4':
                            result.Append("четыре ");
                            break;
                        case '5':
                            result.Append("пять ");
                            break;
                        case '6':
                            result.Append("шесть ");
                            break;
                        case '7':
                            result.Append("семь ");
                            break;
                        case '8':
                            result.Append("восемь ");
                            break;
                        case '9':
                            result.Append("девять ");
                            break;
                        default:
                            result.Append(c);
                            break;
                    }
                }
                else
                {
                    result.Append(c);
                }
            }

            return result.ToString();
        }

        static void Intonation(string inputStr)
        {
            int lastSignIndex = 0;
            int counter = 0;
            StringBuilder newStrQu = new StringBuilder("");
            StringBuilder newStrEx = new StringBuilder("");

            foreach (var c in inputStr)
            {
                switch (c)
                {
                    case '?':
                        newStrQu.Append(inputStr.Substring(lastSignIndex, counter));
                        lastSignIndex = counter;
                        counter++;
                        break;
                    case '!':
                        newStrEx.Append(inputStr.Substring(lastSignIndex, counter));
                        lastSignIndex = counter;
                        counter++;
                        break;
                    case '\n':
                    case '\r':
                        newStrEx.Append(inputStr.Substring(lastSignIndex, counter));
                        break;
                    default: counter++; break;
                }



                //if (c == '?')
                //{
                //    newStrQu.Append(inputStr.Substring(lastSignIndex, counter));
                //    lastSignIndex = counter;                    
                //}
                //else if (c == '!')
                //{
                //    newStrEx.Append(inputStr.Substring(lastSignIndex, counter));
                //    lastSignIndex = counter;
                //}
            }

            //for (int i = 0; i < inputStr.Length; i++)
            //{
            //    if (inputStr[i] == '\r' || inputStr[i] == '\n') { i--; continue; }
            //    if (inputStr[i] == '?')
            //    {
            //        newStrQu.Append(inputStr.Substring(lastSignIndex, i - 1));
            //        lastSignIndex = i;
            //    }
            //    else if (inputStr[i] == '!')
            //    {
            //        newStrEx.Append(inputStr.Substring(lastSignIndex, i - 1));
            //        lastSignIndex = i;
            //    }
            //}

            Console.WriteLine(newStrQu.ToString());
            Console.WriteLine(newStrEx.ToString());
        } //todo что?

        static void SameLetters(string inputStr)
        {
            string[] words = inputStr.Split();
            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 1; j < words.Length; j++)
                {
                    if (true)
                    {

                    }
                }
            }
        }

        // todo - Вывести на экран сначала вопросительные, а затем восклицательные предложения.
        // todo - Вывести на экран только предложения, не содержащие запятых.
        // todo - Найти слова, начинающиеся и заканчивающиеся на одну и ту же букву.


        static void Main(string[] args)
        {
            string line = "";
            string path = "";
            int choice;
            StreamReader sr;
            while (true)
            {
                try
                {
                    Console.WriteLine("Введите путь");
                    path = Console.ReadLine();
                    sr = new StreamReader(path);
                    //if (sr.ReadLine() == null) Console.WriteLine("err"); break;
                    line = sr.ReadToEnd();
                    Console.WriteLine("Ваш текст: \n" + line);
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }
            }

            bool successInConvert = false;
            while (true)
            {
                Console.WriteLine("Введите операцию (число от 1 до 3");
                Console.WriteLine("1) Найти слова, содержащие максимальное количество цифр.");
                Console.WriteLine("2) Найти самое длинное слово и определить, сколько раз оно встретилось в тексте.");
                Console.WriteLine("3) Заменить цифры от 0 до 9 на слова «ноль», «один», …, «девять».");
                successInConvert = int.TryParse(Console.ReadLine(), out choice);
                if (!successInConvert || (choice > 0 && choice < 4)) continue;
                break;
            }
            switch (choice)
            {
                case 1: FindNums(line); break;
                case 2: LongestWord(line); break;
                case 3: ChangeNums(line); break;
                default:
                    Console.WriteLine("wslkfghboqweiufgbvn");
                    break;
            }
        }
    }
}
//? ?????? Поместить в список все строки, затем разделить на условные предложения по индексу(?) 
