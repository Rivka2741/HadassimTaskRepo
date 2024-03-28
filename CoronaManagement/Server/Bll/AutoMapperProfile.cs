using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Dto;

namespace Bll
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<UserTblDto, UserTbl>();
            CreateMap<UserTbl, UserTblDto>();
            CreateMap<SickWithCoronaTblDto, SickWithCoronaTbl>();
            CreateMap<SickWithCoronaTbl, SickWithCoronaTblDto>();
            CreateMap<VaccinationDetailTblDto, VaccinationDetailTbl>();
            CreateMap<VaccinationDetailTbl, VaccinationDetailTblDto>();
            CreateMap<VaccineManufacturerTblDto, VaccineManufacturerTbl>();
            CreateMap<VaccineManufacturerTbl, VaccineManufacturerTblDto>();


        }
    }
}
