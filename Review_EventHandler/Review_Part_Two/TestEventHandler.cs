using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewEventHandler
{
    class SuKienDiKem : EventArgs
    {
        public string ChaoHoi { set; get; }
        public SuKienDiKem() {
            ChaoHoi = "Hello, my name is Phuong";
        }
        public void GioiThieu()
        {
            Console.WriteLine(ChaoHoi + ", " + " I am 21 years old");
        }
    }
    internal class TestEventHandler
    {
        public event EventHandler<SuKienDiKem> TestForFun;

        private void Testing_onSpaceSpressed(object sender, SuKienDiKem e)
        {
            e.GioiThieu();
            Console.WriteLine("Space!");
        }

        public void sub()
        {
            TestForFun += Testing_onSpaceSpressed;
        }

        public void test()
        {
            
            TestForFun?.Invoke(this, new SuKienDiKem());
        }
    }
}
