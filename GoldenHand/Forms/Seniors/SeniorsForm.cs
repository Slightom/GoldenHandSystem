using GoldenHand.Helpers;
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

namespace GoldenHand.Forms.Seniors
{
    public partial class SeniorsForm : Form
    {
        private static SeniorsForm _instance = null;
        private static IList<SeniorViewModel> seniorViewModelList;
        private bool isSortAscending = false;

        public static SeniorsForm Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new SeniorsForm();
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


        #region PrivateMethods
        private void Init()
        {
            seniorViewModelList = MappingHelper.MapSeniorModelToSeniorViewModel(GoldenHandContext.Instance.Seniors.ToList());

            var seniorsSorted = seniorViewModelList.OrderByDescending(x => x.Name).ToList();

            bsSeniors.DataSource = new BindingList<SeniorViewModel>(seniorsSorted);
            dgSeniors.DataSource = bsSeniors;


            Style.StyleDataGrid(dgSeniors);
        }

        private SeniorsForm()
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
            SeniorAddForm srm = new SeniorAddForm();
            srm.ReloadSeniors += (s, ea) =>
            {
                Init();
                dgSeniors.ClearSelection();
                dgSeniors.Rows[0].Selected = true;
            };
            srm.ShowDialog();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgSeniors.CurrentRow.Cells["seniorId"].Value);
            int selectedRowIndex = dgSeniors.CurrentRow.Index;
            SeniorEditForm srm = new SeniorEditForm(id);
            srm.ReloadSeniors += (s, ea) =>
            {
                Init();
                dgSeniors.ClearSelection();
                dgSeniors.Rows[selectedRowIndex].Selected = true;
            };
            srm.ShowDialog();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgSeniors.CurrentRow.Cells["SeniorId"].Value);
            int selectedRowIndex = dgSeniors.CurrentRow.Index;

            const string message = "Na pewno chcesz usunąć tego seniora?";
            const string caption = "Potwierdzenie usunięcia";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);


            if (result == DialogResult.Yes)
            {
                GoldenHandContext.Instance.Seniors.Remove(GoldenHandContext.Instance.Seniors.Where(x => x.SeniorId == id).FirstOrDefault());
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
            DataGridViewColumn col = dgSeniors.Columns[e.ColumnIndex];

            isSortAscending = !isSortAscending;

            var pi = typeof(SeniorViewModel).GetProperty(col.DataPropertyName);
            List<SeniorViewModel> sortedList;
            sortedList = seniorViewModelList.OrderBy(x => pi.GetValue(x, null)).ToList();

            if (!isSortAscending)
                sortedList.Reverse();

            bsSeniors.DataSource = new BindingList<SeniorViewModel>(sortedList);
            dgSeniors.DataSource = bsSeniors;
        }

        private void dgSeniors_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.dgSeniors.Rows[e.RowIndex].Cells["Nr"].Value = (e.RowIndex + 1).ToString();
        }
        #endregion

        private void btnDetails_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(dgSeniors.CurrentRow.Cells["seniorId"].Value);
            int selectedRowIndex = dgSeniors.CurrentRow.Index;
            SeniorDetailsForm srm = new SeniorDetailsForm(id);
            srm.ShowDialog();
        }

        private void SeniorsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }
    }
}
