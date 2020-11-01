namespace GoldenHand.Forms.Summary
{
    partial class SummaryForm
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
            this.dgSummary = new System.Windows.Forms.DataGridView();
            this.Period = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FormsAll = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FormFinished = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FormsRegisted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FormsRejected = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgSummary)).BeginInit();
            this.SuspendLayout();
            // 
            // dgSummary
            // 
            this.dgSummary.AllowUserToAddRows = false;
            this.dgSummary.AllowUserToDeleteRows = false;
            this.dgSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSummary.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Period,
            this.FormsAll,
            this.FormFinished,
            this.FormsRegisted,
            this.FormsRejected});
            this.dgSummary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgSummary.Location = new System.Drawing.Point(0, 0);
            this.dgSummary.Name = "dgSummary";
            this.dgSummary.ReadOnly = true;
            this.dgSummary.RowHeadersVisible = false;
            this.dgSummary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgSummary.Size = new System.Drawing.Size(800, 450);
            this.dgSummary.TabIndex = 0;
            // 
            // Period
            // 
            this.Period.HeaderText = "Okres";
            this.Period.Name = "Period";
            this.Period.ReadOnly = true;
            // 
            // FormsAll
            // 
            this.FormsAll.HeaderText = "Formularze";
            this.FormsAll.Name = "FormsAll";
            this.FormsAll.ReadOnly = true;
            // 
            // FormFinished
            // 
            this.FormFinished.HeaderText = "Wykonane";
            this.FormFinished.Name = "FormFinished";
            this.FormFinished.ReadOnly = true;
            // 
            // FormsRegisted
            // 
            this.FormsRegisted.HeaderText = "Oczekujące";
            this.FormsRegisted.Name = "FormsRegisted";
            this.FormsRegisted.ReadOnly = true;
            // 
            // FormsRejected
            // 
            this.FormsRejected.HeaderText = "Rezygnacja";
            this.FormsRejected.Name = "FormsRejected";
            this.FormsRejected.ReadOnly = true;
            // 
            // SummaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgSummary);
            this.Name = "SummaryForm";
            this.Text = "Podsumowanie";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SummaryForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgSummary)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgSummary;
        private System.Windows.Forms.DataGridViewTextBoxColumn Period;
        private System.Windows.Forms.DataGridViewTextBoxColumn FormsAll;
        private System.Windows.Forms.DataGridViewTextBoxColumn FormFinished;
        private System.Windows.Forms.DataGridViewTextBoxColumn FormsRegisted;
        private System.Windows.Forms.DataGridViewTextBoxColumn FormsRejected;
    }
}