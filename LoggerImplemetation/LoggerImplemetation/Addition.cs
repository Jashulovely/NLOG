using NLog.Fluent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerImplemetation
{
    internal class Addition
    {
        Nlog nLog = new Nlog();
        public void Add(int a, int b)
        {
            if (a == 0 || b == 0)
            {
                nLog.LogInfo("In Addition.cs");
                nLog.LogDebug("Addition.cs -> Method Add()");
                nLog.LogError("a or b parameter is 0");
            }
            else
            {
                nLog.LogInfo("In Addition.cs");
                nLog.LogDebug("Addition.cs -> Method Add()");
                int c = a + b;
                Console.WriteLine("Addition value" + c);
                nLog.LogInfo("Addition value response" + " " + c);
            }
        }
    }
}
