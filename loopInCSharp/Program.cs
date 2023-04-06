using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loopInCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            string s;
            Console.WriteLine("Nhap mang");
            for (int i = 0; i < 5; i++)
            {
                Console.Write("arr[" + i + "]=");
                s = Console.ReadLine();
                arr[i] = int.Parse(s);
            }
            Array.Sort(arr);
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
