using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("C:\\PhysicalFileProvider.txt");
            string symbols = sr.ReadToEnd();
            
            Console.WriteLine("Кол-во символов: " + symbols.Length);
            Console.ReadLine();
            sr.Close();
        }
    }
}
