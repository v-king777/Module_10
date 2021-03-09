using System.Threading;

namespace Interfaces
{
    public class Worker1 : IWorker
    {
        Logger Logger { get; }

        public Worker1(Logger logger)
        {
            Logger = logger;
        }

        public void Work()
        {
            Logger.Event("Worker1 начал свою работу");
            Thread.Sleep(3000);
            Logger.Event("Worker1 закончил свою работу");
        }
    }
}
