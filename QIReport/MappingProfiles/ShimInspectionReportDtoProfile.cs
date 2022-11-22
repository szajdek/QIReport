using AutoMapper;
using QualityShims.Model;
using QualityShims.ReportDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QIReport.MappingProfiles
{
    public class ShimInspectionReportDtoProfile : Profile
    {
        public ShimInspectionReportDtoProfile()
        {
            CreateProjection<ShimInspectionReport, ShimInspectionReportDto>()
                .ForMember(dest => dest.PartNo, opt => opt.MapFrom(src => src.Part.PartNo))
                .ForMember(dest => dest.PartName, opt => opt.MapFrom(src => src.Part.PartName))
                .ForMember(dest => dest.Inspector, opt => opt.MapFrom(src => src.User.FirstName + " " + src.User.LastName))
                .ForMember(dest => dest.Dimensions, opt => opt.MapFrom(src => src.ActualDimensions));
            CreateProjection<ActualDimension, DimensionDto>()
                .ForMember(dest => dest.BalloonNo, opt => opt.MapFrom(src => src.NominalDimension.BalloonNo))
                .ForMember(dest => dest.NominalValue, opt => opt.MapFrom(src => src.NominalDimension.NominalValue))
                .ForMember(dest => dest.UpperDeviation, opt => opt.MapFrom(src => src.NominalDimension.UpperDeviation))
                .ForMember(dest => dest.LowerDeviation, opt => opt.MapFrom(src => src.NominalDimension.LowerDeviation));
        }
    }
}
