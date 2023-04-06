using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_EventHandler
{
    class tieng_keu : EventArgs
    {
        public string data;
        public tieng_keu(string data)
        { this.data = data; }
    }
    internal class Handler
    {
        event EventHandler<tieng_keu> testHandler;
        public event EventHandler<tieng_keu> TestHandler
        {
            add { testHandler += value; }
            remove { testHandler -= value; }
        }
        public void send()
        {
            testHandler?.Invoke(this, new tieng_keu("chao's em "));
        }
    }
    class Cat
    {
        string Cat_voice;
        public string CatVoice
        {
            get { return Cat_voice; }
            set { Cat_voice = value; }
        }
        public void sub(Handler p)
        {
            p.TestHandler += keu;
        }
        private void keu(object sender, tieng_keu e)
        {
            Console.WriteLine(e.data +"Con meo keu " + Cat_voice);
        }
    }
    class Dog
    {
        string Dog_voice;
        public string DogVoice
        {
            get { return Dog_voice; }
            set { Dog_voice = value; }
        }
        public void sub(Handler p)
        {
            p.TestHandler += keu;
        }
        private void keu(Object sender, tieng_keu e)
        {
            Console.WriteLine(e.data + "Con cho keu " + Dog_voice);
        }
    }
    class Pig
    {
        string Pig_voice;
        public string PigVoice
        {
            get { return Pig_voice; }
            set { Pig_voice = value; }
        }
        public Pig(string _pigVoice = " ")
        {
            Pig_voice = _pigVoice;
        }
        public void sub(Handler p)
        {
            p.TestHandler += keu;
        }
        private void keu(object sender, tieng_keu e)
        {
            Console.WriteLine(e.data + "Con lon keu " + Pig_voice);
        }
    }
}
