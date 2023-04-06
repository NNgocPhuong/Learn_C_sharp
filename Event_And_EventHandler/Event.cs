using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Master_Event_Delegate
{
    internal class Event
    {
        public delegate void Event_delegate(object data);

        Event_delegate infor;
        public Event_delegate Infor
        {
           get { return infor; }
           set { infor = value; }
        }

        public void send()
        {
            infor?.Invoke(21);
        }
    }
    class student
    {
        public string name;
        public int age;
        public student(string _name = " ", int _age = 0)
        { 
        name = _name;
        age = _age;
        }
        public void sub(Event p)
        {
            p.Infor += chao_hoi;
        }
        void chao_hoi(object data)
        {
            Console.WriteLine($"xin chao, ban {name} nam nay {age} tuoi phai khong, " + $"toi nam nay {data.ToString()} tuoi");
        }
    }
}
