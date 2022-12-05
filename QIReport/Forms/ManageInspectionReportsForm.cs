﻿using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using QIReport.Reporting;
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
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        private readonly IReportService _reportService;

        public ManageInspectionReportsForm(ApplicationDbContext context, IMapper mapper, IReportService reportService)
        {
            InitializeComponent();
            _context = context;
            //mapper.ConfigurationProvider.AssertConfigurationIsValid();
            _mapper = mapper;
            _reportService = reportService;
        }

        private void PopulateDgv()
        {
            var reportsViewModel = _context.InspectionReports.ProjectTo<ShimInspectionReportViewModel>(_mapper.ConfigurationProvider).OrderByDescending(x => x.Id).ToList();
            bsShimInspectionReportViewModel.DataSource = reportsViewModel;
        }

        private void ShowReport(ShimInspectionReportDto reportDto)
        {
            _reportService.ShowReport(reportDto);
        }

        private void ManageInspectionReportsForm_Load(object sender, EventArgs e)
        {
            PopulateDgv();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            int inspectionReportId = Convert.ToInt32(dgvInspectionReports.CurrentRow.Cells[0].Value);
            var reportDto = _context.ShimInspectionReports.Where(x => x.Id == inspectionReportId).ProjectTo<ShimInspectionReportDto>(_mapper.ConfigurationProvider).FirstOrDefault();
            if (reportDto != null)
            {
                ShowReport(reportDto);
            }
        }
    }
}
