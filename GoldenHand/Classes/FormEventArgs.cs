using GoldenHand.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldenHand.Classes
{
    public class FormEventArgs : EventArgs
    {
        public Form form { get; set; }

        public FormEventArgs(Form f)
        {
            this.form = f;
        }
    }
}
