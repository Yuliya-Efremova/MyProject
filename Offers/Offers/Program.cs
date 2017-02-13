using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace Offers
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("C:\\PhysicalFileProvider.txt");
            string symbols = sr.ReadToEnd();
            char[] mark = { '.', '?', ';', ':', '!' };
            var offers = symbols.Split(mark).Count();

            Console.WriteLine("Предложений в тексте: " + offers);
            Console.ReadLine();
            sr.Close(); 
        }
    }
}
