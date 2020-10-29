namespace GoldenHand.Forms.Seniors
{
    partial class SeniorsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnDetails = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.dgSeniors = new System.Windows.Forms.DataGridView();
            this.Nr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seniorId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seniorShortcutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formsAllDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formsFinishedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formsRegistedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formsRejectedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsSeniors = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSeniors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSeniors)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgSeniors, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1007, 517);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.btnRemove);
            this.panel1.Controls.Add(this.btnModify);
            this.panel1.Controls.Add(this.btnDetails);
            this.panel1.Controls.Add(this.btnCreate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1001, 34);
            this.panel1.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.White;
            this.btnRefresh.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRefresh.Image = global::GoldenHand.Properties.Resources.refresh_24;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(390, 0);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(105, 34);
            this.btnRefresh.TabIndex = 14;
            this.btnRefresh.Text = "Odświerz";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.White;
            this.btnRemove.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRemove.Image = global::GoldenHand.Properties.Resources.delete_24;
            this.btnRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemove.Location = new System.Drawing.Point(300, 0);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(90, 34);
            this.btnRemove.TabIndex = 13;
            this.btnRemove.Text = "Usuń";
            this.btnRemove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnModify
            // 
            this.btnModify.BackColor = System.Drawing.Color.White;
            this.btnModify.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnModify.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnModify.Image = global::GoldenHand.Properties.Resources.edit_24;
            this.btnModify.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModify.Location = new System.Drawing.Point(195, 0);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(105, 34);
            this.btnModify.TabIndex = 12;
            this.btnModify.Text = "Modyfikuj";
            this.btnModify.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModify.UseVisualStyleBackColor = false;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnDetails
            // 
            this.btnDetails.BackColor = System.Drawing.Color.White;
            this.btnDetails.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDetails.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDetails.Image = global::GoldenHand.Properties.Resources.User_16;
            this.btnDetails.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetails.Location = new System.Drawing.Point(90, 0);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(105, 34);
            this.btnDetails.TabIndex = 9;
            this.btnDetails.Text = "Szczegóły";
            this.btnDetails.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDetails.UseMnemonic = false;
            this.btnDetails.UseVisualStyleBackColor = false;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
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
            this.btnCreate.TabIndex = 5;
            this.btnCreate.Text = "Dodaj";
            this.btnCreate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // dgSeniors
            // 
            this.dgSeniors.AllowUserToAddRows = false;
            this.dgSeniors.AllowUserToDeleteRows = false;
            this.dgSeniors.AllowUserToResizeRows = false;
            this.dgSeniors.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgSeniors.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgSeniors.ColumnHeadersHeight = 50;
            this.dgSeniors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgSeniors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nr,
            this.seniorId,
            this.nameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.seniorShortcutDataGridViewTextBoxColumn,
            this.formsAllDataGridViewTextBoxColumn,
            this.formsFinishedDataGridViewTextBoxColumn,
            this.formsRegistedDataGridViewTextBoxColumn,
            this.formsRejectedDataGridViewTextBoxColumn});
            this.dgSeniors.DataSource = this.bsSeniors;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgSeniors.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgSeniors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgSeniors.EnableHeadersVisualStyles = false;
            this.dgSeniors.Location = new System.Drawing.Point(3, 43);
            this.dgSeniors.Name = "dgSeniors";
            this.dgSeniors.ReadOnly = true;
            this.dgSeniors.RowHeadersVisible = false;
            this.dgSeniors.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dgSeniors.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgSeniors.RowTemplate.Height = 28;
            this.dgSeniors.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgSeniors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgSeniors.Size = new System.Drawing.Size(1001, 471);
            this.dgSeniors.TabIndex = 1;
            this.dgSeniors.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.columnheaderClicked);
            this.dgSeniors.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgSeniors_RowPostPaint);
            // 
            // Nr
            // 
            this.Nr.HeaderText = "Nr";
            this.Nr.Name = "Nr";
            this.Nr.ReadOnly = true;
            this.Nr.Width = 50;
            // 
            // seniorId
            // 
            this.seniorId.DataPropertyName = "SeniorId";
            this.seniorId.HeaderText = "SeniorId";
            this.seniorId.Name = "seniorId";
            this.seniorId.ReadOnly = true;
            this.seniorId.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Imię, nazwisko";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 124;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Adres";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            this.addressDataGridViewTextBoxColumn.Width = 68;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "Nr telefonu";
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            this.phoneNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // seniorShortcutDataGridViewTextBoxColumn
            // 
            this.seniorShortcutDataGridViewTextBoxColumn.DataPropertyName = "SeniorShortcut";
            this.seniorShortcutDataGridViewTextBoxColumn.HeaderText = "SeniorShortcut";
            this.seniorShortcutDataGridViewTextBoxColumn.Name = "seniorShortcutDataGridViewTextBoxColumn";
            this.seniorShortcutDataGridViewTextBoxColumn.ReadOnly = true;
            this.seniorShortcutDataGridViewTextBoxColumn.Visible = false;
            // 
            // formsAllDataGridViewTextBoxColumn
            // 
            this.formsAllDataGridViewTextBoxColumn.DataPropertyName = "FormsAll";
            this.formsAllDataGridViewTextBoxColumn.HeaderText = "Formularze";
            this.formsAllDataGridViewTextBoxColumn.Name = "formsAllDataGridViewTextBoxColumn";
            this.formsAllDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // formsFinishedDataGridViewTextBoxColumn
            // 
            this.formsFinishedDataGridViewTextBoxColumn.DataPropertyName = "FormsFinished";
            this.formsFinishedDataGridViewTextBoxColumn.HeaderText = "Wykonane";
            this.formsFinishedDataGridViewTextBoxColumn.Name = "formsFinishedDataGridViewTextBoxColumn";
            this.formsFinishedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // formsRegistedDataGridViewTextBoxColumn
            // 
            this.formsRegistedDataGridViewTextBoxColumn.DataPropertyName = "FormsRegisted";
            this.formsRegistedDataGridViewTextBoxColumn.HeaderText = "Oczekujące";
            this.formsRegistedDataGridViewTextBoxColumn.Name = "formsRegistedDataGridViewTextBoxColumn";
            this.formsRegistedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // formsRejectedDataGridViewTextBoxColumn
            // 
            this.formsRejectedDataGridViewTextBoxColumn.DataPropertyName = "FormsRejected";
            this.formsRejectedDataGridViewTextBoxColumn.HeaderText = "Rezygnacja";
            this.formsRejectedDataGridViewTextBoxColumn.Name = "formsRejectedDataGridViewTextBoxColumn";
            this.formsRejectedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bsSeniors
            // 
            this.bsSeniors.DataSource = typeof(GoldenHand.ViewModels.SeniorViewModel);
            // 
            // SeniorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 517);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "SeniorsForm";
            this.Text = "Seniorzy";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SeniorsForm_FormClosed);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgSeniors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSeniors)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.DataGridView dgSeniors;
        private System.Windows.Forms.BindingSource bsSeniors;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nr;
        private System.Windows.Forms.DataGridViewTextBoxColumn seniorId;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seniorShortcutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn formsAllDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn formsFinishedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn formsRegistedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn formsRejectedDataGridViewTextBoxColumn;
    }
}