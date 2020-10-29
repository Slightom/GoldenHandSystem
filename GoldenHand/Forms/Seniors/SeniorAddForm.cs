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
    public partial class SeniorAddForm : BaseAddEditForm
    {
        public EventHandler ReloadSeniors;
        public SeniorAddForm()
        {
            InitializeComponent();
        }

        private bool ValidateControls()
        {
            bool ok = true;
            if(string.IsNullOrWhiteSpace(txtName.Text))
            {
                errName.SetError(txtName, "Poda imie i nazwisko seniora.");
                ok = false;
            }
            if(string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                errAddress.SetError(txtAddress, "Podaj adres seniora.");
                ok = false;
            }

            return ok;
        }





        private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
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
            Senior s = new Senior();
            s.Name = txtName.Text;
            s.Address = txtAddress.Text;
            s.PhoneNumber = txtPhoneNumber.Text;
            s.SeniorShortcut = s.Name + ", " + s.Address;

            GoldenHandContext.Instance.Seniors.Add(s);
            GoldenHandContext.Instance.SaveChanges();
            MessageBox.Show("Dodano seniora.");

            ReloadSeniors?.Invoke(btnSave, new SeniorEventArgs(s));
            Close();
        }
        protected override void Cancel()
        {
            Close();
        }
        #endregion
    }
}
