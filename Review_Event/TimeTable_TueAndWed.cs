using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review_Event
{
    public class Event_Args : EventArgs
    {
        string loi_chao;
        string day;
        public string Day
        {
            get { return day; }
            set { day = value; }
        }
        public string Loi_chao
        {
            get { return loi_chao; }
            set { loi_chao = value;}
        }
        public Event_Args(string loi_chao = " ", string day = " ")
        {
            this.loi_chao = loi_chao;
            this.day = day;
        }
        //public void Nhap_Ngay_Gio()
        //{
        //    Console.Write("Nhap ngay: ");
        //    Day = Console.ReadLine();
        //}
    }
    internal class TimeTable_TueAndWed
    {
        event EventHandler<Event_Args> NNP_INSERT;
        public event EventHandler<Event_Args> NNP_insert
        {
            add { NNP_INSERT += value; }
            remove { NNP_INSERT -= value; }
        }
        public void send()
        {
            Event_Args p = new Event_Args();
           // p.Loi_chao = "Chao Phuong, ban muon xem thoi khoa bieu ngay nao?";
            NNP_INSERT?.Invoke(this, p);
        }
       
    }
    internal class Tuesday
    {
        string time;
        public string Time
        {
            get { return time; }
            set { time = value; }
        }
        public Tuesday() {
            time = "chieu";
        }
        public void Subsriber(TimeTable_TueAndWed p)
        {
            p.NNP_insert += set_Time;
        }
        public void Tues_sub(TimeTable_TueAndWed p)
        {
            this.Subsriber(p);
        }
        public void set_Time(object sender, Event_Args e)
        {
            Console.WriteLine(e.Loi_chao);
            
            Console.Write("Hay nhap thoi gian: ");
            time = Console.ReadLine();
            get_time_table();
        }
        public void get_time_table()
        {
            switch (time)
            {
                case ("sang"):
                    Console.WriteLine("Get up at 6");
                    Console.WriteLine("7h30: den truong");
                    Console.WriteLine("8h-11h15: Hoc tren phong tu hoc cua thu vien");
                    break;
                case ("trua"):
                    Console.WriteLine("An trua tai truong luc 11h30");
                    break;
                case ("chieu"):
                    Console.WriteLine("1h - 4h30: hoc o trong phong tu hoc\n " +
                        "4h40 - 6h: hoc ben ngoai hanh lang thu vien");
                    break;

                default:
                    Console.WriteLine("8h-10h: Hoc tieng anh o phong");
                    Console.WriteLine("10h-11h20: Doc sach");
                    break;
            }
        }
    }
    internal class Wednesday
    {
        string time;
        public string Time
        {
            get { return time; }
            set { time = value; }
        }
        public Wednesday()
        {
            time = "chieu";
        }
        public void Subsriber(TimeTable_TueAndWed p)
        {
            p.NNP_insert += set_Time;
        }
        public void set_Time(object sender, Event_Args e)
        {
            Console.Write("Hay nhap thoi gian: ");
            time = Console.ReadLine();
            get_time_table();
        }
        public void get_time_table()
        {
            switch (time)
            {
                case ("sang"):
                    Console.WriteLine("Get up at 6");
                    Console.WriteLine("7h30: den truong");
                    Console.WriteLine("8h-11h15: Hoc tren phong tu hoc cua thu vien");
                    break;
                case ("trua"):
                    Console.WriteLine("An trua tai truong luc 11h30");
                    break;
                case ("chieu"):
                    Console.WriteLine("1h - 3h30: hoc o trong phong tu hoc\n ");
                    break;

                default:
                    Console.WriteLine("8h-10h: Hoc tieng anh o phong");
                    Console.WriteLine("10h-11h20: Doc sach");
                    break;
            }
        }
    }
}
