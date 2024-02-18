using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork
{
    public static class LabWorkTask1
    {
        public static void RunTask()
        {
            Thread thread = new Thread(new ThreadStart(CountNumbers));
            thread.Start();
            thread.Join();
            Console.WriteLine("Главный поток завершил выполнение.");
        }
        private static void CountNumbers()
        {
            for (int i = 0; i <= 50; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(100);
            }
        }
    }
}
