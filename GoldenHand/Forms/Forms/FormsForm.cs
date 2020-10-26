using GoldenHand.ModelsDisplay;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
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
                if (_instance == null)
                {
                    _instance = new FormsForm();
                }
                _instance.Init();
                return _instance;
            }
        }

        private void Init()
        {
            var data = GoldenHandContext.Instance.Forms.ToList();
            var formsDisplay = new List<FormDisplay>();
            FormDisplay fd;

            foreach (var d in data)
            {
                fd = new FormDisplay();
                fd.FormId = d.FormId;
                fd.Lp = d.Lp;
                fd.SeniorName = d.Senior.Name;
                fd.SeniorAddress = d.Senior.Address;
                fd.SeniorPhoneNumber = d.Senior.PhoneNumber;
                fd.FormStatusName = d.FormStatus.Name;
                fd.WorkerName = d.Worker.Name;
                fd.RegistrationDate = d.RegistrationDate;
                fd.RepairDate = d.RepairDate;
                formsDisplay.Add(fd);
            }
            dgForms.DataSource = formsDisplay;
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
