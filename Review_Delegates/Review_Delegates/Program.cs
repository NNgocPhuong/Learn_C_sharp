using For_Fun;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review_Delegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TestDelegates act1;
            //Dog dog1 = new Dog();
            //act1 = dog1.action1;
            //act1();

            // Bieu thuc lamda
            TinhToan tinhToan1 = (int x, int y) =>
            {
                return x + y;
            };
            int Kq = tinhToan1(2, 4);
            Console.WriteLine(Kq);
            Console.ReadLine();
        }
    }
}
