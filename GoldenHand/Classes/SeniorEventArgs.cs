using GoldenHand.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldenHand.Classes
{
    public class SeniorEventArgs : EventArgs
    {
        public Senior senior { get; set; }
        public SeniorEventArgs(Senior s)
        {
            this.senior = s;
        }
    }
}
