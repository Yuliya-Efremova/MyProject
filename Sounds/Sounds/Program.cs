using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace Sounds
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("C:\\PhysicalFileProvider.txt");
            string symbols = sr.ReadToEnd();
            int vowels = Regex.Matches(symbols, @"[aeiouy]", RegexOptions.IgnoreCase).Count;
            int consonants = Regex.Matches(symbols, @"[bcdfghjklmnpqrstvwxz]", RegexOptions.IgnoreCase).Count;
            Console.WriteLine("Кол-во гласных: " + vowels);
            Console.WriteLine("Кол-во согласных: " + consonants);
            Console.ReadLine();
            sr.Close();
        


        }
    }
}
