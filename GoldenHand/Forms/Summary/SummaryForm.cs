using GoldenHand.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoldenHand.Forms.Summary
{
    public partial class SummaryForm : Form
    {
        private static SummaryForm _instance = null;

        public SummaryForm()
        {
            InitializeComponent();
        }

        public static SummaryForm Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SummaryForm();
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
            CreateDataGrid();
            if (GoldenHandContext.Instance.Forms.Count() > 0)
            {
                CreateRows();
            }

            Style.StyleDataGrid(dgSummary);
        }

        private void CreateDataGrid()
        {
            foreach(var worker in GoldenHandContext.Instance.Workers)
            {
                dgSummary.Columns.Add(new DataGridViewTextBoxColumn
                {
                    HeaderText = worker.Name
                });
            }

            dgSummary.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Faktury koszt"
            });
            dgSummary.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Śr. koszt/naprawę"
            });
        }

        private void CreateRows()
        {
            //all
            string _time = "Całość";
            List<Models.Form> _formsAll, _formsFinished, _formsRegisted, _formsRejected;
            double _cashAll, _cashPerForm;

            _formsAll = GoldenHandContext.Instance.Forms.OrderByDescending(x => x.RepairDate).ToList();
            _formsFinished = _formsAll.Where(x => x.FormStatus.Name == FormStatusName.FINISHED).ToList();
            _formsRegisted = _formsAll.Where(x => x.FormStatus.Name == FormStatusName.REGISTED).ToList();
            _formsRejected = _formsAll.Where(x => x.FormStatus.Name == FormStatusName.REJECTED).ToList();

            _cashAll = GoldenHandContext.Instance.Bills.Count() > 0 ? GoldenHandContext.Instance.Bills.Sum(x => x.Amount) : 0;
            _cashPerForm = _cashAll / _formsAll.Count();

            List<string> row = new List<string>();

            row.Add(_time);
            row.Add(_formsAll.Count().ToString());
            row.Add(_formsFinished.Count().ToString());
            row.Add(_formsRegisted.Count().ToString());
            row.Add(_formsRejected.Count().ToString());

            foreach (var worker in GoldenHandContext.Instance.Workers)
            {
                int formsAmount = _formsAll.Where(x => x.Worker.WorkerId == worker.WorkerId & x.FormStatus.Name != FormStatusName.REJECTED).ToList().Count();
                row.Add(formsAmount.ToString());
            }

            row.Add(Math.Round(_cashAll, 2).ToString());
            row.Add(Math.Round(_cashPerForm, 2).ToString());

            dgSummary.Rows.Add(row.ToArray());


            while (_formsAll.Count > 0)
            {
                int month = _formsAll.FirstOrDefault().RepairDate.Month;
                _time = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(month);
                List<Models.Form> monthForms = _formsAll.Where(x => x.RepairDate.Month == month).ToList();

                _formsFinished = monthForms.Where(x => x.FormStatus.Name == FormStatusName.FINISHED).ToList();
                _formsRegisted = monthForms.Where(x => x.FormStatus.Name == FormStatusName.REGISTED).ToList();
                _formsRejected = monthForms.Where(x => x.FormStatus.Name == FormStatusName.REJECTED).ToList();

                _cashAll = GoldenHandContext.Instance.Bills.Where(x => x.Date.Month == month).Count() > 0 ? GoldenHandContext.Instance.Bills.Where(x => x.Date.Month == month).Sum(x => x.Amount) : 0;
                _cashPerForm = _cashAll / monthForms.Count();

                row = new List<string>();

                row.Add(_time);
                row.Add(monthForms.Count().ToString());
                row.Add(_formsFinished.Count().ToString());
                row.Add(_formsRegisted.Count().ToString());
                row.Add(_formsRejected.Count().ToString());

                foreach (var worker in GoldenHandContext.Instance.Workers)
                {
                    int formsAmount = monthForms.Where(x => x.Worker.WorkerId == worker.WorkerId & x.FormStatus.Name != FormStatusName.REJECTED).ToList().Count();
                    row.Add(formsAmount.ToString());
                }

                row.Add(Math.Round(_cashAll,2).ToString());
                row.Add(Math.Round(_cashPerForm,2).ToString());

                dgSummary.Rows.Add(row.ToArray());

                _formsAll.RemoveRange(0, monthForms.Count);
            }
        }
            

        private void SummaryForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }
    }
}
