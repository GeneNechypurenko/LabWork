using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork
{
    public static class LabWorkTask5
    {
        public static int[] Numbers { get; set; } = new int[10000];
        public static int MaxResult { get; set; }
        public static int MinResult {get; set;}
        public static double AverageResult { get; set; }
        public static object LockObject { get; set; } = new object();

        public static void RunTask()
        {
            Random random = new Random();
            for (int i = 0; i < Numbers.Length; i++)
            {
                Numbers[i] = random.Next(1000);
            }

            Thread maxThread = new Thread(LabWorkTask5.FindMax);
            Thread minThread = new Thread(LabWorkTask5.FindMin);
            Thread averageThread = new Thread(LabWorkTask5.FindAverage);
            Thread fileOutputThread = new Thread(FileOutputTask5.OutputToFile);

            maxThread.Start();
            minThread.Start();
            averageThread.Start();
            fileOutputThread.Start();

            maxThread.Join();
            minThread.Join();
            averageThread.Join();
            fileOutputThread.Join();

            Console.WriteLine("Главный поток завершил выполнение.");
        }

        private static void FindMax()
        {
            int max = int.MinValue;
            foreach (var number in Numbers)
            {
                if (number > max)
                {
                    max = number;
                }
            }

            lock (LockObject)
            {
                MaxResult = max;
            }
        }

        private static void FindMin()
        {
            int min = int.MaxValue;
            foreach (var number in Numbers)
            {
                if (number < min)
                {
                    min = number;
                }
            }

            lock (LockObject)
            {
                MinResult = min;
            }
        }

        private static void FindAverage()
        {
            double sum = 0;
            foreach (var number in Numbers)
            {
                sum += number;
            }

            lock (LockObject)
            {
                AverageResult = sum / Numbers.Length;
            }
        }
    }
    public static class FileOutputTask5
    {
        private static object fileLock = new object();

        public static void OutputToFile()
        {
            string filePath = "output.txt";

            lock (fileLock)
            {
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine($"Максимум: {LabWorkTask5.MaxResult}");
                    writer.WriteLine($"Минимум: {LabWorkTask5.MinResult}");
                    writer.WriteLine($"Среднее: {LabWorkTask5.AverageResult}");
                    writer.WriteLine("------------");
                }
            }
        }
    }
}
