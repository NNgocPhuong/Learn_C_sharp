using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace forFun
{ 
    //class eventArg : EventArgs
    //{
    //    string hello;
    //    public eventArg(string hello =  "Hello world")
    //    {
    //        this.hello = hello;
    //    }
    //}
    internal class animal
    {
        public EventHandler<EventArgs> TestEventHandler;
        public string sound { get; set; }
        public animal()
        {
            sound = "Hello";
        }
        public void pub()
        {
            TestEventHandler?.Invoke(this, new EventArgs());
        }
    }
    class Person
    {
        public string Voice { get; set; }
        public string Name { get; set; }
        public Person(string Name = "Phuong") { 
            Voice = "Hello, My name is ";
            this.Name = Name;
        }
        public void Noi(object sender, EventArgs e)
        {
            Console.WriteLine(Voice + " " + Name);
        }
        public void sub(animal a)
        {
            a.TestEventHandler += Noi;
        }
    }

}
