using Microsoft.EntityFrameworkCore;
using QualityShims.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QualityShims.Forms
{
    public partial class AddShimInspectionReportForm : Form
    {
        private ApplicationDbContext _context = new ApplicationDbContext();
        private ShimInspectionReport _report = new ShimInspectionReport();
        private Dictionary<TextBox, ActualDimension> _dimensions;

        public AddShimInspectionReportForm()
        {
            InitializeComponent();
        }

        private void PopulateCbPartType()
        {
            var partTypes = _context.PartTypes.ToList();
            cbPartType.DataSource = partTypes;
            cbPartType.DisplayMember = "Name";
            cbPartType.ValueMember = "Id";
        }

        private void PopulateCbPartNo()
        {
            cbPartNo.ResetText();
            int partTypeId = Convert.ToInt32(cbPartType.SelectedValue);
            var parts = _context.Parts.Where(x => x.PartTypeId == partTypeId).ToList();
            cbPartNo.DataSource = parts;
            cbPartNo.DisplayMember = "PartNo";
            cbPartNo.ValueMember = "Id";
            cbPartNo.Enabled = true;
        }

        private void CreateTextBoxActualDimensionDictionary()
        {
            int partId = Convert.ToInt32(cbPartNo.SelectedValue);
            var part = _context.Parts.Find(partId);
            var nominal = _context.NominalDimensions.FirstOrDefault(x => x.PartId == partId);
            lblTolerance.Text = "<" + nominal.LowerLimit.ToString() + "..." + nominal.UpperLimit.ToString() + ">";
            lblTolerance.Visible = true;
            _report.Part = part;
            _dimensions = new Dictionary<TextBox, ActualDimension>();
            var textBoxes = gbValues.Controls.OfType<TextBox>().OrderBy(x => x.Name);
            foreach (var tb in textBoxes)
            {
                int balloonNo = Convert.ToInt32(tb.Name.Replace("tbValue", ""));
                var nominalDimension = _context.NominalDimensions.Single(x => x.PartId == partId && x.BalloonNo == balloonNo);
                var actualDimension = new ActualDimension { NominalDimension = nominalDimension };
                _dimensions.Add(tb, actualDimension);
            }
        }

        private void AddActualValueToDictionary(TextBox tb)
        {
            var actualDimension = _dimensions[tb];
            decimal value;
            if (!string.IsNullOrWhiteSpace(tb.Text))
            {
                if (decimal.TryParse(tb.Text, out value))
                {
                    actualDimension.ActualValue = value;
                    _dimensions[tb] = actualDimension;
                }
                else
                {
                    MessageBox.Show("Nieprawidłowa wartość");
                    tb.Clear();
                }
            }
            else
            {
                actualDimension.ActualValue = 0;
                _dimensions[tb] = actualDimension;
            }
        }

        private void ShowResults()
        {
            if (!_dimensions.Values.Any(x => x.ActualValue == 0))
            {
                _report.ActualDimensions = _dimensions.Values;
                tbAverage.Text = _report.AverageDimension.ToString();
                tbDifferenceMaxMin.Text = _report.DifferenceMaxMin.ToString();
            }
            else
            {
                tbAverage.Clear();
                tbDifferenceMaxMin.Clear();
            }
        }

        private void ValidateTextBox(TextBox tb)
        {
            if (!string.IsNullOrWhiteSpace(tb.Text))
            {
                tb.BackColor = _dimensions[tb].IsWithinTolerance ? Color.Green : Color.Red;
            }
            else
            {
                tb.BackColor = Color.Empty;
            }
        }

        private void Save()
        {
            _report.OrderNo = tbOrderNo.Text;
            _report.BatchNo = tbBatchNo.Text;
            _report.SerialNo = tbSerialNo.Text;
            _report.Date = DateTime.Now;
            _report.VisualInspectionStatus = rbOk.Checked;
            _report.Remarks = tbRemarks.Text;
            _report.UserId = LoggedUser.Id;
            _context.Attach(_report);
            _context.SaveChanges();
        }

        private void ShimInspectionForm_Load(object sender, EventArgs e)
        {
            PopulateCbPartType();
        }

        private void cbPartType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            PopulateCbPartNo();
            gbValues.Controls.OfType<TextBox>().ToList().ForEach(x => x.Clear());
            gbValues.Enabled = false;
            lblTolerance.Visible = false;
        }

        private void cbPartNo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CreateTextBoxActualDimensionDictionary();
            gbValues.Enabled = true;
            gbValues.Controls.OfType<TextBox>().ToList().ForEach(x => x.Clear());
        }

        private void tbValue_TextChanged(object sender, EventArgs e)
        {
            var tb = sender as TextBox;
            AddActualValueToDictionary(tb);
            ShowResults();
            ValidateTextBox(tb);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
            Close();
        }
    }
}
