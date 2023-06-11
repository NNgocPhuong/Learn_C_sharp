using ReviewEventHandler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review_Part_Two
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TestEventHandler testEventHandler = new TestEventHandler();

            testEventHandler.sub();
            testEventHandler.test();
            Console.ReadLine();
        }
    }
}
