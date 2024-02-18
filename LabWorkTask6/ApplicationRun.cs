using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWorkTask6
{
    public static class ApplicationRun
    {
        public static void RunTask(int start, int end, int threadCount, ListBox resultListBox)
        {
            Thread[] threads = new Thread[threadCount];
            int numbersPerThread = (end - start + 1) / threadCount;

            for (int i = 0; i < threadCount; i++)
            {
                int threadStart = start + i * numbersPerThread;
                int threadEnd = (i == threadCount - 1) ? end : threadStart + numbersPerThread - 1;

                threads[i] = new Thread(() => CountNumbers(threadStart, threadEnd, resultListBox));
                threads[i].Start();
            }

            foreach (Thread thread in threads)
            {
                thread.Join();
            }

            MessageBox.Show("Главный поток завершил выполнение.");
        }

        static void CountNumbers(int start, int end, ListBox resultListBox)
        {
            for (int i = start; i <= end; i++)
            {
                resultListBox.BeginInvoke(new Action(() =>
                {
                    resultListBox.Items.Add(i);
                }));

                Thread.Sleep(100);
            }
        }
    }
}
