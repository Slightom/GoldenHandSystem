namespace GoldenHand.Forms.Forms
{
    partial class FormEditForm
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
            ((System.ComponentModel.ISupportInitialize)(this.bsStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsWorkers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSeniors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderRegistDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderRepairDate)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLp
            // 
            this.txtLp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtLp.Location = new System.Drawing.Point(168, 56);
            this.txtLp.Name = "txtLp";
            this.txtLp.Size = new System.Drawing.Size(172, 29);
            this.txtLp.TabIndex = 32;
            this.txtLp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLp_KeyPress);
            this.txtLp.Validated += new System.EventHandler(this.txtLp_Validated);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCancel.Image = global::GoldenHand.Properties.Resources.dismiss_24;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(343, 345);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(159, 42);
            this.btnCancel.TabIndex = 31;
            this.btnCancel.Text = "Anuluj Zmiany";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSave.Image = global::GoldenHand.Properties.Resources.add_241;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(168, 345);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(169, 42);
            this.btnSave.TabIndex = 30;
            this.btnSave.Text = "Zapisz Zmiany";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtInfo
            // 
            this.txtInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtInfo.Location = new System.Drawing.Point(168, 265);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(334, 74);
            this.txtInfo.TabIndex = 29;
            // 
            // dtRepairDate
            // 
            this.dtRepairDate.CustomFormat = " ";
            this.dtRepairDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtRepairDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtRepairDate.Location = new System.Drawing.Point(168, 230);
            this.dtRepairDate.Name = "dtRepairDate";
            this.dtRepairDate.Size = new System.Drawing.Size(251, 29);
            this.dtRepairDate.TabIndex = 28;
            this.dtRepairDate.ValueChanged += new System.EventHandler(this.dtRepair_ValueChanged);
            // 
            // dtRegistDate
            // 
            this.dtRegistDate.CustomFormat = " ";
            this.dtRegistDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtRegistDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtRegistDate.Location = new System.Drawing.Point(168, 195);
            this.dtRegistDate.Name = "dtRegistDate";
            this.dtRegistDate.Size = new System.Drawing.Size(251, 29);
            this.dtRegistDate.TabIndex = 27;
            this.dtRegistDate.ValueChanged += new System.EventHandler(this.dt_ValueChanged);
            // 
            // comboStatus
            // 
            this.comboStatus.DataSource = this.bsStatus;
            this.comboStatus.DisplayMember = "Name";
            this.comboStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboStatus.FormattingEnabled = true;
            this.comboStatus.Location = new System.Drawing.Point(168, 161);
            this.comboStatus.Name = "comboStatus";
            this.comboStatus.Size = new System.Drawing.Size(172, 29);
            this.comboStatus.TabIndex = 26;
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
            this.comboWorker.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboWorker.FormattingEnabled = true;
            this.comboWorker.Location = new System.Drawing.Point(168, 126);
            this.comboWorker.Name = "comboWorker";
            this.comboWorker.Size = new System.Drawing.Size(334, 29);
            this.comboWorker.TabIndex = 25;
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
            this.comboSenior.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboSenior.FormattingEnabled = true;
            this.comboSenior.Location = new System.Drawing.Point(168, 91);
            this.comboSenior.Name = "comboSenior";
            this.comboSenior.Size = new System.Drawing.Size(334, 29);
            this.comboSenior.TabIndex = 24;
            this.comboSenior.ValueMember = "SeniorId";
            // 
            // bsSeniors
            // 
            this.bsSeniors.DataSource = typeof(GoldenHand.Models.Senior);
            // 
            // lblWorker
            // 
            this.lblWorker.AutoSize = true;
            this.lblWorker.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblWorker.Location = new System.Drawing.Point(33, 129);
            this.lblWorker.Name = "lblWorker";
            this.lblWorker.Size = new System.Drawing.Size(90, 21);
            this.lblWorker.TabIndex = 23;
            this.lblWorker.Text = "Pracownik";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblStatus.Location = new System.Drawing.Point(33, 164);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(57, 21);
            this.lblStatus.TabIndex = 22;
            this.lblStatus.Text = "Status";
            // 
            // lblRegistDate
            // 
            this.lblRegistDate.AutoSize = true;
            this.lblRegistDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblRegistDate.Location = new System.Drawing.Point(33, 201);
            this.lblRegistDate.Name = "lblRegistDate";
            this.lblRegistDate.Size = new System.Drawing.Size(131, 21);
            this.lblRegistDate.TabIndex = 21;
            this.lblRegistDate.Text = "Data zgłoszenia";
            // 
            // lblRepairDate
            // 
            this.lblRepairDate.AutoSize = true;
            this.lblRepairDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblRepairDate.Location = new System.Drawing.Point(33, 236);
            this.lblRepairDate.Name = "lblRepairDate";
            this.lblRepairDate.Size = new System.Drawing.Size(116, 21);
            this.lblRepairDate.TabIndex = 20;
            this.lblRepairDate.Text = "Data naprawy";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblInfo.Location = new System.Drawing.Point(33, 268);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(84, 21);
            this.lblInfo.TabIndex = 19;
            this.lblInfo.Text = "Informacje";
            // 
            // lblSenior
            // 
            this.lblSenior.AutoSize = true;
            this.lblSenior.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSenior.Location = new System.Drawing.Point(33, 94);
            this.lblSenior.Name = "lblSenior";
            this.lblSenior.Size = new System.Drawing.Size(59, 21);
            this.lblSenior.TabIndex = 18;
            this.lblSenior.Text = "Senior";
            // 
            // lblLp
            // 
            this.lblLp.AutoSize = true;
            this.lblLp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLp.Location = new System.Drawing.Point(33, 59);
            this.lblLp.Name = "lblLp";
            this.lblLp.Size = new System.Drawing.Size(28, 21);
            this.lblLp.TabIndex = 17;
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
            // FormEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtLp);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.dtRepairDate);
            this.Controls.Add(this.dtRegistDate);
            this.Controls.Add(this.comboStatus);
            this.Controls.Add(this.comboWorker);
            this.Controls.Add(this.comboSenior);
            this.Controls.Add(this.lblWorker);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblRegistDate);
            this.Controls.Add(this.lblRepairDate);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblSenior);
            this.Controls.Add(this.lblLp);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "FormEditForm";
            this.Text = "Edycja Formularza";
            ((System.ComponentModel.ISupportInitialize)(this.bsStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsWorkers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSeniors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderRegistDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderRepairDate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLp;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.DateTimePicker dtRepairDate;
        private System.Windows.Forms.DateTimePicker dtRegistDate;
        private System.Windows.Forms.ComboBox comboStatus;
        private System.Windows.Forms.ComboBox comboWorker;
        private System.Windows.Forms.ComboBox comboSenior;
        private System.Windows.Forms.Label lblWorker;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblRegistDate;
        private System.Windows.Forms.Label lblRepairDate;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblSenior;
        private System.Windows.Forms.Label lblLp;
        private System.Windows.Forms.BindingSource bsStatus;
        private System.Windows.Forms.BindingSource bsWorkers;
        private System.Windows.Forms.BindingSource bsSeniors;
        private System.Windows.Forms.ErrorProvider errorProviderLp;
        private System.Windows.Forms.ErrorProvider errorProviderRegistDate;
        private System.Windows.Forms.ErrorProvider errorProviderRepairDate;
    }
}