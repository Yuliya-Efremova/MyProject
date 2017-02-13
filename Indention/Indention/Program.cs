using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace Indention
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("C:\\PhysicalFileProvider.txt");
            string symbols = sr.ReadToEnd();
            int indention = Regex.Matches(symbols, "['\t']").Count;
            Console.WriteLine("Кол-во абзацев: " + indention);
            Console.ReadLine();
            sr.Close();

        }
    }
}
