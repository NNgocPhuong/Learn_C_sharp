using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review_Event
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TimeTable_TueAndWed p = new TimeTable_TueAndWed();
            Tuesday tues = new Tuesday();
            Wednesday wednesday = new Wednesday();
            string chon_ngay;
            Console.Write("Ban muon xem thoi gian bieu hom thu 3 hay thu 4: ");
            chon_ngay = Console.ReadLine();
            if (chon_ngay == "3" || chon_ngay == "thu 3" || chon_ngay == "thu 3") { tues.Subsriber(p); }
            else if(chon_ngay == "4" || chon_ngay == "thu 4" || chon_ngay == "thu tu")
            { wednesday.Subsriber(p); }
            
            p.send();
            Console.ReadLine();

        }
    }
}
