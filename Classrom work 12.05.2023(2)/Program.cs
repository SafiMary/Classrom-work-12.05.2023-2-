using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Classrom_work_12._05._2023_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "";
            if (args.Length > 0)
            {
                path = args[0]; 
            }
           
            Console.WriteLine("Введите путь к файлу или его название: ");
            path = Console.ReadLine(); //тут будет "test.txt"
            bool fileExist = File.Exists(path);
            if (fileExist)
            {
                Console.WriteLine("Файл найден.");
            }
            else
            {
                Console.WriteLine("Файл не найден. Вам необходимо зайти в папку с файлами проекта и проверить наличие файла. В случае его отсутствия, создать его");
            }
           
        }
    }
}
