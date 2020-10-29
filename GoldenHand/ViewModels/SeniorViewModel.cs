using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldenHand.ViewModels
{
    public class SeniorViewModel
    {
        public int SeniorId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string SeniorShortcut { get; set; }
        public int FormsAll { get; set; }
        public int FormsFinished { get; set; }
        public int FormsRegisted { get; set; }
        public int FormsRejected { get; set; }
    }
}
