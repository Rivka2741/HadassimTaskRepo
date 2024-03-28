using AutoMapper;
using Dal;
using Dto;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll
{
    public class VaccinationDetailBll : IVaccinationDetailBll
    {
        IVaccinationDetailDal _vaccinationdetailDal;
        private readonly IMapper _mapper;
        public VaccinationDetailBll(IVaccinationDetailDal vaccinationdetailDal, IMapper mapper)
        {
            this._vaccinationdetailDal = vaccinationdetailDal;
            _mapper = mapper;
        }
        public List<VaccinationDetailTblDto> AddVaccinationDetailAsync(VaccinationDetailTblDto vaccinationdetail)
        {
            this._vaccinationdetailDal.AddVaccinationDetailAsync(_mapper.Map<VaccinationDetailTbl>(vaccinationdetail));
            return GetVaccinationDetailAllAsync();

        }

        public void DeleteVaccinationDetail(int id)
        {
            this._vaccinationdetailDal.DeleteVaccinationDetail(id);
        }

        public List<VaccinationDetailTblDto> GetVaccinationDetailAllAsync()
        {
            return _mapper.Map<List<VaccinationDetailTblDto>>(this._vaccinationdetailDal.GetVaccinationDetailAllAsync());
        }

        public List<VaccinationDetailTblDto> getUserVaccination(int UserId)
        {
            return _mapper.Map<List<VaccinationDetailTblDto>>(this._vaccinationdetailDal.getUserVaccination(UserId));
        }

        public void UpdateVaccinationDetail(int id, VaccinationDetailTblDto vaccinationdetail)
        {
            this._vaccinationdetailDal.UpdateVaccinationDetail(id, _mapper.Map<VaccinationDetailTbl>(vaccinationdetail));
        }

    }
}
