using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.Reporting.WinForms;
using QIReport.Helpers;
using QIReport.Reporting;
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
    public partial class InspectionReportViewerForm : Form
    {
        public InspectionReportViewerForm()
        {
            InitializeComponent();
        }

        private void InspectionReportViewerForm_Load(object sender, EventArgs e)
        {
            ReportService.Load(reportViewer1.LocalReport);
            reportViewer1.RefreshReport();
        }
    }
}
