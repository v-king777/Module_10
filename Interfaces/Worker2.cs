using System.Threading;

namespace Interfaces
{
    public class Worker2 : IWorker
    {
        Logger Logger { get; }

        public Worker2(Logger logger)
        {
            Logger = logger;
        }

        public void Work()
        {
            Logger.Event("Worker2 начал свою работу");
            Thread.Sleep(3000);
            Logger.Event("Worker2 закончил свою работу");
        }
    }
}
