
using System.Threading;

namespace Task2
{
    public static class Data
    {
        public static string ProcessData(string dataName)
        {
            Thread.Sleep(3000);
            return $"Обработка {dataName} завершена за 3 секунды";
        }

        public static async Task<string> ProcessDataAsync(string dataName)
        {
            await Task.Delay(3000);
            return $"Обработка {dataName} завершена за 3 секунды";
        }
    }
}
