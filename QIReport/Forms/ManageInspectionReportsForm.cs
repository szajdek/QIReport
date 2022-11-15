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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QualityShims.Forms
{
    public partial class ManageInspectionReportsForm : Form
    {
        private ApplicationDbContext _context = new ApplicationDbContext();

        public ManageInspectionReportsForm()
        {
            InitializeComponent();
        }

        private void PopulateDgv()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateProjection<InspectionReport, ShimInspectionReportViewModel>()
            .ForMember(dest => dest.PartType, opt => opt.MapFrom(src => src.Part.PartType.Name))
            .ForMember(dest => dest.PartNo, opt => opt.MapFrom(src => src.Part.PartNo))
            .ForMember(dest => dest.Inspector, opt => opt.MapFrom(src => src.User.FirstName + " " + src.User.LastName)));
            //config.AssertConfigurationIsValid();
            var reportsViewModel = _context.InspectionReports.ProjectTo<ShimInspectionReportViewModel>(config).OrderByDescending(x => x.Id).ToList();
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
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateProjection<ShimInspectionReport, ShimInspectionReportDto>()
                .ForMember(dest => dest.PartNo, opt => opt.MapFrom(src => src.Part.PartNo))
                .ForMember(dest => dest.PartName, opt => opt.MapFrom(src => src.Part.PartName))
                .ForMember(dest => dest.Inspector, opt => opt.MapFrom(src => src.User.FirstName + " " + src.User.LastName))
                .ForMember(dest => dest.Dimensions, opt => opt.MapFrom(src => src.ActualDimensions));
                cfg.CreateProjection<ActualDimension, DimensionDto>()
                .ForMember(dest => dest.BalloonNo, opt => opt.MapFrom(src => src.NominalDimension.BalloonNo))
                .ForMember(dest => dest.NominalValue, opt => opt.MapFrom(src => src.NominalDimension.NominalValue))
                .ForMember(dest => dest.UpperDeviation, opt => opt.MapFrom(src => src.NominalDimension.UpperDeviation))
                .ForMember(dest => dest.LowerDeviation, opt => opt.MapFrom(src => src.NominalDimension.LowerDeviation));
            });
            //config.AssertConfigurationIsValid();
            var reportDto = _context.ShimInspectionReports.ProjectTo<ShimInspectionReportDto>(config).FirstOrDefault();
            ShowReport(reportDto);
        }
    }
}
