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
        private bool isSortAscending = false;

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


            var formsSorted = formViewModelList.OrderByDescending(x => x.RegistrationDate) .ToList();

            bsForms.DataSource = new BindingList<FormViewModel>(formsSorted);
            dgForms.DataSource = bsForms;

            Style.StyleDataGrid(dgForms);
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
        private void btnCreate_Click(object sender, EventArgs e)
        {
            FormAddForm frm = new FormAddForm();
            frm.ReloadForms += (s, ea) =>
            {
                Init();
                dgForms.ClearSelection();
                dgForms.Rows[0].Selected = true;
            };
            frm.ShowDialog();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgForms.CurrentRow.Cells["FormId"].Value);
            int selectedRowIndex = dgForms.CurrentRow.Index;
            FormEditForm frm = new FormEditForm(id);
            frm.ReloadForms += (s, ea) =>
            {
                Init();
                dgForms.ClearSelection();
                dgForms.Rows[selectedRowIndex].Selected = true;
            };
            frm.ShowDialog();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgForms.CurrentRow.Cells["FormId"].Value);
            int selectedRowIndex = dgForms.CurrentRow.Index;

            const string message = "Na pewno chcesz usunąć ten formularz?";
            const string caption = "Potwierdzenie usunięcia";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);


            if (result == DialogResult.Yes)
            {
                GoldenHandContext.Instance.Forms.Remove(GoldenHandContext.Instance.Forms.Where(x => x.FormId == id).FirstOrDefault());
                GoldenHandContext.Instance.SaveChanges();
                Init();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Init();
        }

        private void columnheaderClicked(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewColumn col = dgForms.Columns[e.ColumnIndex];

            isSortAscending = !isSortAscending;

            var pi = typeof(FormViewModel).GetProperty(col.DataPropertyName);
            List<FormViewModel> sortedList;
            sortedList = formViewModelList.OrderBy(x => pi.GetValue(x, null)).ToList();

            if (!isSortAscending)
                sortedList.Reverse();


            bsForms.DataSource = new BindingList<FormViewModel>(sortedList);
            dgForms.DataSource = bsForms;
        }

        private void dgForms_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.dgForms.Rows[e.RowIndex].Cells["Nr"].Value = (e.RowIndex + 1).ToString();
        }
        #endregion
    }
}
