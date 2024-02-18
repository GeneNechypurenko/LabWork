using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork
{
    public static class LabWorkTask4
    {
        private static int[] numbers = new int[10000];
        private static int maxResult, minResult;
        private static double averageResult;
        private static object lockObject = new object();

        public static void RunTask()
        {
            Random random = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(1000);
            }

            Thread maxThread = new Thread(LabWorkTask4.FindMax);
            Thread minThread = new Thread(LabWorkTask4.FindMin);
            Thread averageThread = new Thread(LabWorkTask4.FindAverage);

            maxThread.Start();
            minThread.Start();
            averageThread.Start();

            maxThread.Join();
            minThread.Join();
            averageThread.Join();

            Console.WriteLine($"Максимум: {maxResult}");
            Console.WriteLine($"Минимум: {minResult}");
            Console.WriteLine($"Среднее: {averageResult}");

            Console.WriteLine("Главный поток завершил выполнение.");
        }

        private static void FindMax()
        {
            int max = int.MinValue;
            foreach (var number in numbers)
            {
                if (number > max)
                {
                    max = number;
                }
            }

            lock (lockObject)
            {
                maxResult = max;
            }
        }

        private static void FindMin()
        {
            int min = int.MaxValue;
            foreach (var number in numbers)
            {
                if (number < min)
                {
                    min = number;
                }
            }

            lock (lockObject)
            {
                minResult = min;
            }
        }

        private static void FindAverage()
        {
            double sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }

            lock (lockObject)
            {
                averageResult = sum / numbers.Length;
            }
        }
    }
}
