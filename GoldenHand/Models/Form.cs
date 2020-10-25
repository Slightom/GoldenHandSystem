using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldenHand.Models
{
    public class Form
    {
        public int FormId { get; set; }
        public int Lp { get; set; }
        public int SeniorId { get; set; }
        public int WorkerId { get; set; }
        public int FormStatusId { get; set; }
        public string Info { get; set; }
        public DateTime RegistrationDate { get; set; }
        public DateTime RepairDate { get; set; }

        public virtual Senior Senior { get; set; }
        public virtual Worker Worker { get; set; }
        public virtual FormStatus FormStatus { get; set; }
    }
}
