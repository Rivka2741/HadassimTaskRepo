using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Dal;
using Dto;
using Entity;

namespace Bll 
{
    public class VaccineManufacturerBll : IVaccineManufacturerBll
    {
        IVaccineManufacturerDal _vaccinemanufacturerDal;
        private readonly IMapper _mapper;
        public VaccineManufacturerBll(IVaccineManufacturerDal vaccinemanufacturerDal, IMapper mapper)
        {
            this._vaccinemanufacturerDal = vaccinemanufacturerDal;
            _mapper = mapper;
        }
        public List<VaccineManufacturerTblDto> AddVaccineManufacturerAsync(VaccineManufacturerTblDto vaccinemanufacturer)
        {
            this._vaccinemanufacturerDal.AddVaccineManufacturerAsync(_mapper.Map<VaccineManufacturerTbl>(vaccinemanufacturer));
            return GetVaccineManufacturerAllAsync();

        }

        public void DeleteVaccineManufacturer(int id)
        {
            this._vaccinemanufacturerDal.DeleteVaccineManufacturer(id);
        }

        public List<VaccineManufacturerTblDto> GetVaccineManufacturerAllAsync()
        {
            return _mapper.Map<List<VaccineManufacturerTblDto>>(this._vaccinemanufacturerDal.GetVaccineManufacturerAllAsync());
        }

        public VaccineManufacturerTblDto GetVaccineManufacturerById(int id)
        {
            return _mapper.Map<VaccineManufacturerTblDto>(this._vaccinemanufacturerDal.GetVaccineManufacturerById(id));
        }

        public void UpdateVaccineManufacturer(int id, VaccineManufacturerTblDto vaccinemanufacturer)
        {
            this._vaccinemanufacturerDal.UpdateVaccineManufacturer(id, _mapper.Map<VaccineManufacturerTbl>(vaccinemanufacturer));
        }
    }
}
