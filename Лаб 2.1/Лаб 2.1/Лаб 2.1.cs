using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

internal class Program
{
    static void Main()
    {
        // Чтение предложений из файла
        string[] sentences = ReadSentencesFromFile("sentences.txt");

        if (sentences.Length >= 3)
        {
            Stack<string> stack = new Stack<string>();

            // Запись предложений в стек
            foreach (string sentence in sentences)
            {
                stack.Push(sentence);
            }

            Console.WriteLine("Предложения в обратном порядке:");

            // Вывод предложений из стека
            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }
        }
        else
        {
            Console.WriteLine("Файл не содержит три предложения!");
        }
    }

    /// <summary>
    /// Чтение предложений из текстового файла.
    /// </summary>
    /// <param name="fileName">Имя файла.</param>
    /// <returns>Массив предложений.</returns>
    static Stack<String> ReadSentencesFromFile(string fileName)

        ///Доработать, он должен читать и выводить как стек

    {
        try
        {
            string[] sentences = File.ReadAllLines(fileName);

            // Возвращаем только первые три предложения (если в файле их больше трёх)
            return sentences.Length >= 3 ? new[] { sentences[0], sentences[1], sentences[2] } : sentences;
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Файл не найден!");
        }
        catch (IOException)
        {
            Console.WriteLine("Ошибка ввода/вывода при работе с файлом!");
        }

        return new string[0];
    }
}