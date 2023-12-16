using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Tyuiu.KasenovAE.Sprint7.Project.V6.Lib
{
    public static class CsvController
    {
        /// <summary>
        /// Добавляет в файл массив данных как строку
        /// </summary>
        public static void AddNewLine(string path, string[] data)
        {
            
            string line = "";
            for (int i = 0; i < data.Length; i++)
            {
                if (i == data.Length - 1)
                {
                    line += data[i];
                }
                else
                {
                    line += data[i] + ';';
                }
            }
            File.WriteAllText(path, line);
        }

        /// <summary>
        /// Удаляет строку с заданным ID 
        /// </summary>
        public static void RemoveLine(string path, int ID)
        {
            var lines = File.ReadLines(path).Skip(1);
            string lineToDelete = "";
            string IDstr = Convert.ToString(ID);
            foreach (var row in lines)
            {                
                var values = row.Split(';');
                if (values[0] == IDstr)
                {
                    lineToDelete = row;
                }
            }
            var linesToKeep = File.ReadLines(path).Where(val => val != lineToDelete);
            File.Delete(path);
            File.WriteAllLines(path, linesToKeep);
        }

        /// <summary>
        /// Ищет по столбцу значение value и возвращает List строк
        /// </summary>
        private static List<string> Find(string path, int column, string value)
        {
            var rows = new List<string>();
            foreach (var row in File.ReadLines(path).Skip(1))
            {
                var values = row.Split(';');
                if (values[column] == value)
                {
                    rows.Add(row);
                }
            }
            return rows;
        }


    }
}
