using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dto;

namespace Bll
{
    public interface IVaccineManufacturerBll 
    {
        public List<VaccineManufacturerTblDto> GetVaccineManufacturerAllAsync();
        public List<VaccineManufacturerTblDto> AddVaccineManufacturerAsync(VaccineManufacturerTblDto vaccinemanufacturer);
        public void UpdateVaccineManufacturer(int id, VaccineManufacturerTblDto vaccinemanufacturer);
        public void DeleteVaccineManufacturer(int id);
        public VaccineManufacturerTblDto GetVaccineManufacturerById(int id);
    }
}
