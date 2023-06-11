using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestVS17
{ 

    class Student
    {
        public event EventHandler<EventArgs> Event1;
        public string name
        {
            get;
            private set;
        }
        public int age { private set; get; }
        public string className { private set; get; }
        public Student(string name = " ", int age = 0, string className = " ")
        {
            this.name = name;
            this.age = age;
            this.className = className;
        }
        public void intro(object sender, EventArgs e)
        {
            Console.WriteLine(name + ' ' + ' ' + age + " tuoi " + className);
        }
        public void send()
        {
            Event1 += intro;
            Event1?.Invoke(this, EventArgs.Empty);
        }
    }

    class Lecture
    {
        public string name { get; set; }
        public int age { set; get; }
        public string subject { get; set; }
        public Lecture(string _name, int _age, string _subject)
        {
            this.name = _name;
            this.age = _age;
            this.subject = _subject;
        }
        public void intro(object sender, EventArgs e)
        {
            Console.WriteLine(name + ' ' + ' ' + age +  " tuoi " + subject);
        }
        public void Sub(Student student)
        {
            student.Event1 += intro;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Nguyen Ngoc Phuong", 21, "Dien tu 03");
            Lecture lecture = new Lecture("Nguyen Van A", 50, "Giai tich 1");
            lecture.Sub(student);
            student.send();
            
            Console.ReadLine();
        }
    }
}
