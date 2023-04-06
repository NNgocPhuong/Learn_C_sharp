using Master_EventHandler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Event_And_EventHandler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Master_Event_Delegate.Event p = new Master_Event_Delegate.Event();
            Master_Event_Delegate.student a = new Master_Event_Delegate.student("A", 20);
            Master_Event_Delegate.student b = new Master_Event_Delegate.student("B", 21);
            a.sub(p);
            b.sub(p);
            p.send();
            Console.WriteLine("_____________");
            Handler handler = new Handler();
            Cat cat = new Cat();
            Dog dog = new Dog();
            Pig pig = new Pig("Ecc Ec");
            cat.CatVoice = "Meo meo";
            dog.DogVoice = "Gau gau";
            cat.sub(handler);
            dog.sub(handler);
            pig.sub(handler);
            handler.send();
            Console.ReadKey();
        }
    }
}
