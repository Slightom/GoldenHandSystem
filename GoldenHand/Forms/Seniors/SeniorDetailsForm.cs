using GoldenHand.Helpers;
using GoldenHand.Models;
using GoldenHand.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Form = System.Windows.Forms.Form;

namespace GoldenHand.Forms.Seniors
{
    public partial class SeniorDetailsForm : Form
    {
        private Senior senior;
        private IList<FormViewModel> formsViewModel;

        public SeniorDetailsForm(int seniorId)
        {
            senior = GetSenior(seniorId);
            InitializeComponent();
            PrepareSeniorData(senior);
        }

        private Senior GetSenior(int seniorId)
        {
            return GoldenHandContext.Instance.Seniors.Where(x => x.SeniorId == seniorId).FirstOrDefault();
        }
        private void PrepareSeniorData(Senior senior)
        {
            txtName.Text = senior.Name;
            txtAddress.Text = senior.Address;
            txtPhoneNumber.Text = senior.PhoneNumber;

            formsViewModel = MappingHelper.MapFormModelToFormViewModel(GoldenHandContext.Instance.Forms.Where(x => x.SeniorId == senior.SeniorId).ToList());
            var formsSorted = formsViewModel.OrderByDescending(x => x.RegistrationDate).ToList();
            bsSeniorForms.DataSource = new BindingList<FormViewModel>(formsSorted);
            dgForms.DataSource = bsSeniorForms;
        }
    }
}
