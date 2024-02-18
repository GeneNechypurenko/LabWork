using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork
{
    public static class LabWorkTask2
    {
        public static void RunTask()
        {
            Console.WriteLine("Введите начало диапазона:");
            int start = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите конец диапазона:");
            int end = int.Parse(Console.ReadLine());

            Thread thread = new Thread(() => CountNumbers(start, end));
            thread.Start();
            thread.Join();

            Console.WriteLine("Главный поток завершил выполнение.");
        }
        private static void CountNumbers(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(100);
            }
        }
    }
}
