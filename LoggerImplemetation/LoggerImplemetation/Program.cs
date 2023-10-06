using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerImplemetation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Addition addition = new Addition();
            addition.Add(0, 1);
            Console.ReadLine();
        }
    }
}
