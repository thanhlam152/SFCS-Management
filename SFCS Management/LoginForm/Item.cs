using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFCSManagement
{
    public class Item
    {
        public int id {get; }
        public String name { get; set; }
        public String description { get; set; }
        public Int64 price { get; set; }
        public bool available { get; set; }
        public Item(int itemId)
        {
            this.id = itemId;
        }
    }
}
