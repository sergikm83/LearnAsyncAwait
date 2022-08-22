using System;
using System.Threading;
using System.Threading.Tasks;

namespace FunWithCSharpAsync
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        static string DoWork()
        {
            Thread.Sleep(5000);
            return "Done with work!";
        }
    }
}
