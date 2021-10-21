using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Diagnostics;

namespace LogicalPrograms
{
    class StopWatch
    {
        public static void stopWatch()
        {
            Stopwatch stopwatch = new Stopwatch();//Stopwatch class object created using System.Diagnostics.Stopwatch
            stopwatch.Start();//stopwatch started using start method.
            Console.WriteLine("Please Enter the Limit of Time");
            int Time = Console.Read();//User will enter till how much time will the stopwatch run.
            for(int i=0;i<=Time;i++)
            {
                Thread.Sleep(1);//It will execute till the loop finises.
            }
            stopwatch.Stop();//stopwatch will stop
            Console.WriteLine("Elapesed Time = " + stopwatch.Elapsed);//the difference will be be printed.
        }
    }
}
