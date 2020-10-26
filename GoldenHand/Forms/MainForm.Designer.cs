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
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tpGeneral = new System.Windows.Forms.TabPage();
            this.btnSeniors = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.btnForms = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ssMain = new System.Windows.Forms.StatusStrip();
            this.panel1Main = new System.Windows.Forms.Panel();
            this.tcTabs = new System.Windows.Forms.TabControl();
            this.tcMain.SuspendLayout();
            this.tpGeneral.SuspendLayout();
            this.panel1Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tpGeneral);
            this.tcMain.Controls.Add(this.tabPage2);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.tcMain.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tcMain.Location = new System.Drawing.Point(0, 0);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(1184, 70);
            this.tcMain.TabIndex = 0;
            // 
            // tpGeneral
            // 
            this.tpGeneral.BackColor = System.Drawing.Color.White;
            this.tpGeneral.Controls.Add(this.btnSeniors);
            this.tpGeneral.Controls.Add(this.splitter1);
            this.tpGeneral.Controls.Add(this.btnForms);
            this.tpGeneral.Location = new System.Drawing.Point(4, 26);
            this.tpGeneral.Name = "tpGeneral";
            this.tpGeneral.Size = new System.Drawing.Size(1176, 40);
            this.tpGeneral.TabIndex = 0;
            this.tpGeneral.Text = "Ogólne";
            // 
            // btnSeniors
            // 
            this.btnSeniors.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSeniors.Image = global::GoldenHand.Properties.Resources.Emplyees_32;
            this.btnSeniors.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeniors.Location = new System.Drawing.Point(123, 0);
            this.btnSeniors.Name = "btnSeniors";
            this.btnSeniors.Size = new System.Drawing.Size(120, 40);
            this.btnSeniors.TabIndex = 2;
            this.btnSeniors.Text = "Seniorzy";
            this.btnSeniors.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSeniors.UseVisualStyleBackColor = true;
            this.btnSeniors.Click += new System.EventHandler(this.btnSeniors_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(120, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 40);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // btnForms
            // 
            this.btnForms.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnForms.Image = global::GoldenHand.Properties.Resources.Contracts_32;
            this.btnForms.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnForms.Location = new System.Drawing.Point(0, 0);
            this.btnForms.Name = "btnForms";
            this.btnForms.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnForms.Size = new System.Drawing.Size(120, 40);
            this.btnForms.TabIndex = 0;
            this.btnForms.Text = "Formularze";
            this.btnForms.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnForms.UseVisualStyleBackColor = true;
            this.btnForms.Click += new System.EventHandler(this.btnForms_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(866, 40);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ssMain
            // 
            this.ssMain.Location = new System.Drawing.Point(0, 839);
            this.ssMain.Name = "ssMain";
            this.ssMain.Size = new System.Drawing.Size(1184, 22);
            this.ssMain.TabIndex = 1;
            this.ssMain.Text = "statusStrip1";
            // 
            // panel1Main
            // 
            this.panel1Main.Controls.Add(this.tcTabs);
            this.panel1Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1Main.Location = new System.Drawing.Point(0, 70);
            this.panel1Main.Name = "panel1Main";
            this.panel1Main.Size = new System.Drawing.Size(1184, 769);
            this.panel1Main.TabIndex = 2;
            // 
            // tcTabs
            // 
            this.tcTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcTabs.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tcTabs.ItemSize = new System.Drawing.Size(105, 18);
            this.tcTabs.Location = new System.Drawing.Point(0, 0);
            this.tcTabs.Name = "tcTabs";
            this.tcTabs.SelectedIndex = 0;
            this.tcTabs.Size = new System.Drawing.Size(1184, 769);
            this.tcTabs.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tcTabs.TabIndex = 0;
            this.tcTabs.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.TcTabs_DrawItem);
            this.tcTabs.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TcTabs_MouseDown);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 861);
            this.Controls.Add(this.panel1Main);
            this.Controls.Add(this.ssMain);
            this.Controls.Add(this.tcMain);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "System Złota Rączka";
            this.tcMain.ResumeLayout(false);
            this.tpGeneral.ResumeLayout(false);
            this.panel1Main.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tpGeneral;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.StatusStrip ssMain;
        private System.Windows.Forms.Button btnSeniors;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button btnForms;
        private System.Windows.Forms.Panel panel1Main;
        private System.Windows.Forms.TabControl tcTabs;
    }
}