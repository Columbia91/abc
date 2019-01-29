using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructsLesson
{
    public class Shop
    {
        public string Name { get; set; }
        public Nullable<Coordinates> Coordinates { get; set; } // == public Coordinates? Coordinates { get; set; }
    }
}
