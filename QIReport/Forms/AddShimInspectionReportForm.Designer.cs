namespace QualityShims.Forms
{
    partial class AddShimInspectionReportForm
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
            this.gbValues = new System.Windows.Forms.GroupBox();
            this.lblTolerance = new System.Windows.Forms.Label();
            this.tbValue4 = new System.Windows.Forms.TextBox();
            this.lblMeasurement4 = new System.Windows.Forms.Label();
            this.tbValue3 = new System.Windows.Forms.TextBox();
            this.tbValue2 = new System.Windows.Forms.TextBox();
            this.lblMeasurement3 = new System.Windows.Forms.Label();
            this.lblMeasurement2 = new System.Windows.Forms.Label();
            this.tbValue1 = new System.Windows.Forms.TextBox();
            this.lblMeasurement1 = new System.Windows.Forms.Label();
            this.gbResults = new System.Windows.Forms.GroupBox();
            this.tbDifferenceMaxMin = new System.Windows.Forms.TextBox();
            this.lblDifferenceMaxMin = new System.Windows.Forms.Label();
            this.tbAverage = new System.Windows.Forms.TextBox();
            this.lblAverage = new System.Windows.Forms.Label();
            this.gbChoosePart = new System.Windows.Forms.GroupBox();
            this.cbPartNo = new System.Windows.Forms.ComboBox();
            this.lblPartNo = new System.Windows.Forms.Label();
            this.cbPartType = new System.Windows.Forms.ComboBox();
            this.lblPartType = new System.Windows.Forms.Label();
            this.gbSurface = new System.Windows.Forms.GroupBox();
            this.rbNok = new System.Windows.Forms.RadioButton();
            this.rbOk = new System.Windows.Forms.RadioButton();
            this.tbRemarks = new System.Windows.Forms.TextBox();
            this.lblRemarks = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.gbMosData = new System.Windows.Forms.GroupBox();
            this.tbSerialNo = new System.Windows.Forms.TextBox();
            this.lblSerialNo = new System.Windows.Forms.Label();
            this.tbBatchNo = new System.Windows.Forms.TextBox();
            this.lblBatchNo = new System.Windows.Forms.Label();
            this.tbOrderNo = new System.Windows.Forms.TextBox();
            this.lblOrderNo = new System.Windows.Forms.Label();
            this.gbValues.SuspendLayout();
            this.gbResults.SuspendLayout();
            this.gbChoosePart.SuspendLayout();
            this.gbSurface.SuspendLayout();
            this.gbMosData.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbValues
            // 
            this.gbValues.Controls.Add(this.lblTolerance);
            this.gbValues.Controls.Add(this.tbValue4);
            this.gbValues.Controls.Add(this.lblMeasurement4);
            this.gbValues.Controls.Add(this.tbValue3);
            this.gbValues.Controls.Add(this.tbValue2);
            this.gbValues.Controls.Add(this.lblMeasurement3);
            this.gbValues.Controls.Add(this.lblMeasurement2);
            this.gbValues.Controls.Add(this.tbValue1);
            this.gbValues.Controls.Add(this.lblMeasurement1);
            this.gbValues.Enabled = false;
            this.gbValues.Location = new System.Drawing.Point(113, 181);
            this.gbValues.Name = "gbValues";
            this.gbValues.Size = new System.Drawing.Size(252, 192);
            this.gbValues.TabIndex = 0;
            this.gbValues.TabStop = false;
            this.gbValues.Text = "Pomiary";
            // 
            // lblTolerance
            // 
            this.lblTolerance.AutoSize = true;
            this.lblTolerance.Location = new System.Drawing.Point(138, 17);
            this.lblTolerance.Name = "lblTolerance";
            this.lblTolerance.Size = new System.Drawing.Size(38, 15);
            this.lblTolerance.TabIndex = 8;
            this.lblTolerance.Text = "label1";
            this.lblTolerance.Visible = false;
            // 
            // tbValue4
            // 
            this.tbValue4.Location = new System.Drawing.Point(138, 155);
            this.tbValue4.Name = "tbValue4";
            this.tbValue4.Size = new System.Drawing.Size(100, 23);
            this.tbValue4.TabIndex = 7;
            this.tbValue4.TextChanged += new System.EventHandler(this.tbValue_TextChanged);
            // 
            // lblMeasurement4
            // 
            this.lblMeasurement4.AutoSize = true;
            this.lblMeasurement4.Location = new System.Drawing.Point(18, 158);
            this.lblMeasurement4.Name = "lblMeasurement4";
            this.lblMeasurement4.Size = new System.Drawing.Size(114, 15);
            this.lblMeasurement4.TabIndex = 6;
            this.lblMeasurement4.Text = "Pomiar w obszarze 4";
            // 
            // tbValue3
            // 
            this.tbValue3.Location = new System.Drawing.Point(138, 113);
            this.tbValue3.Name = "tbValue3";
            this.tbValue3.Size = new System.Drawing.Size(100, 23);
            this.tbValue3.TabIndex = 5;
            this.tbValue3.TextChanged += new System.EventHandler(this.tbValue_TextChanged);
            // 
            // tbValue2
            // 
            this.tbValue2.Location = new System.Drawing.Point(138, 75);
            this.tbValue2.Name = "tbValue2";
            this.tbValue2.Size = new System.Drawing.Size(100, 23);
            this.tbValue2.TabIndex = 3;
            this.tbValue2.TextChanged += new System.EventHandler(this.tbValue_TextChanged);
            // 
            // lblMeasurement3
            // 
            this.lblMeasurement3.AutoSize = true;
            this.lblMeasurement3.Location = new System.Drawing.Point(18, 116);
            this.lblMeasurement3.Name = "lblMeasurement3";
            this.lblMeasurement3.Size = new System.Drawing.Size(114, 15);
            this.lblMeasurement3.TabIndex = 4;
            this.lblMeasurement3.Text = "Pomiar w obszarze 3";
            // 
            // lblMeasurement2
            // 
            this.lblMeasurement2.AutoSize = true;
            this.lblMeasurement2.Location = new System.Drawing.Point(18, 78);
            this.lblMeasurement2.Name = "lblMeasurement2";
            this.lblMeasurement2.Size = new System.Drawing.Size(114, 15);
            this.lblMeasurement2.TabIndex = 2;
            this.lblMeasurement2.Text = "Pomiar w obszarze 2";
            // 
            // tbValue1
            // 
            this.tbValue1.Location = new System.Drawing.Point(138, 38);
            this.tbValue1.Name = "tbValue1";
            this.tbValue1.Size = new System.Drawing.Size(100, 23);
            this.tbValue1.TabIndex = 1;
            this.tbValue1.TextChanged += new System.EventHandler(this.tbValue_TextChanged);
            // 
            // lblMeasurement1
            // 
            this.lblMeasurement1.AutoSize = true;
            this.lblMeasurement1.Location = new System.Drawing.Point(18, 41);
            this.lblMeasurement1.Name = "lblMeasurement1";
            this.lblMeasurement1.Size = new System.Drawing.Size(114, 15);
            this.lblMeasurement1.TabIndex = 0;
            this.lblMeasurement1.Text = "Pomiar w obszarze 1";
            // 
            // gbResults
            // 
            this.gbResults.Controls.Add(this.tbDifferenceMaxMin);
            this.gbResults.Controls.Add(this.lblDifferenceMaxMin);
            this.gbResults.Controls.Add(this.tbAverage);
            this.gbResults.Controls.Add(this.lblAverage);
            this.gbResults.Location = new System.Drawing.Point(451, 181);
            this.gbResults.Name = "gbResults";
            this.gbResults.Size = new System.Drawing.Size(252, 192);
            this.gbResults.TabIndex = 1;
            this.gbResults.TabStop = false;
            this.gbResults.Text = "Wyniki";
            // 
            // tbDifferenceMaxMin
            // 
            this.tbDifferenceMaxMin.Location = new System.Drawing.Point(138, 55);
            this.tbDifferenceMaxMin.Name = "tbDifferenceMaxMin";
            this.tbDifferenceMaxMin.ReadOnly = true;
            this.tbDifferenceMaxMin.Size = new System.Drawing.Size(100, 23);
            this.tbDifferenceMaxMin.TabIndex = 3;
            // 
            // lblDifferenceMaxMin
            // 
            this.lblDifferenceMaxMin.Location = new System.Drawing.Point(18, 58);
            this.lblDifferenceMaxMin.Name = "lblDifferenceMaxMin";
            this.lblDifferenceMaxMin.Size = new System.Drawing.Size(114, 69);
            this.lblDifferenceMaxMin.TabIndex = 2;
            this.lblDifferenceMaxMin.Text = "Różnica między skrajnymi wartościami pomiarów";
            // 
            // tbAverage
            // 
            this.tbAverage.Location = new System.Drawing.Point(138, 18);
            this.tbAverage.Name = "tbAverage";
            this.tbAverage.ReadOnly = true;
            this.tbAverage.Size = new System.Drawing.Size(100, 23);
            this.tbAverage.TabIndex = 1;
            // 
            // lblAverage
            // 
            this.lblAverage.AutoSize = true;
            this.lblAverage.Location = new System.Drawing.Point(18, 21);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(111, 15);
            this.lblAverage.TabIndex = 0;
            this.lblAverage.Text = "Średnia z pomiarów";
            // 
            // gbChoosePart
            // 
            this.gbChoosePart.Controls.Add(this.cbPartNo);
            this.gbChoosePart.Controls.Add(this.lblPartNo);
            this.gbChoosePart.Controls.Add(this.cbPartType);
            this.gbChoosePart.Controls.Add(this.lblPartType);
            this.gbChoosePart.Location = new System.Drawing.Point(113, 22);
            this.gbChoosePart.Name = "gbChoosePart";
            this.gbChoosePart.Size = new System.Drawing.Size(238, 136);
            this.gbChoosePart.TabIndex = 3;
            this.gbChoosePart.TabStop = false;
            this.gbChoosePart.Text = "Wybór części";
            // 
            // cbPartNo
            // 
            this.cbPartNo.Enabled = false;
            this.cbPartNo.FormattingEnabled = true;
            this.cbPartNo.Location = new System.Drawing.Point(98, 64);
            this.cbPartNo.Name = "cbPartNo";
            this.cbPartNo.Size = new System.Drawing.Size(121, 23);
            this.cbPartNo.TabIndex = 3;
            this.cbPartNo.SelectionChangeCommitted += new System.EventHandler(this.cbPartNo_SelectionChangeCommitted);
            // 
            // lblPartNo
            // 
            this.lblPartNo.AutoSize = true;
            this.lblPartNo.Location = new System.Drawing.Point(6, 67);
            this.lblPartNo.Name = "lblPartNo";
            this.lblPartNo.Size = new System.Drawing.Size(54, 15);
            this.lblPartNo.TabIndex = 2;
            this.lblPartNo.Text = "Nr części";
            // 
            // cbPartType
            // 
            this.cbPartType.FormattingEnabled = true;
            this.cbPartType.Location = new System.Drawing.Point(98, 28);
            this.cbPartType.Name = "cbPartType";
            this.cbPartType.Size = new System.Drawing.Size(121, 23);
            this.cbPartType.TabIndex = 1;
            this.cbPartType.SelectionChangeCommitted += new System.EventHandler(this.cbPartType_SelectionChangeCommitted);
            // 
            // lblPartType
            // 
            this.lblPartType.AutoSize = true;
            this.lblPartType.Location = new System.Drawing.Point(6, 31);
            this.lblPartType.Name = "lblPartType";
            this.lblPartType.Size = new System.Drawing.Size(59, 15);
            this.lblPartType.TabIndex = 0;
            this.lblPartType.Text = "Typ części";
            // 
            // gbSurface
            // 
            this.gbSurface.Controls.Add(this.rbNok);
            this.gbSurface.Controls.Add(this.rbOk);
            this.gbSurface.Location = new System.Drawing.Point(303, 403);
            this.gbSurface.Name = "gbSurface";
            this.gbSurface.Size = new System.Drawing.Size(200, 100);
            this.gbSurface.TabIndex = 4;
            this.gbSurface.TabStop = false;
            this.gbSurface.Text = "Stan powierzchni";
            // 
            // rbNok
            // 
            this.rbNok.AutoSize = true;
            this.rbNok.Location = new System.Drawing.Point(53, 55);
            this.rbNok.Name = "rbNok";
            this.rbNok.Size = new System.Drawing.Size(50, 19);
            this.rbNok.TabIndex = 1;
            this.rbNok.TabStop = true;
            this.rbNok.Text = "NOK";
            this.rbNok.UseVisualStyleBackColor = true;
            // 
            // rbOk
            // 
            this.rbOk.AutoSize = true;
            this.rbOk.Location = new System.Drawing.Point(53, 30);
            this.rbOk.Name = "rbOk";
            this.rbOk.Size = new System.Drawing.Size(41, 19);
            this.rbOk.TabIndex = 0;
            this.rbOk.TabStop = true;
            this.rbOk.Text = "OK";
            this.rbOk.UseVisualStyleBackColor = true;
            // 
            // tbRemarks
            // 
            this.tbRemarks.Location = new System.Drawing.Point(168, 539);
            this.tbRemarks.Name = "tbRemarks";
            this.tbRemarks.Size = new System.Drawing.Size(100, 23);
            this.tbRemarks.TabIndex = 7;
            // 
            // lblRemarks
            // 
            this.lblRemarks.AutoSize = true;
            this.lblRemarks.Location = new System.Drawing.Point(113, 542);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.Size = new System.Drawing.Size(40, 15);
            this.lblRemarks.TabIndex = 6;
            this.lblRemarks.Text = "Uwagi";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(581, 541);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Zapisz";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // gbMosData
            // 
            this.gbMosData.Controls.Add(this.tbSerialNo);
            this.gbMosData.Controls.Add(this.lblSerialNo);
            this.gbMosData.Controls.Add(this.tbBatchNo);
            this.gbMosData.Controls.Add(this.lblBatchNo);
            this.gbMosData.Controls.Add(this.tbOrderNo);
            this.gbMosData.Controls.Add(this.lblOrderNo);
            this.gbMosData.Location = new System.Drawing.Point(438, 29);
            this.gbMosData.Name = "gbMosData";
            this.gbMosData.Size = new System.Drawing.Size(230, 129);
            this.gbMosData.TabIndex = 9;
            this.gbMosData.TabStop = false;
            this.gbMosData.Text = "Dane z przewodnika";
            // 
            // tbSerialNo
            // 
            this.tbSerialNo.Location = new System.Drawing.Point(102, 98);
            this.tbSerialNo.Name = "tbSerialNo";
            this.tbSerialNo.Size = new System.Drawing.Size(100, 23);
            this.tbSerialNo.TabIndex = 5;
            // 
            // lblSerialNo
            // 
            this.lblSerialNo.AutoSize = true;
            this.lblSerialNo.Location = new System.Drawing.Point(10, 101);
            this.lblSerialNo.Name = "lblSerialNo";
            this.lblSerialNo.Size = new System.Drawing.Size(53, 15);
            this.lblSerialNo.TabIndex = 4;
            this.lblSerialNo.Text = "Nr sztuki";
            // 
            // tbBatchNo
            // 
            this.tbBatchNo.Location = new System.Drawing.Point(102, 62);
            this.tbBatchNo.Name = "tbBatchNo";
            this.tbBatchNo.Size = new System.Drawing.Size(100, 23);
            this.tbBatchNo.TabIndex = 3;
            // 
            // lblBatchNo
            // 
            this.lblBatchNo.AutoSize = true;
            this.lblBatchNo.Location = new System.Drawing.Point(10, 65);
            this.lblBatchNo.Name = "lblBatchNo";
            this.lblBatchNo.Size = new System.Drawing.Size(44, 15);
            this.lblBatchNo.TabIndex = 2;
            this.lblBatchNo.Text = "Nr serii";
            // 
            // tbOrderNo
            // 
            this.tbOrderNo.Location = new System.Drawing.Point(102, 23);
            this.tbOrderNo.Name = "tbOrderNo";
            this.tbOrderNo.Size = new System.Drawing.Size(100, 23);
            this.tbOrderNo.TabIndex = 1;
            // 
            // lblOrderNo
            // 
            this.lblOrderNo.AutoSize = true;
            this.lblOrderNo.Location = new System.Drawing.Point(10, 26);
            this.lblOrderNo.Name = "lblOrderNo";
            this.lblOrderNo.Size = new System.Drawing.Size(86, 15);
            this.lblOrderNo.TabIndex = 0;
            this.lblOrderNo.Text = "Nr zamówienia";
            // 
            // AddShimInspectionReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 651);
            this.Controls.Add(this.gbMosData);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbRemarks);
            this.Controls.Add(this.lblRemarks);
            this.Controls.Add(this.gbSurface);
            this.Controls.Add(this.gbChoosePart);
            this.Controls.Add(this.gbResults);
            this.Controls.Add(this.gbValues);
            this.Name = "AddShimInspectionReportForm";
            this.Text = "Karta pomiarowa";
            this.Load += new System.EventHandler(this.ShimInspectionForm_Load);
            this.gbValues.ResumeLayout(false);
            this.gbValues.PerformLayout();
            this.gbResults.ResumeLayout(false);
            this.gbResults.PerformLayout();
            this.gbChoosePart.ResumeLayout(false);
            this.gbChoosePart.PerformLayout();
            this.gbSurface.ResumeLayout(false);
            this.gbSurface.PerformLayout();
            this.gbMosData.ResumeLayout(false);
            this.gbMosData.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox gbValues;
        private TextBox tbValue1;
        private Label lblMeasurement1;
        private TextBox tbValue4;
        private Label lblMeasurement4;
        private TextBox tbValue3;
        private TextBox tbValue2;
        private Label lblMeasurement3;
        private Label lblMeasurement2;
        private GroupBox gbResults;
        private TextBox tbDifferenceMaxMin;
        private Label lblDifferenceMaxMin;
        private TextBox tbAverage;
        private Label lblAverage;
        private GroupBox gbChoosePart;
        private ComboBox cbPartType;
        private Label lblPartType;
        private ComboBox cbPartNo;
        private Label lblPartNo;
        private GroupBox gbSurface;
        private RadioButton rbNok;
        private RadioButton rbOk;
        private TextBox tbRemarks;
        private Label lblRemarks;
        private Button btnSave;
        private GroupBox gbMosData;
        private TextBox tbSerialNo;
        private Label lblSerialNo;
        private TextBox tbBatchNo;
        private Label lblBatchNo;
        private TextBox tbOrderNo;
        private Label lblOrderNo;
        private Label lblTolerance;
    }
}