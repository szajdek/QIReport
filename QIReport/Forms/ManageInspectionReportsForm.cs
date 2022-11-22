using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using QualityShims.Model;
using QualityShims.ReportDto;
using QualityShims.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QualityShims.Forms
{
    public partial class ManageInspectionReportsForm : Form
    {
        private ApplicationDbContext _context;
        private IMapper _mapper;

        public ManageInspectionReportsForm()
        {
            InitializeComponent();
            _context = new ApplicationDbContext();
            var config = new MapperConfiguration(cfg => cfg.AddMaps(Assembly.GetExecutingAssembly()));
            //config.AssertConfigurationIsValid();
            _mapper = config.CreateMapper();
        }

        private void PopulateDgv()
        {
            var reportsViewModel = _context.InspectionReports.ProjectTo<ShimInspectionReportViewModel>(_mapper.ConfigurationProvider).OrderByDescending(x => x.Id).ToList();
            bsShimInspectionReportViewModel.DataSource = reportsViewModel;
        }

        private void ShowReport(ShimInspectionReportDto reportDto)
        {
            LoadInspectionReportForm loadInspectionReportForm = new LoadInspectionReportForm(reportDto);
            loadInspectionReportForm.Show();
        }

        private void ManageInspectionReportsForm_Load(object sender, EventArgs e)
        {
            PopulateDgv();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            var reportDto = _context.ShimInspectionReports.ProjectTo<ShimInspectionReportDto>(_mapper.ConfigurationProvider).FirstOrDefault();
            ShowReport(reportDto);
        }
    }
}
