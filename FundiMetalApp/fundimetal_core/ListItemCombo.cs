using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fundimetal_core
{
    public class ListItemCombo
    {
        public String Value { get; set; }
        public String Text { get; set; }
        public ListItemCombo()
        {

        }

        public override string ToString()
        {
            return Text;
        }
    }
}
