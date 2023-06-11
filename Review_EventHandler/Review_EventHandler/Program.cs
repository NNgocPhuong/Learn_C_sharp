using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using forFun;

namespace Review_EventHandler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            animal dog = new animal();
            person.sub(dog);

            dog.pub();

            Console.ReadLine();
        }
    }
}
