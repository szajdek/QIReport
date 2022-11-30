using QualityShims.ReportDto;

namespace QIReport.Reporting
{
    public interface IReportService
    {
        void ShowReport(ShimInspectionReportDto reportDto);
    }
}