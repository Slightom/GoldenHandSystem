using GoldenHand.Forms.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoldenHand.Forms.Seniors;
using System.Windows.Forms;
using GoldenHand.Helper;

namespace GoldenHand.Forms
{
    public partial class MainForm : Form
    {
        public GoldenHandContext _context;
        private TabPage _tpForms;
        private TabPage _tpSeniors;

        public MainForm()
        {
            InitializeComponent();
            Init();
        }


        private void Init()
        {
            this._context = GoldenHandContext.Instance;
        }

        #region events
        private void btnForms_Click(object sender, EventArgs e)
        {
            if (FormsForm.IsNull)
            {
                _tpForms = new TabPage();
                ShowFormInTabPage(FormsForm.Instance, _tpForms);
            }
            else
            {
                tcTabs.SelectedTab = _tpForms;
            }
        }

        private void btnSeniors_Click(object sender, EventArgs e)
        {
            if (SeniorsForm.IsNull)
            {
                _tpSeniors = new TabPage();
                ShowFormInTabPage(SeniorsForm.Instance, _tpSeniors);
            }
            else
            {
                tcTabs.SelectedTab = _tpSeniors;
            }
        }

        private void TcTabs_DrawItem(object sender, DrawItemEventArgs e)
        {
            try
            {
                var tabPage = this.tcTabs.TabPages[e.Index];
                var tabRect = this.tcTabs.GetTabRect(e.Index);
                tabRect.Inflate(-2, -2);

                var closeImage = new Bitmap($"{ResourcesHelper.ResourcesFilePath}\\{ResourcesHelper.closeButtonName}");
                e.Graphics.DrawImage(closeImage,
                    (tabRect.Right - closeImage.Width),
                    tabRect.Top + (tabRect.Height - closeImage.Height) / 2);
                TextRenderer.DrawText(e.Graphics, tabPage.Text, tabPage.Font,
                    tabRect, tabPage.ForeColor, TextFormatFlags.Left);

            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        private void TcTabs_MouseDown(object sender, MouseEventArgs e)
        {
            for (var i = 0; i < this.tcTabs.TabPages.Count; i++)
            {
                var tabRect = this.tcTabs.GetTabRect(i);
                tabRect.Inflate(-2, -2);
                var closeImage = new Bitmap($"{ResourcesHelper.ResourcesFilePath}\\{ResourcesHelper.closeButtonName}");
                var imageRect = new Rectangle(
                    (tabRect.Right - closeImage.Width),
                    tabRect.Top + (tabRect.Height - closeImage.Height) / 2,
                    closeImage.Width,
                    closeImage.Height);
                if (imageRect.Contains(e.Location))
                {
                    var frm = tcTabs.TabPages[i].Controls[0] as Form;
                    frm.Close();
                    this.tcTabs.TabPages.RemoveAt(i);
                    break;
                }
            }
        }
        #endregion

        #region privateMethods
        private void ShowFormInTabPage(Form frm, TabPage tpP)
        {
            TabPage tpTab = new TabPage();
            tcTabs.Controls.Add(tpTab);

            tpTab.Text = frm.Text;
            frm.TopLevel = false;
            frm.Visible = true;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            tpTab.Controls.Add(frm);
            tcTabs.SelectedTab = tpTab;
        }
        #endregion

    }
}
