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
    public partial class BillEditForm : BaseAddEditForm
    {
        public EventHandler ReloadBills;
        private Bill bill;

        public BillEditForm(int billId)
        {
            bill = GetBill(billId);
            InitializeComponent();
            PrepareBillData(bill);
        }

        private void PrepareBillData(Bill b)
        {
            txtName.Text = b.Name;
            nudAmount.Value = Convert.ToDecimal(b.Amount);
            dtDate.Value = b.Date;
        }


        #region PrivateMethods
        private Bill GetBill(int billId)
        {
            return GoldenHandContext.Instance.Bills.Where(x => x.BillId == billId).FirstOrDefault();
        }
        private bool ValidateControls()
        {
            bool ok = true;
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                errName.SetError(txtName, "Podaj nazwę faktury.");
                ok = false;
            }

            return ok;
        }
        #endregion

        #region Events
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Cancel();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateControls())
                Save();
        }
        #endregion

        #region Overridemethods
        protected override void Save()
        {
            Bill newBill = GoldenHandContext.Instance.Bills.Where(x => x.BillId == bill.BillId).FirstOrDefault();
            newBill.Name = txtName.Text;
            newBill.Amount = decimal.ToDouble(nudAmount.Value);
            newBill.Date = new DateTime(dtDate.Value.Year, dtDate.Value.Month, dtDate.Value.Day);

            GoldenHandContext.Instance.SaveChanges();
            MessageBox.Show("Zapisano zmiany.");

            ReloadBills?.Invoke(btnSave, new BillEventArgs(newBill));
            Close();
        }
        protected override void Cancel()
        {
            Close();
        }
        #endregion
    }
}
