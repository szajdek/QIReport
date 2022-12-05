using QIReport.Factories;
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
            var addShimInspectionReportForm = new FormFactory().CreateForm<AddShimInspectionReportForm>();
            addShimInspectionReportForm.ShowDialog();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            var manageInspectionReportsForm = new FormFactory().CreateForm<ManageInspectionReportsForm>();
            manageInspectionReportsForm.ShowDialog();
        }
    }
}