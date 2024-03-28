using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace Dal
{
    public interface IVaccineManufacturerDal
    {
        public List<VaccineManufacturerTbl> GetVaccineManufacturerAllAsync();
        public List<VaccineManufacturerTbl> AddVaccineManufacturerAsync(VaccineManufacturerTbl vaccinemanufacturer);
        public void UpdateVaccineManufacturer(int id, VaccineManufacturerTbl vaccinemanufacturer);
        public void DeleteVaccineManufacturer(int id);
        public VaccineManufacturerTbl GetVaccineManufacturerById(int id); 
    }
}
