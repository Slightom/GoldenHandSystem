namespace GoldenHand.Forms.Seniors
{
    partial class SeniorDetailsForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gbGeneral = new System.Windows.Forms.GroupBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgForms = new System.Windows.Forms.DataGridView();
            this.lbl = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.formIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formStatusNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registrationDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.repairDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.infoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seniorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seniorAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seniorPhoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsSeniorForms = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.gbGeneral.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgForms)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsSeniorForms)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.gbGeneral, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(762, 576);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // gbGeneral
            // 
            this.gbGeneral.Controls.Add(this.txtAddress);
            this.gbGeneral.Controls.Add(this.txtPhoneNumber);
            this.gbGeneral.Controls.Add(this.txtName);
            this.gbGeneral.Controls.Add(this.lblPhoneNumber);
            this.gbGeneral.Controls.Add(this.lblAddress);
            this.gbGeneral.Controls.Add(this.lblName);
            this.gbGeneral.Location = new System.Drawing.Point(3, 3);
            this.gbGeneral.Name = "gbGeneral";
            this.gbGeneral.Size = new System.Drawing.Size(756, 244);
            this.gbGeneral.TabIndex = 2;
            this.gbGeneral.TabStop = false;
            this.gbGeneral.Text = "Dane";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtAddress.Location = new System.Drawing.Point(191, 97);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(294, 26);
            this.txtAddress.TabIndex = 21;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPhoneNumber.Location = new System.Drawing.Point(191, 129);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.ReadOnly = true;
            this.txtPhoneNumber.Size = new System.Drawing.Size(185, 26);
            this.txtPhoneNumber.TabIndex = 20;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtName.Location = new System.Drawing.Point(191, 65);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(294, 26);
            this.txtName.TabIndex = 19;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPhoneNumber.Location = new System.Drawing.Point(59, 131);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(98, 21);
            this.lblPhoneNumber.TabIndex = 18;
            this.lblPhoneNumber.Text = "Nr telefonu";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAddress.Location = new System.Drawing.Point(59, 99);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(53, 21);
            this.lblAddress.TabIndex = 17;
            this.lblAddress.Text = "Adres";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblName.Location = new System.Drawing.Point(59, 67);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(126, 21);
            this.lblName.TabIndex = 16;
            this.lblName.Text = "Imię, Nazwisko";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 253);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(756, 320);
            this.panel1.TabIndex = 3;
            // 
            // dgForms
            // 
            this.dgForms.AllowUserToAddRows = false;
            this.dgForms.AllowUserToDeleteRows = false;
            this.dgForms.AutoGenerateColumns = false;
            this.dgForms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgForms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.formIdDataGridViewTextBoxColumn,
            this.lpDataGridViewTextBoxColumn,
            this.formStatusNameDataGridViewTextBoxColumn,
            this.workerNameDataGridViewTextBoxColumn,
            this.registrationDateDataGridViewTextBoxColumn,
            this.repairDateDataGridViewTextBoxColumn,
            this.infoDataGridViewTextBoxColumn,
            this.seniorNameDataGridViewTextBoxColumn,
            this.seniorAddressDataGridViewTextBoxColumn,
            this.seniorPhoneNumberDataGridViewTextBoxColumn});
            this.dgForms.DataSource = this.bsSeniorForms;
            this.dgForms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgForms.Location = new System.Drawing.Point(3, 46);
            this.dgForms.Name = "dgForms";
            this.dgForms.ReadOnly = true;
            this.dgForms.RowHeadersVisible = false;
            this.dgForms.Size = new System.Drawing.Size(750, 271);
            this.dgForms.TabIndex = 1;
            // 
            // lbl
            // 
            this.lbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl.Location = new System.Drawing.Point(306, 11);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(143, 21);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "Historia Zgłoszeń";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AllowDrop = true;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.dgForms, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbl, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(756, 320);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // formIdDataGridViewTextBoxColumn
            // 
            this.formIdDataGridViewTextBoxColumn.DataPropertyName = "FormId";
            this.formIdDataGridViewTextBoxColumn.HeaderText = "FormId";
            this.formIdDataGridViewTextBoxColumn.Name = "formIdDataGridViewTextBoxColumn";
            this.formIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.formIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // lpDataGridViewTextBoxColumn
            // 
            this.lpDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.lpDataGridViewTextBoxColumn.DataPropertyName = "Lp";
            this.lpDataGridViewTextBoxColumn.HeaderText = "Lp";
            this.lpDataGridViewTextBoxColumn.Name = "lpDataGridViewTextBoxColumn";
            this.lpDataGridViewTextBoxColumn.ReadOnly = true;
            this.lpDataGridViewTextBoxColumn.Width = 44;
            // 
            // formStatusNameDataGridViewTextBoxColumn
            // 
            this.formStatusNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.formStatusNameDataGridViewTextBoxColumn.DataPropertyName = "FormStatusName";
            this.formStatusNameDataGridViewTextBoxColumn.HeaderText = "Status";
            this.formStatusNameDataGridViewTextBoxColumn.Name = "formStatusNameDataGridViewTextBoxColumn";
            this.formStatusNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.formStatusNameDataGridViewTextBoxColumn.Width = 62;
            // 
            // workerNameDataGridViewTextBoxColumn
            // 
            this.workerNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.workerNameDataGridViewTextBoxColumn.DataPropertyName = "WorkerName";
            this.workerNameDataGridViewTextBoxColumn.HeaderText = "Pracownik";
            this.workerNameDataGridViewTextBoxColumn.Name = "workerNameDataGridViewTextBoxColumn";
            this.workerNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.workerNameDataGridViewTextBoxColumn.Width = 82;
            // 
            // registrationDateDataGridViewTextBoxColumn
            // 
            this.registrationDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.registrationDateDataGridViewTextBoxColumn.DataPropertyName = "RegistrationDate";
            this.registrationDateDataGridViewTextBoxColumn.HeaderText = "Data zgłoszenia";
            this.registrationDateDataGridViewTextBoxColumn.Name = "registrationDateDataGridViewTextBoxColumn";
            this.registrationDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // repairDateDataGridViewTextBoxColumn
            // 
            this.repairDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.repairDateDataGridViewTextBoxColumn.DataPropertyName = "RepairDate";
            this.repairDateDataGridViewTextBoxColumn.HeaderText = "Data naprawy";
            this.repairDateDataGridViewTextBoxColumn.Name = "repairDateDataGridViewTextBoxColumn";
            this.repairDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.repairDateDataGridViewTextBoxColumn.Width = 90;
            // 
            // infoDataGridViewTextBoxColumn
            // 
            this.infoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.infoDataGridViewTextBoxColumn.DataPropertyName = "Info";
            this.infoDataGridViewTextBoxColumn.HeaderText = "Info";
            this.infoDataGridViewTextBoxColumn.Name = "infoDataGridViewTextBoxColumn";
            this.infoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // seniorNameDataGridViewTextBoxColumn
            // 
            this.seniorNameDataGridViewTextBoxColumn.DataPropertyName = "SeniorName";
            this.seniorNameDataGridViewTextBoxColumn.HeaderText = "SeniorName";
            this.seniorNameDataGridViewTextBoxColumn.Name = "seniorNameDataGridViewTextBoxColumn";
            this.seniorNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.seniorNameDataGridViewTextBoxColumn.Visible = false;
            // 
            // seniorAddressDataGridViewTextBoxColumn
            // 
            this.seniorAddressDataGridViewTextBoxColumn.DataPropertyName = "SeniorAddress";
            this.seniorAddressDataGridViewTextBoxColumn.HeaderText = "SeniorAddress";
            this.seniorAddressDataGridViewTextBoxColumn.Name = "seniorAddressDataGridViewTextBoxColumn";
            this.seniorAddressDataGridViewTextBoxColumn.ReadOnly = true;
            this.seniorAddressDataGridViewTextBoxColumn.Visible = false;
            // 
            // seniorPhoneNumberDataGridViewTextBoxColumn
            // 
            this.seniorPhoneNumberDataGridViewTextBoxColumn.DataPropertyName = "SeniorPhoneNumber";
            this.seniorPhoneNumberDataGridViewTextBoxColumn.HeaderText = "SeniorPhoneNumber";
            this.seniorPhoneNumberDataGridViewTextBoxColumn.Name = "seniorPhoneNumberDataGridViewTextBoxColumn";
            this.seniorPhoneNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.seniorPhoneNumberDataGridViewTextBoxColumn.Visible = false;
            // 
            // bsSeniorForms
            // 
            this.bsSeniorForms.DataSource = typeof(GoldenHand.ViewModels.FormViewModel);
            // 
            // SeniorDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 576);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "SeniorDetailsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SeniorDetailsForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.gbGeneral.ResumeLayout(false);
            this.gbGeneral.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgForms)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsSeniorForms)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox gbGeneral;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dgForms;
        private System.Windows.Forms.DataGridViewTextBoxColumn formIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn formStatusNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn registrationDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn repairDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn infoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seniorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seniorAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seniorPhoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bsSeniorForms;
        private System.Windows.Forms.Label lbl;
    }
}