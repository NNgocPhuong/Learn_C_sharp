using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lamda
{
    internal class Program
    {
        public static int Tong(int x, int y) => x + y;
        static void Main(string[] args)
        { 
            int Sum = Tong(1, 2);
            Console.WriteLine(Sum);
        }
    }
}
