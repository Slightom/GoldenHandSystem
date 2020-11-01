using GoldenHand.Helpers;
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
    public partial class BillsForm : System.Windows.Forms.Form
    {
        private static BillsForm _instance = null;
        private static IList<Bill> bills;
        private bool isSortAscending = false;

        public BillsForm()
        {
            InitializeComponent();
        }

        public static BillsForm Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new BillsForm();
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


        private void Init()
        {
            bills = GoldenHandContext.Instance.Bills.ToList();

            var billsSorted = bills.OrderByDescending(x => x.Date).ToList();

            bsBills.DataSource = new BindingList<Bill>(billsSorted);
            dgBills.DataSource = bsBills;

            Style.StyleDataGrid(dgBills);
        }

        private void FormsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            BillAddForm srm = new BillAddForm();
            srm.ReloadBills += (s, ea) =>
            {
                Init();
                dgBills.ClearSelection();
                dgBills.Rows[0].Selected = true;
            };
            srm.ShowDialog();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (dgBills.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgBills.CurrentRow.Cells["billId"].Value);
                int selectedRowIndex = dgBills.CurrentRow.Index;
                BillEditForm srm = new BillEditForm(id);
                srm.ReloadBills += (s, ea) =>
                {
                    Init();
                    dgBills.ClearSelection();
                    dgBills.Rows[selectedRowIndex].Selected = true;
                };
                srm.ShowDialog();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgBills.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgBills.CurrentRow.Cells["billId"].Value);
                int selectedRowIndex = dgBills.CurrentRow.Index;

                const string message = "Na pewno chcesz usunąć tę fakturę?";
                const string caption = "Potwierdzenie usunięcia";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);


                if (result == DialogResult.Yes)
                {
                    GoldenHandContext.Instance.Bills.Remove(GoldenHandContext.Instance.Bills.Where(x => x.BillId == id).FirstOrDefault());
                    GoldenHandContext.Instance.SaveChanges();
                    Init();
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Init();
        }

        private void columnheaderClicked(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewColumn col = dgBills.Columns[e.ColumnIndex];

            isSortAscending = !isSortAscending;

            var pi = typeof(Bill).GetProperty(col.DataPropertyName);
            List<Bill> sortedList;
            sortedList = bills.OrderBy(x => pi.GetValue(x, null)).ToList();

            if (!isSortAscending)
                sortedList.Reverse();

            bsBills.DataSource = new BindingList<Bill>(sortedList);
            dgBills.DataSource = bsBills;
        }

        private void dgBills_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.dgBills.Rows[e.RowIndex].Cells["Nr"].Value = (e.RowIndex + 1).ToString();
        }

        private void BillsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }
    }
}
