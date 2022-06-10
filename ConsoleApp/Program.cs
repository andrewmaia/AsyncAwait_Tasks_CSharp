using Biblioteca;

namespace ConsoleApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            PreparadorCafeManha p = new PreparadorCafeManha();
            p.PrepareBreakfastSync();
            Console.WriteLine("----------------------------------------------");
            await p.PrepareBreakfastAsync();
        }



    }


}