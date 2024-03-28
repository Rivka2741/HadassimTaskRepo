using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;


namespace Dal
{
    public class VaccineManufacturerDal : IVaccineManufacturerDal
    {
        CoronaManagementSystemContext _context;
        public VaccineManufacturerDal(CoronaManagementSystemContext context)
        {
            this._context = context; 
        }
        public List<VaccineManufacturerTbl> AddVaccineManufacturerAsync(VaccineManufacturerTbl vaccinemanufacturer)
        {
            this._context.VaccineManufacturers.AddAsync(vaccinemanufacturer);
            this._context.SaveChanges();
            return GetVaccineManufacturerAllAsync();
        }

        public void DeleteVaccineManufacturer(int id)
        {
            var cust = this._context.VaccineManufacturers.First(x => x.ManufacturerId == id);
            this._context.VaccineManufacturers.Remove(cust);
            this._context.SaveChanges();
        }

        public List<VaccineManufacturerTbl> GetVaccineManufacturerAllAsync()
        {
            return this._context.VaccineManufacturers.ToList();
        }

        public VaccineManufacturerTbl GetVaccineManufacturerById(int id)
        {
            return this._context.VaccineManufacturers.First(x => x.ManufacturerId == id);
        }


        public void UpdateVaccineManufacturer(int id, VaccineManufacturerTbl vaccinemanufacturer)
        {
            var existingVaccineManufacturer = this._context.VaccineManufacturers.FirstOrDefault(x => x.ManufacturerId == id);

            if (existingVaccineManufacturer == null)
            {
                // Handle the case where the user is not found
                throw new ArgumentException("VaccineManufacturer not found");
            }

            // Update the properties of the existing user entity
            existingVaccineManufacturer.ManufacturerId = vaccinemanufacturer.ManufacturerId;
            existingVaccineManufacturer.ManufacturerName = vaccinemanufacturer.ManufacturerName;
           
            

            // Save changes to the database
            this._context.SaveChanges();
        }

    }
}
