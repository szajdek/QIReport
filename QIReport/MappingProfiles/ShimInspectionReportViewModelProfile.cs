using AutoMapper;
using QualityShims.Model;
using QualityShims.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QIReport.MappingProfiles
{
    public class ShimInspectionReportViewModelProfile : Profile
    {
        public ShimInspectionReportViewModelProfile()
        {
            CreateProjection<InspectionReport, ShimInspectionReportViewModel>()
                .ForMember(dest => dest.PartType, opt => opt.MapFrom(src => src.Part.PartType.Name))
                .ForMember(dest => dest.PartNo, opt => opt.MapFrom(src => src.Part.PartNo))
                .ForMember(dest => dest.Inspector, opt => opt.MapFrom(src => src.User.FirstName + " " + src.User.LastName));
        }
    }
}
