using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DownloaderLocal;
using System.Threading;

namespace Tester
{
    class Program
    {
        static void Main(string[] args)
        {
            long t1 = Convert.ToInt64((DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0)).TotalMilliseconds);
            Thread.Sleep(1000);
            long t2 = Convert.ToInt64((DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0)).TotalMilliseconds);
            Console.WriteLine(t1);
            Console.WriteLine(t2);
        }
    }
}
