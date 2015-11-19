using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeViewSample
{
    public class MyRoot
    {
        public MyRoot()
        {
            Children = Enumerable.Range(0, 10).Select(x => new MyChild() { ChildText = $"sample {x}" }).ToList();

        }
        public string Text { get; set; }
        public IEnumerable<MyChild> Children { get; set; }
    }
}
