using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PriorityBindingSample
{
    public class MyState
    {
        public string MyCoolData
        {
            get
            {
                Thread.Sleep(6000);
                return "finally, the data is here!";
            }
        }
    }
}
