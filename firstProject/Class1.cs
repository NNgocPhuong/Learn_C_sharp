using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ChaoThinh
{
    class Class2
    {
        public static void ChaoHoi()
        {
            Console.WriteLine("Thinh");
        }
    }
    class TinhToan
    {
        private int a;
        public int A
        {
            get
            {
                return a;
            }
            set { a = value; }
        }
        public int b
        {
            get;
            set;
        }
        public TinhToan(int a = 0, int b = 0)
        {
            this.a = a;
            this.b = b;
        }
        public int Add() => a+b;
        
    }
}

