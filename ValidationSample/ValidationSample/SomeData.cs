using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationSample
{
    public class SomeData : IDataErrorInfo
    {
        private int val1;

        string IDataErrorInfo.this[string columnName]
        {
            get
            {
                string result = null;
                switch (columnName)
                {
                    case "Val2":
                        if (Val2 > 50)
                            result = "error in Val2";
                        break;
                    default:
                        break;
                }

                return result;
            }
        }

        public int Val1
        {
            get { return val1; }
            set
            {
                if (value > 50) throw new Exception("bad bad bad value");
                val1 = value;
            }
        }

        public int Val2 { get; set; }

        string IDataErrorInfo.Error
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}
