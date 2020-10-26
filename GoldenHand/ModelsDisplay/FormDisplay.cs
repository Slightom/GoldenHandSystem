using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldenHand.ModelsDisplay
{
    public class FormDisplay
    {
        public int FormId { get; set; }
        public int Lp { get; set; }
        public string SeniorName { get; set; }
        public string SeniorAddress { get; set; }
        public string SeniorPhoneNumber { get; set; }
        public string FormStatusName { get; set; }
        public string WorkerName { get; set; }
        public string Info { get; set; }
        public DateTime RegistrationDate { get; set; }
        public DateTime RepairDate { get; set; }
    }
}
