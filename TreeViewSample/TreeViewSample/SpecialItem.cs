using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeViewSample
{
    public class SpecialItem
    {
        public SpecialItem(string text)
        {
            Text = text;
        }

        public string Text { get; set; }

        private IEnumerable<SpecialItem> _children;

        public IEnumerable<SpecialItem> Children
        {
            get
            {
                return _children ?? (_children = Enumerable.Range(0, 10).Select(x => new SpecialItem($"{Text}{x}.")).ToList());
            }
        }
    }
}
