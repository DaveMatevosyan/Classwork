using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multithreading
{
    struct Time
    {
        public static Time noon;
        public Time MyProperty { get { return new Time(12, 0); } }

        public Time(int hour, int mins)
        {

        }
    }
}
