using GoldenHand.Classes;
using GoldenHand.Extensions;
using GoldenHand.Forms.Forms.Base;
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

namespace GoldenHand.Forms.Forms
{
    public partial class FormAddForm : BaseAddEditForm
    {
        public EventHandler ReloadForms;


        public FormAddForm()
        {
            InitializeComponent();
            InitializeData();
        }

        #region PrivateMethods
        private bool ValidateControls()
        {
            ValidateDateRepair();
            ValidateDateRegist();
            ValidateLp();

            if (!string.IsNullOrWhiteSpace(errorProviderLp.GetError(txtLp))
                || !string.IsNullOrWhiteSpace(errorProviderRegistDate.GetError(dtRegistDate))
                || !string.IsNullOrWhiteSpace(errorProviderRepairDate.GetError(dtRepairDate))
                || !string.IsNullOrWhiteSpace(errorProviderLp.GetError(txtLp)))
                return false;

            return true;
        }
        private void ValidateLp()
        {
            if (string.IsNullOrWhiteSpace(txtLp.Text))
            {
                errorProviderLp.SetError(txtLp, "Pole 'Lp' nie może być puste.");
            }
            else
            {
                errorProviderLp.Clear();
            }
        }
        private void ValidateDateRegist()
        {
            if (dtRegistDate.Format == DateTimePickerFormat.Custom)
            {
                errorProviderRegistDate.SetError(dtRegistDate, "Data zgłoszenia nie może być pusta.");
            }
            else
            {
                errorProviderRegistDate.Clear();
            }

        }
        private void ValidateDateRepair()
        {
            errorProviderRepairDate.Clear();
            if (dtRegistDate.Format != DateTimePickerFormat.Custom)
            {
                if (DateTime.Compare(dtRegistDate.Value, dtRepairDate.Value) > 0)
                {
                    errorProviderRepairDate.SetError(dtRepairDate, "Data naprawy nie może być wcześniejsza niż data zgłoszenia.");
                }
            }

            if (dtRepairDate.Format == DateTimePickerFormat.Custom)
            {
                errorProviderRepairDate.SetError(dtRepairDate, "Data naprawy nie może być pusta.");
            }
        }

        private void InitializeData()
        {
            IList<FormStatus> formStatuses = GoldenHandContext.Instance.FormStatuses.ToList();
            bsStatus.DataSource = formStatuses;

            IList<Senior> seniors = GoldenHandContext.Instance.Seniors.ToList();
            bsSeniors.DataSource = seniors;

            IList<Worker> workers = GoldenHandContext.Instance.Workers.ToList();
            bsWorkers.DataSource = workers;
        }
        #endregion

        #region Events
        private void txtLp_Validated(object sender, EventArgs e)
        {
            bool LpAlreadyUsed = false;
            int lp = Int32.Parse(txtLp.Text);
            foreach (var f in GoldenHandContext.Instance.Forms)
            {
                if (f.Lp == lp)
                {
                    LpAlreadyUsed = true;
                    break;
                }
            }

            if (LpAlreadyUsed)
                errorProviderLp.SetError(txtLp, "Inny formularz ma już takie Lp.");
            else
                errorProviderLp.Clear();
        }
        private void dt_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker dt = sender as DateTimePicker;
            dt.DateTimePickerValueChanged();
            ValidateDateRegist();
        }
        private void dtRepair_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker dt = sender as DateTimePicker;
            dt.DateTimePickerValueChanged();
            ValidateDateRepair();
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
        private void txtLp_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        #endregion

        #region Overridemethods
        protected override void Save()
        {
            Models.Form f = new Models.Form();
            f.Lp = Int32.Parse(txtLp.Text);
            f.Info = txtInfo.Text;
            f.FormStatusId = Int32.Parse(comboStatus.SelectedValue.ToString());
            f.SeniorId = Int32.Parse(comboSenior.SelectedValue.ToString());
            f.WorkerId = Int32.Parse(comboWorker.SelectedValue.ToString());
            f.RegistrationDate = dtRegistDate.Value;
            f.RepairDate = dtRepairDate.Value;

            GoldenHandContext.Instance.Forms.Add(f);
            GoldenHandContext.Instance.SaveChanges();
            MessageBox.Show("Dodano formularz.");

            ReloadForms?.Invoke(btnSave, new FormEventArgs(f));
            Close();
        }
        protected override void Cancel()
        {
            Close();
        }
        #endregion
    }
}
