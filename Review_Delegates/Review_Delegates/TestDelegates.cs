using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace For_Fun
{
    public delegate void TestDelegates();
    public delegate int TinhToan(int a , int b);
    internal class animal
    {
        public string SoundOfAnima{
            get; set;
        }
        public animal() {
            SoundOfAnima = "Hello";
        }
    }
    class Dog : animal
    {
        public string SoundOfDog { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public Dog(double a = 100, double b = 40)
        {
            base.SoundOfAnima = "Hello, Nice to meet you";
            SoundOfDog = "Gau Gau Gauuuu!";
            Height = a;
            Weight = b;
        }
        public void action1()
        {
            Console.WriteLine(SoundOfAnima + ", " + SoundOfDog);
            Console.WriteLine("Height = " + Height + ", " + "Weight = " + Weight);
        }
        public double action2()
        {
            return Weight / Height;
        }
    }
}
