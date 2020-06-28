using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFCSManagement
{
    public class Item
    {
        public int ID {get; }
        public String Name { get; set; }
        public String Description { get; set; }
        public Int64 Price { get; set; }
        public bool Available { get; set; }
        public int VendorID { get; set; }
    }
}
