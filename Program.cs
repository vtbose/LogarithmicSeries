using System;

namespace LogarithmicSeries
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new Random(25);
            
            for (var i = 1; i < 100; ++i)
            {
                var value = r.Next(1, 100000);
                Console.WriteLine(i + " - " + value+ " - " +i+" - "+ Math.Log10(value));
            }
        }
    }
}
