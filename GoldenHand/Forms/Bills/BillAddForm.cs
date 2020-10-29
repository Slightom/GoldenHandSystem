using GoldenHand.Classes;
using GoldenHand.Forms.Base;
using GoldenHand.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoldenHand.Forms.Bills
{
    public partial class BillAddForm : BaseAddEditForm
    {
        public EventHandler ReloadBills;
        public BillAddForm()
        {
            InitializeComponent();
        }

        private bool ValidateControls()
        {
            bool ok = true;
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                errName.SetError(txtName, "Poda nazwę faktury.");
                ok = false;
            }

            return ok;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateControls())
                Save();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Cancel();
        }

        #region Overridemethods
        protected override void Save()
        {
            Bill b = new Bill();
            b.Name = txtName.Text;
            b.Amount = decimal.ToDouble(nudAmount.Value);
            b.Date = new DateTime(dtDate.Value.Year, dtDate.Value.Month, dtDate.Value.Day);


            GoldenHandContext.Instance.Bills.Add(b);
            GoldenHandContext.Instance.SaveChanges();
            MessageBox.Show("Dodano fakturę.");

            ReloadBills?.Invoke(btnSave, new BillEventArgs(b));
            Close();
        }
        protected override void Cancel()
        {
            Close();
        }
        #endregion
    }
}
