using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoldenHand.Forms.Forms
{
    public partial class FormsForm : Form
    {
        private static FormsForm _instance = null;

        public static FormsForm Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new FormsForm();
                }
                return _instance;
            }
        }

        public static bool IsNull
        {
            get
            {
                if (_instance == null)
                {
                    return true;
                }
                return false;
            }
        }
        private FormsForm()
        {
            InitializeComponent();
        }

        private void FormsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }
    }
}
