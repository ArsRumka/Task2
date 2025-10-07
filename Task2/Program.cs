namespace Task2
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine(Data.ProcessData("Файл 1"));
            Console.WriteLine(Data.ProcessData("Файл 2"));
            Console.WriteLine(Data.ProcessData("Файл 3"));

            Console.WriteLine("синхронная обработка данных завершена.");

            Task<string> task1 = Data.ProcessDataAsync("Файл 1");
            Task<string> task2 = Data.ProcessDataAsync("Файл 2");
            Task<string> task3 = Data.ProcessDataAsync("Файл 3");

            string[] tasksResult = await Task.WhenAll(task1, task2, task3);
            
            foreach (string result in tasksResult)
            {
                Console.WriteLine(result);
            }

            Console.WriteLine("асинхронная обработка данных завершена");
        }
    }
}
