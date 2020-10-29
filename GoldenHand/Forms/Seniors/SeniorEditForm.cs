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

namespace GoldenHand.Forms.Seniors
{
    public partial class SeniorEditForm : BaseAddEditForm
    {
        public EventHandler ReloadSeniors;
        private Senior senior;

        public SeniorEditForm(int seniorId)
        {
            senior = GetSenior(seniorId);
            InitializeComponent();
            PrepareSeniorData(senior);
        }


        private void PrepareSeniorData(Senior senior)
        {
            txtName.Text = senior.Name;
            txtAddress.Text = senior.Address;
            txtPhoneNumber.Text = senior.PhoneNumber;
        }


        #region PrivateMethods
        private Senior GetSenior(int seniorId)
        {
            return GoldenHandContext.Instance.Seniors.Where(x => x.SeniorId == seniorId).FirstOrDefault();
        }
        private bool ValidateControls()
        {
            bool ok = true;
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                errName.SetError(txtName, "Poda imie i nazwisko seniora.");
                ok = false;
            }
            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                errAddress.SetError(txtAddress, "Podaj adres seniora.");
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
        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        #endregion

        #region Overridemethods
        protected override void Save()
        {
            Senior newSenior = GoldenHandContext.Instance.Seniors.Where(x => x.SeniorId == senior.SeniorId).FirstOrDefault();
            newSenior.Name = txtName.Text;
            newSenior.Address = txtAddress.Text;
            newSenior.PhoneNumber = txtPhoneNumber.Text;

            GoldenHandContext.Instance.SaveChanges();
            MessageBox.Show("Zapisano zmiany.");

            ReloadSeniors?.Invoke(btnSave, new SeniorEventArgs(newSenior));
            Close();
        }
        protected override void Cancel()
        {
            Close();
        }
        #endregion
    }
}
