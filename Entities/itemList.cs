using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class itemList
    {
        public itemList(long value, string descipcion)
        {
            this.value = value;
            this.descipcion = descipcion;
        }

        public override string ToString()
        {
            return this.descipcion;
        }

        public long value { get; set; }
        public string descipcion { get; set; }
    }

    
}
