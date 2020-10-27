using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldenHand.Models
{
    public class FormStatus
    {
        public int FormStatusId { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return Name.ToUpper();
        }
    }
}
