using GoldenHand.Helpers;
using GoldenHand.ViewModels;
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
        private static IList<FormViewModel> formViewModelList;

        #region Properties
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
        #endregion

        #region PrivateMethods
        private void Init()
        {
            formViewModelList = MappingHelper.MapFormModelToFormViewModel(GoldenHandContext.Instance.Forms.ToList());


            var formsSorted = formViewModelList.OrderBy(x => x.RegistrationDate).ToList();

            bsForms.DataSource = new BindingList<FormViewModel>(formsSorted);
            dgForms.DataSource = bsForms;
        }


        private FormsForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Events
        private void FormsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }
        #endregion
    }
}
