using System.Diagnostics;

namespace Task2
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();

            Console.WriteLine("синхронная обработка данных запущена");
            sw.Start();
            Console.WriteLine(Data.ProcessData("Файл 1"));
            Console.WriteLine(Data.ProcessData("Файл 2"));
            Console.WriteLine(Data.ProcessData("Файл 3"));
            sw.Stop();
            Console.WriteLine("синхронная обработка данных завершена.\n" +
                $"заняла {sw.ElapsedMilliseconds}");


            Console.WriteLine("асинхронная обработка данных запущена");
            sw.Restart();
            Task<string> task1 = Data.ProcessDataAsync("Файл 1");
            Task<string> task2 = Data.ProcessDataAsync("Файл 2");
            Task<string> task3 = Data.ProcessDataAsync("Файл 3");

            string[] tasksResult = await Task.WhenAll(task1, task2, task3);
            sw.Stop();

            foreach (string result in tasksResult)
            {
                Console.WriteLine(result);
            }
            
            Console.WriteLine("асинхронная обработка данных завершена\n" +
                $"заняла {sw.ElapsedMilliseconds}");
        }
    }
}
