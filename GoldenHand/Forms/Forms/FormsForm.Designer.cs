namespace GoldenHand.Forms.Forms
{
    partial class FormsForm
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
            this.tlpForms = new System.Windows.Forms.TableLayoutPanel();
            this.pForms = new System.Windows.Forms.Panel();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dgForms = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSenior = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPracownik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRegistDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRepairDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsForms = new System.Windows.Forms.BindingSource(this.components);
            this.tlpForms.SuspendLayout();
            this.pForms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgForms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsForms)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpForms
            // 
            this.tlpForms.ColumnCount = 1;
            this.tlpForms.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpForms.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpForms.Controls.Add(this.pForms, 0, 0);
            this.tlpForms.Controls.Add(this.dgForms, 0, 1);
            this.tlpForms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpForms.Location = new System.Drawing.Point(0, 0);
            this.tlpForms.Name = "tlpForms";
            this.tlpForms.RowCount = 2;
            this.tlpForms.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpForms.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpForms.Size = new System.Drawing.Size(1184, 861);
            this.tlpForms.TabIndex = 0;
            // 
            // pForms
            // 
            this.pForms.Controls.Add(this.btnRefresh);
            this.pForms.Controls.Add(this.btnRemove);
            this.pForms.Controls.Add(this.btnModify);
            this.pForms.Controls.Add(this.btnCreate);
            this.pForms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pForms.Location = new System.Drawing.Point(3, 3);
            this.pForms.Name = "pForms";
            this.pForms.Size = new System.Drawing.Size(1178, 34);
            this.pForms.TabIndex = 0;
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.White;
            this.btnCreate.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCreate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCreate.Image = global::GoldenHand.Properties.Resources.add_24;
            this.btnCreate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreate.Location = new System.Drawing.Point(0, 0);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(90, 34);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Dodaj";
            this.btnCreate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCreate.UseVisualStyleBackColor = false;
            // 
            // btnModify
            // 
            this.btnModify.BackColor = System.Drawing.Color.White;
            this.btnModify.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnModify.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnModify.Image = global::GoldenHand.Properties.Resources.edit_24;
            this.btnModify.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModify.Location = new System.Drawing.Point(90, 0);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(105, 34);
            this.btnModify.TabIndex = 1;
            this.btnModify.Text = "Modyfikuj";
            this.btnModify.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModify.UseVisualStyleBackColor = false;
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.White;
            this.btnRemove.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRemove.Image = global::GoldenHand.Properties.Resources.delete_24;
            this.btnRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemove.Location = new System.Drawing.Point(195, 0);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(90, 34);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Usuń";
            this.btnRemove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemove.UseVisualStyleBackColor = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.White;
            this.btnRefresh.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRefresh.Image = global::GoldenHand.Properties.Resources.refresh_24;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(285, 0);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(105, 34);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Odświerz";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.UseVisualStyleBackColor = false;
            // 
            // dgForms
            // 
            this.dgForms.AllowUserToAddRows = false;
            this.dgForms.AllowUserToDeleteRows = false;
            this.dgForms.AllowUserToOrderColumns = true;
            this.dgForms.AutoGenerateColumns = false;
            this.dgForms.BackgroundColor = System.Drawing.Color.White;
            this.dgForms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgForms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colLp,
            this.colSenior,
            this.colAddress,
            this.colPhone,
            this.colStatus,
            this.colPracownik,
            this.colRegistDate,
            this.colRepairDate,
            this.colInfo});
            this.dgForms.DataSource = this.bsForms;
            this.dgForms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgForms.Location = new System.Drawing.Point(3, 43);
            this.dgForms.Name = "dgForms";
            this.dgForms.ReadOnly = true;
            this.dgForms.RowHeadersVisible = false;
            this.dgForms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgForms.Size = new System.Drawing.Size(1178, 815);
            this.dgForms.TabIndex = 1;
            // 
            // colId
            // 
            this.colId.DataPropertyName = "FormId";
            this.colId.HeaderText = "FormId";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Visible = false;
            // 
            // colLp
            // 
            this.colLp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colLp.DataPropertyName = "Lp";
            this.colLp.HeaderText = "Lp";
            this.colLp.Name = "colLp";
            this.colLp.ReadOnly = true;
            this.colLp.Width = 44;
            // 
            // colSenior
            // 
            this.colSenior.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colSenior.DataPropertyName = "SeniorName";
            this.colSenior.HeaderText = "Senior";
            this.colSenior.Name = "colSenior";
            this.colSenior.ReadOnly = true;
            this.colSenior.ToolTipText = "Imię, nazwisko Seniora";
            this.colSenior.Width = 62;
            // 
            // colAddress
            // 
            this.colAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colAddress.DataPropertyName = "SeniorAddress";
            this.colAddress.HeaderText = "Adres";
            this.colAddress.Name = "colAddress";
            this.colAddress.ReadOnly = true;
            this.colAddress.ToolTipText = "Adres Seniora";
            this.colAddress.Width = 59;
            // 
            // colPhone
            // 
            this.colPhone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colPhone.DataPropertyName = "SeniorPhoneNumber";
            this.colPhone.HeaderText = "Telefon";
            this.colPhone.Name = "colPhone";
            this.colPhone.ReadOnly = true;
            this.colPhone.ToolTipText = "Nr telefonu Seniora";
            this.colPhone.Width = 68;
            // 
            // colStatus
            // 
            this.colStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colStatus.DataPropertyName = "FormStatusName";
            this.colStatus.HeaderText = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            this.colStatus.ToolTipText = "Status formularza";
            this.colStatus.Width = 62;
            // 
            // colPracownik
            // 
            this.colPracownik.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colPracownik.DataPropertyName = "WorkerName";
            this.colPracownik.HeaderText = "Pracownik";
            this.colPracownik.Name = "colPracownik";
            this.colPracownik.ReadOnly = true;
            this.colPracownik.ToolTipText = "Imię, nazwisko pracownika";
            this.colPracownik.Width = 82;
            // 
            // colRegistDate
            // 
            this.colRegistDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colRegistDate.DataPropertyName = "RegistrationDate";
            this.colRegistDate.HeaderText = "Data zgłoszenia";
            this.colRegistDate.Name = "colRegistDate";
            this.colRegistDate.ReadOnly = true;
            this.colRegistDate.ToolTipText = "Data zgłoszenia zlecenia";
            // 
            // colRepairDate
            // 
            this.colRepairDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colRepairDate.DataPropertyName = "RepairDate";
            this.colRepairDate.HeaderText = "Data naprawy";
            this.colRepairDate.Name = "colRepairDate";
            this.colRepairDate.ReadOnly = true;
            this.colRepairDate.ToolTipText = "Proponowana data wykonania naprawy";
            this.colRepairDate.Width = 90;
            // 
            // colInfo
            // 
            this.colInfo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colInfo.DataPropertyName = "Info";
            this.colInfo.HeaderText = "Informacje";
            this.colInfo.Name = "colInfo";
            this.colInfo.ReadOnly = true;
            this.colInfo.ToolTipText = "Informacje o formularzu- co do naprawy, drugi nr telefonu itd..";
            // 
            // bsForms
            // 
            this.bsForms.DataSource = typeof(GoldenHand.ViewModels.FormViewModel);
            // 
            // FormsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 861);
            this.Controls.Add(this.tlpForms);
            this.Name = "FormsForm";
            this.Text = "Formularze";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormsForm_FormClosed);
            this.tlpForms.ResumeLayout(false);
            this.pForms.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgForms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsForms)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpForms;
        private System.Windows.Forms.Panel pForms;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.DataGridView dgForms;
        private System.Windows.Forms.BindingSource bsForms;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLp;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSenior;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPracownik;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRegistDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRepairDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInfo;
    }
}