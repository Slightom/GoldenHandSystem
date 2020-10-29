using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldenHand.Models
{
    public class Bill
    {
        public int BillId { get; set; }
        public string Name { get; set; }
        public double Amount { get; set; }
        public DateTime Date { get; set; }
    }
}
