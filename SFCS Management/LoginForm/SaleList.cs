using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFCSManagement
{
    public class SaleList
    {
        private Int32 _totalPrice;
        private int _month;
        private string _vendor;
        private int _day;
        private int _year;
     

        public Int32 Total
        {
            get { return _totalPrice; }
            set { _totalPrice = value; }
        }

        public string Vendor
        { 
            get { return _vendor; }
            set { _vendor = value; }
        }

        public int Day
        {
            get { return _day; }
            set { _day = value; }
        }
        public int Month
        {
            get { return _month; }
            set { _month = value; }
        }

        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }

    }

}
