using GoldenHand.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldenHand.Classes
{

    public class BillEventArgs : EventArgs
    {
        public Bill bill { get; set; }

        public BillEventArgs(Bill b)
        {
            this.bill = b;
        }
    }
}
