using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace Dal
{
    public class VaccinationDetailDal : IVaccinationDetailDal
    {
        
        CoronaManagementSystemContext _context;
        public VaccinationDetailDal(CoronaManagementSystemContext context)
        {
            this._context = context;
        }
        public List<VaccinationDetailTbl> AddVaccinationDetailAsync(VaccinationDetailTbl vaccinationdetail)
        {
            this._context.VaccinationDetails.AddAsync(vaccinationdetail);
            this._context.SaveChanges();
            return GetVaccinationDetailAllAsync();
        }

        public void DeleteVaccinationDetail(int id)
        {
            var cust = this._context.VaccinationDetails.First(x => x.VaccinationId == id);
            this._context.VaccinationDetails.Remove(cust);
            this._context.SaveChanges();
        }

        public List<VaccinationDetailTbl> GetVaccinationDetailAllAsync()
        {
            return this._context.VaccinationDetails.ToList();
        }

        public List<VaccinationDetailTbl> getUserVaccination(int UserId)
        {
            return this._context.VaccinationDetails.Where(x => x.UserId == UserId).ToList();
        }


        public void UpdateVaccinationDetail(int id, VaccinationDetailTbl vaccinationdetail)
        {
            var existingVaccinationDetail = this._context.VaccinationDetails.FirstOrDefault(x => x.VaccinationId == id);

            if (existingVaccinationDetail == null)
            {
                // Handle the case where the user is not found
                throw new ArgumentException("VaccinationDetail not found");
            }

            // Update the properties of the existing user entity
            existingVaccinationDetail.VaccinationId = vaccinationdetail.VaccinationId;
            existingVaccinationDetail.UserId = vaccinationdetail.UserId;
            existingVaccinationDetail.VaccineDate = vaccinationdetail.VaccineDate; // Update the City value
            existingVaccinationDetail.VaccineManufacturerId = vaccinationdetail.VaccineManufacturerId;
            //existingVaccinationDetail.User = vaccinationdetail.User;
            //existingVaccinationDetail.VaccineManufacturer = vaccinationdetail.VaccineManufacturer;
            

            // Save changes to the database
            this._context.SaveChanges();
        }
    }
}
