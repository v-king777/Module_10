using System.Threading;

namespace Interfaces
{
    public class Worker3 : IWorker
    {
        Logger Logger { get; }

        public Worker3(Logger logger)
        {
            Logger = logger;
        }

        public void Work()
        {
            Logger.Event("Worker3 начал свою работу");
            Thread.Sleep(3000);
            Logger.Event("Worker3 закончил свою работу");
        }
    }
}
