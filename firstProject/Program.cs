using ChaoThinh;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstProject
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            Class2.ChaoHoi();

            TinhToan val1 = new TinhToan();
            val1.A = 1;
            val1.b = 2;

            TinhToan val2 = new TinhToan(3,4);
            Console.WriteLine(val2.Add());
            Console.WriteLine(val1.Add());
            Console.ReadKey();
        }
    }
}
