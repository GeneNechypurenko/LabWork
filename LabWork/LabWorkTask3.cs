using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LabWork
{
    public static class LabWorkTask3
    {
        public static void RunTask()
        {
            Console.WriteLine("Введите начало диапазона:");
            int start = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите конец диапазона:");
            int end = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите количество потоков:");
            int threadCount = int.Parse(Console.ReadLine());

            Thread[] threads = new Thread[threadCount];
            int numbersPerThread = (end - start + 1) / threadCount;

            for (int i = 0; i < threadCount; i++)
            {
                int threadStart = start + i * numbersPerThread;
                int threadEnd = (i == threadCount - 1) ? end : threadStart + numbersPerThread - 1;
                threads[i] = new Thread(() => CountNumbers(threadStart, threadEnd));
                threads[i].Start();
            }

            foreach (Thread thread in threads)
            {
                thread.Join();
            }

            Console.WriteLine("Главный поток завершил выполнение.");
        }
        static void CountNumbers(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(100);
            }
        }
    }
}
