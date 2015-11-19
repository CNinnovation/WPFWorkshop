using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyVeryLongList
{
    public class LongListGenerator
    {
        public IEnumerable<SomeData> GetSomeData()
        {
            Random r = new Random();
            return Enumerable.Range(0, 10000).Select(x => new SomeData { Number = r.Next(500), Text = $"sample {x}" }).ToList();
        }
    }
}
