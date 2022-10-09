using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BackgroundWorkerExample
{
    class CallMethodEvery5Seconds
    {
        internal static void Run()
        {
            int seconds = 5 * 1000;

            var timer =
                new Timer(TimerMethod, null, 0, seconds);

            Console.ReadKey();
        }

        private static void TimerMethod(object o)
        {
            Console.WriteLine(
                "Running: " + DateTime.Now);
        }
    }
}
