using Microsoft.Reporting.WinForms;
using QualityShims.Forms;
using QualityShims.ReportDto;

namespace QIReport.Reporting
{
    public class ReportService : IReportService
    {
        private static ShimInspectionReportDto _reportDto;

        public void ShowReport(ShimInspectionReportDto reportDto)
        {
            _reportDto = reportDto;
            InspectionReportViewerForm inspectionReportViewerForm = new InspectionReportViewerForm();
            inspectionReportViewerForm.Show();
        }

        public static void Load(LocalReport localReport)
        {
            //ReportDatasourceHelper.CreateXsd();
            localReport.ReportEmbeddedResource = "QIReport.Reporting.ReportDefinitions.ShimInspectionReport.rdlc";
            ReportParameter[] parameters = new ReportParameter[]
            {
                new ReportParameter("pReportNo", _reportDto.Id)
            };
            localReport.SetParameters(parameters);
            var dimensions = _reportDto.Dimensions;
            localReport.DataSources.Add(new ReportDataSource("dsDimension", dimensions));
        }
    }
}
