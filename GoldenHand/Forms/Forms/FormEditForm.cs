using GoldenHand.Classes;
using GoldenHand.Extensions;
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
using BaseAddEditForm = GoldenHand.Forms.Base.BaseAddEditForm;
using Form = GoldenHand.Models.Form;

namespace GoldenHand.Forms.Forms
{
    public partial class FormEditForm : BaseAddEditForm
    {
        public EventHandler ReloadForms;
        private Form form;

        public FormEditForm(int formId)
        {
            form = GetForm(formId);
            InitializeComponent();
            InitializeData();
            PrepareFormData(form);
        }

        private void PrepareFormData(Form form)
        {
            txtLp.Text = form.Lp.ToString();
            txtInfo.Text = form.Info;
            dtRegistDate.Value = form.RegistrationDate;
            dtRepairDate.Value = form.RepairDate;
            comboStatus.SelectedValue = form.FormStatus.FormStatusId;
            comboSenior.SelectedValue = form.SeniorId;
            comboWorker.SelectedValue = form.WorkerId;
        }



        #region PrivateMethods
        private Form GetForm(int formId)
        {
            return GoldenHandContext.Instance.Forms.Where(x => x.FormId == formId).FirstOrDefault();
        }
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
                if (f.Lp == lp && lp != form.FormId)
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
            Form newForm = GoldenHandContext.Instance.Forms.Where(x => x.FormId == form.FormId).FirstOrDefault();
            newForm.Lp = Int32.Parse(txtLp.Text);
            newForm.Info = txtInfo.Text;
            newForm.FormStatusId = Int32.Parse(comboStatus.SelectedValue.ToString());
            newForm.SeniorId = Int32.Parse(comboSenior.SelectedValue.ToString());
            newForm.WorkerId = Int32.Parse(comboWorker.SelectedValue.ToString());
            newForm.RegistrationDate = new DateTime(dtRegistDate.Value.Year, dtRegistDate.Value.Month, dtRegistDate.Value.Day);
            newForm.RepairDate = new DateTime(dtRepairDate.Value.Year, dtRepairDate.Value.Month, dtRepairDate.Value.Day);

            GoldenHandContext.Instance.SaveChanges();
            MessageBox.Show("Zapisano zmiany.");

            ReloadForms?.Invoke(btnSave, new FormEventArgs(newForm));
            Close();
        }
        protected override void Cancel()
        {
            Close();
        }
        #endregion

    }
}
