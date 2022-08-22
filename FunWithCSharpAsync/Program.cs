using System;
using System.Threading;
using System.Threading.Tasks;

namespace FunWithCSharpAsync
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Fun with Async ===>");
            string message = await DoWorkAsync();
            Console.WriteLine(message);
            Console.WriteLine(DoWork());
            Console.WriteLine("Completed");
            Console.ReadLine();
        }
        static string DoWork()
        {
            Thread.Sleep(5000);
            return "Done with work!";
        }
        static async Task<string> DoWorkAsync()
        {
            return await Task.Run(() =>
            {
                Thread.Sleep(5000);
                return "Done with work async!";
            });
        }
    }
}
