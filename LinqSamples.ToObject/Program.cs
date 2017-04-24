using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace LinqSamples.ToObject
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                var processes =
                from p in Process.GetProcesses()
                orderby p.WorkingSet64 descending
                select new { p.ProcessName, p.TotalProcessorTime, p.WorkingSet64 };

                foreach (var item in processes)
                {
                    Console.WriteLine("{0, -25} {1, 12} {2, 20:N0}", item.ProcessName, item.TotalProcessorTime, item.WorkingSet64);
                }
            }
            catch
            {
               
            }            

            Console.ReadKey();
        }
    }
}
