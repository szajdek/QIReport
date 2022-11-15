namespace QualityShims.Forms
{
    partial class ManageInspectionReportsForm
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
            this.dgvInspectionReports = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batchNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serialNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inspectorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inspectionStatusDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bsShimInspectionReportViewModel = new System.Windows.Forms.BindingSource(this.components);
            this.btnShow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInspectionReports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsShimInspectionReportViewModel)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInspectionReports
            // 
            this.dgvInspectionReports.AllowUserToAddRows = false;
            this.dgvInspectionReports.AutoGenerateColumns = false;
            this.dgvInspectionReports.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInspectionReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInspectionReports.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.partTypeDataGridViewTextBoxColumn,
            this.partNoDataGridViewTextBoxColumn,
            this.orderNoDataGridViewTextBoxColumn,
            this.batchNoDataGridViewTextBoxColumn,
            this.serialNoDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.inspectorDataGridViewTextBoxColumn,
            this.inspectionStatusDataGridViewCheckBoxColumn});
            this.dgvInspectionReports.DataSource = this.bsShimInspectionReportViewModel;
            this.dgvInspectionReports.Location = new System.Drawing.Point(12, 138);
            this.dgvInspectionReports.Name = "dgvInspectionReports";
            this.dgvInspectionReports.ReadOnly = true;
            this.dgvInspectionReports.RowHeadersVisible = false;
            this.dgvInspectionReports.RowTemplate.Height = 25;
            this.dgvInspectionReports.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInspectionReports.Size = new System.Drawing.Size(776, 150);
            this.dgvInspectionReports.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // partTypeDataGridViewTextBoxColumn
            // 
            this.partTypeDataGridViewTextBoxColumn.DataPropertyName = "PartType";
            this.partTypeDataGridViewTextBoxColumn.HeaderText = "PartType";
            this.partTypeDataGridViewTextBoxColumn.Name = "partTypeDataGridViewTextBoxColumn";
            this.partTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // partNoDataGridViewTextBoxColumn
            // 
            this.partNoDataGridViewTextBoxColumn.DataPropertyName = "PartNo";
            this.partNoDataGridViewTextBoxColumn.HeaderText = "PartNo";
            this.partNoDataGridViewTextBoxColumn.Name = "partNoDataGridViewTextBoxColumn";
            this.partNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderNoDataGridViewTextBoxColumn
            // 
            this.orderNoDataGridViewTextBoxColumn.DataPropertyName = "OrderNo";
            this.orderNoDataGridViewTextBoxColumn.HeaderText = "OrderNo";
            this.orderNoDataGridViewTextBoxColumn.Name = "orderNoDataGridViewTextBoxColumn";
            this.orderNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // batchNoDataGridViewTextBoxColumn
            // 
            this.batchNoDataGridViewTextBoxColumn.DataPropertyName = "BatchNo";
            this.batchNoDataGridViewTextBoxColumn.HeaderText = "BatchNo";
            this.batchNoDataGridViewTextBoxColumn.Name = "batchNoDataGridViewTextBoxColumn";
            this.batchNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // serialNoDataGridViewTextBoxColumn
            // 
            this.serialNoDataGridViewTextBoxColumn.DataPropertyName = "SerialNo";
            this.serialNoDataGridViewTextBoxColumn.HeaderText = "SerialNo";
            this.serialNoDataGridViewTextBoxColumn.Name = "serialNoDataGridViewTextBoxColumn";
            this.serialNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // inspectorDataGridViewTextBoxColumn
            // 
            this.inspectorDataGridViewTextBoxColumn.DataPropertyName = "Inspector";
            this.inspectorDataGridViewTextBoxColumn.HeaderText = "Inspector";
            this.inspectorDataGridViewTextBoxColumn.Name = "inspectorDataGridViewTextBoxColumn";
            this.inspectorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // inspectionStatusDataGridViewCheckBoxColumn
            // 
            this.inspectionStatusDataGridViewCheckBoxColumn.DataPropertyName = "InspectionStatus";
            this.inspectionStatusDataGridViewCheckBoxColumn.HeaderText = "InspectionStatus";
            this.inspectionStatusDataGridViewCheckBoxColumn.Name = "inspectionStatusDataGridViewCheckBoxColumn";
            this.inspectionStatusDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // bsShimInspectionReportViewModel
            // 
            this.bsShimInspectionReportViewModel.DataSource = typeof(QualityShims.ViewModel.ShimInspectionReportViewModel);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(511, 358);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 1;
            this.btnShow.Text = "Wyświetl";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // ManageInspectionReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.dgvInspectionReports);
            this.Name = "ManageInspectionReportsForm";
            this.Text = "Raporty pomiarowe";
            this.Load += new System.EventHandler(this.ManageInspectionReportsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInspectionReports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsShimInspectionReportViewModel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvInspectionReports;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn partTypeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn partNoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn orderNoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn batchNoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn serialNoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn inspectorDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn inspectionStatusDataGridViewCheckBoxColumn;
        private BindingSource bsShimInspectionReportViewModel;
        private Button btnShow;
    }
}