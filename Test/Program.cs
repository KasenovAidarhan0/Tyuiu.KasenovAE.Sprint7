using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KasenovAE.Sprint7.Project.V6.Lib;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = $@"C:\Users\kasen\Desktop\Test\test.csv";
            //string[] str = new string[4];
            //for (int i = 0; i < 4; i++)
            //{
            //    str[i] = Console.ReadLine();
            //}
            CsvController.RemoveLine(path, 2);
            Console.ReadKey();
        }
    }
}
