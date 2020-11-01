using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoldenHand.Forms.Base
{
    public partial class BaseAddEditForm : BaseForm
    {
        public BaseAddEditForm()
        {
            InitializeComponent();
            this.BackColor = SystemColors.Control;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        protected virtual void Save() { }
        protected virtual void Cancel() { }
    }
}
