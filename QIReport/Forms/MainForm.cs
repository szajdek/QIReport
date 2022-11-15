using QualityShims.Forms;

namespace QualityShims
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnMeasure_Click(object sender, EventArgs e)
        {
            AddShimInspectionReportForm addShimInspectionReportForm = new AddShimInspectionReportForm();
            addShimInspectionReportForm.ShowDialog();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            ManageInspectionReportsForm manageInspectionReportsForm = new ManageInspectionReportsForm();
            manageInspectionReportsForm.ShowDialog();
        }
    }
}