using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabWorkTask7
{
    public static class ApplicationRun
    {
        public static int[] Numbers { get; set; } = new int[10000];
        public static int MaxResult { get; set; }
        public static int MinResult { get; set; }
        public static double AverageResult { get; set; }
        public static object LockObject { get; set; } = new object();
        public static object FileLock { get; set; } = new object();

        public static async Task RunTask(TextBox outputMaxTextBox, TextBox outputMinTextBox, TextBox outputAvgTextBox, TextBox fileOutputTextBox)
        {
            Random random = new Random();
            for (int i = 0; i < Numbers.Length; i++)
            {
                Numbers[i] = random.Next(1000);
            }

            await Task.Run(() => FindMax(outputMaxTextBox));
            await Task.Run(() => FindMin(outputMinTextBox));
            await Task.Run(() => FindAverage(outputAvgTextBox));
            await Task.Run(() => OutputToFile());

            ReadFileAndUpdateTextBox(fileOutputTextBox);

            MessageBox.Show("Главный поток завершил выполнение.");
        }

        private static void ReadFileAndUpdateTextBox(TextBox fileOutputTextBox)
        {
            string filePath = "output.txt";

            lock (FileLock)
            {
                string content = File.ReadAllText(filePath);
                fileOutputTextBox.Invoke(new Action(() =>
                {
                    fileOutputTextBox.Text = content;
                }));
            }
        }

        private static void FindMax(TextBox outputMaxTextBox)
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

            outputMaxTextBox.Invoke(new Action(() =>
            {
                outputMaxTextBox.Text = MaxResult.ToString();
            }));
        }

        private static void FindMin(TextBox outputMinTextBox)
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

            outputMinTextBox.Invoke(new Action(() =>
            {
                outputMinTextBox.Text = MinResult.ToString();
            }));
        }

        private static void FindAverage(TextBox outputAvgTextBox)
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

            outputAvgTextBox.Invoke(new Action(() =>
            {
                outputAvgTextBox.Text = AverageResult.ToString();
            }));
        }
        public static void OutputToFile()
        {
            string filePath = "output.txt";

            lock (FileLock)
            {
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine($"Максимум: {ApplicationRun.MaxResult}");
                    writer.WriteLine($"Минимум: {ApplicationRun.MinResult}");
                    writer.WriteLine($"Среднее: {ApplicationRun.AverageResult}");
                    writer.WriteLine("------------");
                }
            }
        }
    }



    
}
