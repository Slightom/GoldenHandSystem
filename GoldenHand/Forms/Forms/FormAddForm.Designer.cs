namespace GoldenHand.Forms.Forms
{
    partial class FormAddForm
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
            this.components = new System.ComponentModel.Container();
            this.gbGeneral = new System.Windows.Forms.GroupBox();
            this.txtLp = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.dtRepairDate = new System.Windows.Forms.DateTimePicker();
            this.dtRegistDate = new System.Windows.Forms.DateTimePicker();
            this.comboStatus = new System.Windows.Forms.ComboBox();
            this.bsStatus = new System.Windows.Forms.BindingSource(this.components);
            this.comboWorker = new System.Windows.Forms.ComboBox();
            this.bsWorkers = new System.Windows.Forms.BindingSource(this.components);
            this.comboSenior = new System.Windows.Forms.ComboBox();
            this.bsSeniors = new System.Windows.Forms.BindingSource(this.components);
            this.lblWorker = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblRegistDate = new System.Windows.Forms.Label();
            this.lblRepairDate = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblSenior = new System.Windows.Forms.Label();
            this.lblLp = new System.Windows.Forms.Label();
            this.errorProviderLp = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderRegistDate = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderRepairDate = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsWorkers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSeniors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderRegistDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderRepairDate)).BeginInit();
            this.SuspendLayout();
            // 
            // gbGeneral
            // 
            this.gbGeneral.Controls.Add(this.txtLp);
            this.gbGeneral.Controls.Add(this.btnCancel);
            this.gbGeneral.Controls.Add(this.btnSave);
            this.gbGeneral.Controls.Add(this.txtInfo);
            this.gbGeneral.Controls.Add(this.dtRepairDate);
            this.gbGeneral.Controls.Add(this.dtRegistDate);
            this.gbGeneral.Controls.Add(this.comboStatus);
            this.gbGeneral.Controls.Add(this.comboWorker);
            this.gbGeneral.Controls.Add(this.comboSenior);
            this.gbGeneral.Controls.Add(this.lblWorker);
            this.gbGeneral.Controls.Add(this.lblStatus);
            this.gbGeneral.Controls.Add(this.lblRegistDate);
            this.gbGeneral.Controls.Add(this.lblRepairDate);
            this.gbGeneral.Controls.Add(this.lblInfo);
            this.gbGeneral.Controls.Add(this.lblSenior);
            this.gbGeneral.Controls.Add(this.lblLp);
            this.gbGeneral.Location = new System.Drawing.Point(45, 89);
            this.gbGeneral.Name = "gbGeneral";
            this.gbGeneral.Size = new System.Drawing.Size(840, 389);
            this.gbGeneral.TabIndex = 0;
            this.gbGeneral.TabStop = false;
            this.gbGeneral.Text = "Dane";
            // 
            // txtLp
            // 
            this.txtLp.Location = new System.Drawing.Point(178, 48);
            this.txtLp.Name = "txtLp";
            this.txtLp.Size = new System.Drawing.Size(172, 20);
            this.txtLp.TabIndex = 16;
            this.txtLp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLp_KeyPress);
            this.txtLp.Validated += new System.EventHandler(this.txtLp_Validated);
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::GoldenHand.Properties.Resources.dismiss_24;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(302, 315);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(127, 42);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Anuluj Dodawanie";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = global::GoldenHand.Properties.Resources.add_241;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(178, 315);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(118, 42);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Dodaj Formularz";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtInfo
            // 
            this.txtInfo.Location = new System.Drawing.Point(178, 216);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(251, 74);
            this.txtInfo.TabIndex = 13;
            // 
            // dtRepairDate
            // 
            this.dtRepairDate.CustomFormat = " ";
            this.dtRepairDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtRepairDate.Location = new System.Drawing.Point(178, 179);
            this.dtRepairDate.Name = "dtRepairDate";
            this.dtRepairDate.Size = new System.Drawing.Size(251, 20);
            this.dtRepairDate.TabIndex = 12;
            this.dtRepairDate.ValueChanged += new System.EventHandler(this.dtRepair_ValueChanged);
            // 
            // dtRegistDate
            // 
            this.dtRegistDate.CustomFormat = " ";
            this.dtRegistDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtRegistDate.Location = new System.Drawing.Point(178, 153);
            this.dtRegistDate.Name = "dtRegistDate";
            this.dtRegistDate.Size = new System.Drawing.Size(251, 20);
            this.dtRegistDate.TabIndex = 11;
            this.dtRegistDate.ValueChanged += new System.EventHandler(this.dt_ValueChanged);
            // 
            // comboStatus
            // 
            this.comboStatus.DataSource = this.bsStatus;
            this.comboStatus.DisplayMember = "Name";
            this.comboStatus.FormattingEnabled = true;
            this.comboStatus.Location = new System.Drawing.Point(178, 128);
            this.comboStatus.Name = "comboStatus";
            this.comboStatus.Size = new System.Drawing.Size(172, 21);
            this.comboStatus.TabIndex = 10;
            this.comboStatus.ValueMember = "FormStatusId";
            // 
            // bsStatus
            // 
            this.bsStatus.DataSource = typeof(GoldenHand.Models.FormStatus);
            // 
            // comboWorker
            // 
            this.comboWorker.DataSource = this.bsWorkers;
            this.comboWorker.DisplayMember = "Name";
            this.comboWorker.FormattingEnabled = true;
            this.comboWorker.Location = new System.Drawing.Point(178, 101);
            this.comboWorker.Name = "comboWorker";
            this.comboWorker.Size = new System.Drawing.Size(251, 21);
            this.comboWorker.TabIndex = 9;
            this.comboWorker.ValueMember = "WorkerId";
            // 
            // bsWorkers
            // 
            this.bsWorkers.DataSource = typeof(GoldenHand.Models.Worker);
            // 
            // comboSenior
            // 
            this.comboSenior.DataSource = this.bsSeniors;
            this.comboSenior.DisplayMember = "SeniorShortcut";
            this.comboSenior.FormattingEnabled = true;
            this.comboSenior.Location = new System.Drawing.Point(178, 74);
            this.comboSenior.Name = "comboSenior";
            this.comboSenior.Size = new System.Drawing.Size(251, 21);
            this.comboSenior.TabIndex = 8;
            this.comboSenior.ValueMember = "SeniorId";
            // 
            // bsSeniors
            // 
            this.bsSeniors.DataSource = typeof(GoldenHand.Models.Senior);
            // 
            // lblWorker
            // 
            this.lblWorker.AutoSize = true;
            this.lblWorker.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblWorker.Location = new System.Drawing.Point(67, 105);
            this.lblWorker.Name = "lblWorker";
            this.lblWorker.Size = new System.Drawing.Size(71, 17);
            this.lblWorker.TabIndex = 6;
            this.lblWorker.Text = "Pracownik";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblStatus.Location = new System.Drawing.Point(67, 132);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(46, 17);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "Status";
            // 
            // lblRegistDate
            // 
            this.lblRegistDate.AutoSize = true;
            this.lblRegistDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblRegistDate.Location = new System.Drawing.Point(67, 156);
            this.lblRegistDate.Name = "lblRegistDate";
            this.lblRegistDate.Size = new System.Drawing.Size(105, 17);
            this.lblRegistDate.TabIndex = 4;
            this.lblRegistDate.Text = "Data zgłoszenia";
            // 
            // lblRepairDate
            // 
            this.lblRepairDate.AutoSize = true;
            this.lblRepairDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblRepairDate.Location = new System.Drawing.Point(67, 179);
            this.lblRepairDate.Name = "lblRepairDate";
            this.lblRepairDate.Size = new System.Drawing.Size(93, 17);
            this.lblRepairDate.TabIndex = 3;
            this.lblRepairDate.Text = "Data naprawy";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblInfo.Location = new System.Drawing.Point(67, 216);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(74, 17);
            this.lblInfo.TabIndex = 2;
            this.lblInfo.Text = "Informacje";
            // 
            // lblSenior
            // 
            this.lblSenior.AutoSize = true;
            this.lblSenior.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSenior.Location = new System.Drawing.Point(67, 78);
            this.lblSenior.Name = "lblSenior";
            this.lblSenior.Size = new System.Drawing.Size(47, 17);
            this.lblSenior.TabIndex = 1;
            this.lblSenior.Text = "Senior";
            // 
            // lblLp
            // 
            this.lblLp.AutoSize = true;
            this.lblLp.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLp.Location = new System.Drawing.Point(67, 51);
            this.lblLp.Name = "lblLp";
            this.lblLp.Size = new System.Drawing.Size(23, 17);
            this.lblLp.TabIndex = 0;
            this.lblLp.Text = "Lp";
            // 
            // errorProviderLp
            // 
            this.errorProviderLp.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderLp.ContainerControl = this;
            // 
            // errorProviderRegistDate
            // 
            this.errorProviderRegistDate.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderRegistDate.ContainerControl = this;
            // 
            // errorProviderRepairDate
            // 
            this.errorProviderRepairDate.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderRepairDate.ContainerControl = this;
            // 
            // FormAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 583);
            this.Controls.Add(this.gbGeneral);
            this.Name = "FormAddForm";
            this.Text = "Dodaj formularz";
            this.gbGeneral.ResumeLayout(false);
            this.gbGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsWorkers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSeniors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderRegistDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderRepairDate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbGeneral;
        private System.Windows.Forms.Label lblRegistDate;
        private System.Windows.Forms.Label lblRepairDate;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblSenior;
        private System.Windows.Forms.Label lblLp;
        private System.Windows.Forms.Label lblWorker;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.DateTimePicker dtRepairDate;
        private System.Windows.Forms.DateTimePicker dtRegistDate;
        private System.Windows.Forms.ComboBox comboStatus;
        private System.Windows.Forms.ComboBox comboWorker;
        private System.Windows.Forms.ComboBox comboSenior;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.BindingSource bsStatus;
        private System.Windows.Forms.ErrorProvider errorProviderLp;
        private System.Windows.Forms.TextBox txtLp;
        private System.Windows.Forms.ErrorProvider errorProviderRegistDate;
        private System.Windows.Forms.BindingSource bsSeniors;
        private System.Windows.Forms.BindingSource bsWorkers;
        private System.Windows.Forms.ErrorProvider errorProviderRepairDate;
    }
}