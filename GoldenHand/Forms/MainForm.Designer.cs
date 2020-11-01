namespace GoldenHand.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ssMain = new System.Windows.Forms.StatusStrip();
            this.tcTabs = new System.Windows.Forms.TabControl();
            this.btnForms = new System.Windows.Forms.Button();
            this.btnSeniors = new System.Windows.Forms.Button();
            this.btnBills = new System.Windows.Forms.Button();
            this.btnSummary = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ssMain
            // 
            this.ssMain.Location = new System.Drawing.Point(0, 767);
            this.ssMain.Name = "ssMain";
            this.ssMain.Size = new System.Drawing.Size(1195, 22);
            this.ssMain.TabIndex = 1;
            this.ssMain.Text = "statusStrip1";
            // 
            // tcTabs
            // 
            this.tcTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcTabs.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tcTabs.ItemSize = new System.Drawing.Size(105, 18);
            this.tcTabs.Location = new System.Drawing.Point(0, 57);
            this.tcTabs.Name = "tcTabs";
            this.tcTabs.SelectedIndex = 0;
            this.tcTabs.Size = new System.Drawing.Size(1195, 710);
            this.tcTabs.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tcTabs.TabIndex = 0;
            this.tcTabs.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.TcTabs_DrawItem);
            this.tcTabs.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TcTabs_MouseDown);
            // 
            // btnForms
            // 
            this.btnForms.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnForms.Image = global::GoldenHand.Properties.Resources.Contracts_32;
            this.btnForms.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnForms.Location = new System.Drawing.Point(0, 0);
            this.btnForms.Name = "btnForms";
            this.btnForms.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnForms.Size = new System.Drawing.Size(120, 57);
            this.btnForms.TabIndex = 0;
            this.btnForms.Text = "Formularze";
            this.btnForms.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnForms.UseVisualStyleBackColor = true;
            this.btnForms.Click += new System.EventHandler(this.btnForms_Click);
            // 
            // btnSeniors
            // 
            this.btnSeniors.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSeniors.Image = global::GoldenHand.Properties.Resources.Emplyees_32;
            this.btnSeniors.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeniors.Location = new System.Drawing.Point(120, 0);
            this.btnSeniors.Name = "btnSeniors";
            this.btnSeniors.Size = new System.Drawing.Size(120, 57);
            this.btnSeniors.TabIndex = 2;
            this.btnSeniors.Text = "Seniorzy";
            this.btnSeniors.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSeniors.UseVisualStyleBackColor = true;
            this.btnSeniors.Click += new System.EventHandler(this.btnSeniors_Click);
            // 
            // btnBills
            // 
            this.btnBills.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnBills.Image = global::GoldenHand.Properties.Resources.Contracts_32;
            this.btnBills.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBills.Location = new System.Drawing.Point(240, 0);
            this.btnBills.Name = "btnBills";
            this.btnBills.Size = new System.Drawing.Size(120, 57);
            this.btnBills.TabIndex = 3;
            this.btnBills.Text = "Faktury";
            this.btnBills.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBills.UseVisualStyleBackColor = true;
            this.btnBills.Click += new System.EventHandler(this.btnBills_Click);
            this.btnBills.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnBills_Click);
            // 
            // btnSummary
            // 
            this.btnSummary.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSummary.Image = global::GoldenHand.Properties.Resources.Salary_32;
            this.btnSummary.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSummary.Location = new System.Drawing.Point(360, 0);
            this.btnSummary.Name = "btnSummary";
            this.btnSummary.Size = new System.Drawing.Size(138, 57);
            this.btnSummary.TabIndex = 4;
            this.btnSummary.Text = "Podsumowanie";
            this.btnSummary.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSummary.UseVisualStyleBackColor = true;
            this.btnSummary.Click += new System.EventHandler(this.btnSummary_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSummary);
            this.panel1.Controls.Add(this.btnBills);
            this.panel1.Controls.Add(this.btnSeniors);
            this.panel1.Controls.Add(this.btnForms);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1195, 57);
            this.panel1.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 789);
            this.Controls.Add(this.tcTabs);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ssMain);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "System Złota Rączka";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip ssMain;
        private System.Windows.Forms.TabControl tcTabs;
        private System.Windows.Forms.Button btnSummary;
        private System.Windows.Forms.Button btnBills;
        private System.Windows.Forms.Button btnSeniors;
        private System.Windows.Forms.Button btnForms;
        private System.Windows.Forms.Panel panel1;
    }
}