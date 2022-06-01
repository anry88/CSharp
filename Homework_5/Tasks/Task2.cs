using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_5.Tasks
{
    internal class Task2
    {
        static string message;
        public static void Start()
        {
            Console.WriteLine("Введите сообщение");

            message = Console.ReadLine();

            Console.WriteLine("Введите число n и программа выведет слова, длина которых не больше этого числа");

            Message.ContainsLessNLetters(message, int.Parse(Console.ReadLine()));

            Console.WriteLine("Введите символ и из сообщения удалятся все слова, оканчивающиеся на этот символ");

            char end = char.Parse(Console.ReadLine());

            Console.WriteLine($"Из сообщение удалены все слова, оканчивающиеся на {end}");

            Message.DeleteAllWordsEndedOn(message, end);

            Console.WriteLine($"Самое длинное слово в сообщении: {Message.MaxWord(message)}");

            Console.WriteLine("Строка, сделанная с помощью StringBuilder из слов, " +
                "которые больше средней длины слов в сообщении:");

            Console.WriteLine(Message.NewStringBuildingString(message));

            Console.WriteLine("Введите слова, для которых нужно провести частотный анализ. " +
                "В конце введите 0");

            List<string> words = new List<string>();

            string tmp = Console.ReadLine();

            while (!tmp.Equals("0"))
            {
                words.Add(tmp);

                tmp = Console.ReadLine();
            }

            Dictionary<string, int> dic = Message.FrequencyWords(words.ToArray(), message);

            foreach(string key in dic.Keys)
            {
                Console.WriteLine($"{key}: содержится {dic[key]} раз");
            }
        }
    }

    internal static class Message
    {
        private static char[] separators = { ' ', '-', '.', ',', '!', '?', '(', ')' };
        public static void ContainsLessNLetters(string message, int n)
        {
            string[] words = message.Split(separators);

            foreach (string str in words)
            {
                if (str.Length <= n && str.Length > 0)
                {
                    Console.Write(str + " ");
                }
            }
            Console.Write("\n");
        }

        public static void DeleteAllWordsEndedOn(string message, char end)
        {
            string[] words = message.Split(separators);

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > 0 && words[i][words[i].Length - 1] != end)
                {
                    Console.Write(words[i] + " ");
                }
            }

            Console.Write("\n");
        }

        public static string MaxWord(string message)
        {
            string[] words = message.Split(separators);
            string maxWord  = words[0];

            foreach (string str in words)
            {
                if (str.Length > maxWord.Length)
                {
                    maxWord = str;
                }
            }

            return maxWord;
        }

        public static string NewStringBuildingString(string message)
        {
            StringBuilder stringBuilder = new StringBuilder(message.Length);

            string[] words = message.Split(separators);

            int avg = 0;

            foreach (string str in words)
            {
                avg += str.Length;
            }

            avg /= words.Length;

            foreach (string str in words)
            {
                if (str.Length > avg)
                {
                    stringBuilder.Append(str);
                    stringBuilder.Append(' ');
                }
            }

            return stringBuilder.ToString();
        }

        public static Dictionary<string, int> FrequencyWords(string[] array, string message)
        {
            Dictionary<string, int> frequencyWords = new Dictionary<string, int>();

            foreach (string str in array)
            {
                frequencyWords.Add(str, 0);
            }

            string[] words = message.Split(separators);

            foreach (string str in words)
            {
                if (frequencyWords.ContainsKey(str))
                {
                    int count = frequencyWords[str];

                    count++;

                    frequencyWords.Remove(str);
                    frequencyWords[str] = count;
                }
            }

            return frequencyWords;
        }
    }
}
