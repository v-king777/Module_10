using System;

namespace Interfaces
{
    class Program
    {
        static Logger Logger { get; set; }

        static void Main(string[] args)
        {
            Logger = new Logger();

            var worker1 = new Worker1(Logger);
            var worker2 = new Worker2(Logger);
            var worker3 = new Worker3(Logger);

            worker1.Work();
            Console.WriteLine();

            worker2.Work();
            Console.WriteLine();
            
            worker3.Work();
            Console.WriteLine();

            Console.WriteLine("Press any key . . .");
            Console.ReadKey(true);
        }
    }
}
