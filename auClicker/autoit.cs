using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoItX3Lib;
namespace auClicker
{
    class autoit
    {
        AutoItX3 auto1 = new AutoItX3();
        public void clicking(string Clickside)
        {
            auto1.MouseClick(Clickside );
        }
    }
}
