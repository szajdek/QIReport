using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.Reporting.WinForms;
using QIReport.Helpers;
using QualityShims.ReportDto;
using QualityShims.ViewModel;
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
    public partial class LoadInspectionReportForm : Form
    {
        private readonly ShimInspectionReportDto _report;

        public LoadInspectionReportForm(ShimInspectionReportDto report)
        {
            InitializeComponent();
            _report = report;
        }

        private void LoadInspectionReportForm_Load(object sender, EventArgs e)
        {
            //ReportDatasourceHelper.CreateXsd();
            reportViewer1.LocalReport.ReportEmbeddedResource = "QIReport.Reports.ShimInspectionReport.rdlc";
            ReportParameter[] parameters = new ReportParameter[]
            {
                new ReportParameter("pReportNo", _report.Id)
            };
            reportViewer1.LocalReport.SetParameters(parameters);
            var dimensions = _report.Dimensions;
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsDimension", dimensions));
            reportViewer1.RefreshReport();
        }
    }
}
