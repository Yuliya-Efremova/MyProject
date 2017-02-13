using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;
using System.Text.RegularExpressions;

namespace Information
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\PhysicalFileProvider.txt";
            DateTime fileCreatedDate = File.GetCreationTime(path);
            int bytes = File.ReadAllBytes(path).Length;
            StreamReader sr = new StreamReader(path);
            string symbols = sr.ReadToEnd();
            int indention = Regex.Matches(symbols, "['\t']").Count;
            char[] mark = { '.', '?', ';', ':', '!' };
            var offers = symbols.Split(mark).Count();
            int vowels = Regex.Matches(symbols, @"[aeiouy]", RegexOptions.IgnoreCase).Count;
            int consonants = Regex.Matches(symbols, @"[bcdfghjklmnpqrstvwxz]", RegexOptions.IgnoreCase).Count;

            Console.WriteLine("Укажите полный путь к файлу");
            string text = Console.ReadLine();
            if (text == path)
            {
                Console.WriteLine("Дата создания: " + fileCreatedDate);
                Console.WriteLine("Размер bytes: " + bytes);
                Console.WriteLine("Кол-во символов: " + symbols.Length);
                Console.WriteLine("Кол-во абзацев: " + indention);
                Console.WriteLine("Предложений в тексте: " + offers);
                Console.WriteLine("Кол-во гласных: " + vowels);
                Console.WriteLine("Кол-во согласных: " + consonants);
            }
            else
                Console.WriteLine("Файл не найден");
            Console.ReadLine();

        }
    }
}