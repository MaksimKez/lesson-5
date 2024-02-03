using System.Reflection.Metadata;
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
                            result.Append("ноль");
                            break;
                        case '1':
                            result.Append("один");
                            break;
                        case '2':
                            result.Append("два");
                            break;
                        case '3':
                            result.Append("три");
                            break;
                        case '4':
                            result.Append("четыре");
                            break;
                        case '5':
                            result.Append("пять");
                            break;
                        case '6':
                            result.Append("шесть");
                            break;
                        case '7':
                            result.Append("семь");
                            break;
                        case '8':
                            result.Append("восемь");
                            break;
                        case '9':
                            result.Append("девять");
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

// todo - Вывести на экран сначала вопросительные, а затем восклицательные предложения.
// todo - Вывести на экран только предложения, не содержащие запятых.
// todo - Найти слова, начинающиеся и заканчивающиеся на одну и ту же букву.

        static void Main(string[] args)
        {
            string line;
            string path = "";
            StreamReader sr;
            while (true)
            {
                try
                {
                    path = Console.ReadLine();
                    sr = new StreamReader(path);
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }
            }
            Console.WriteLine("дктидылпиотыдпи");
            line = sr.ReadLine();
            Console.WriteLine(line);
        }
    }
}
