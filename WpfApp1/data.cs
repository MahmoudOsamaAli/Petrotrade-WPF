using System;
using System.Collections.Generic;
using System.Text;

namespace WpfApp1
{
    public class data
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string City { set; get; }
        public string Area { set; get; }
        public string Address { set; get; }
        public string SubNo { set; get; }
        public int? LastRead { set; get; }
        public List<Reading> Reading { set; get; }
      
    }

    public class Reading
    {
        public int? CurrentRead { set; get; }
        public DateTime? ReadDate { set; get; }
        public int? BillNo { set; get; }
        public double? Cost { set; get; }
        public bool? Paid { set; get; }
        public int? Arrange { set; get; }
    }
}
