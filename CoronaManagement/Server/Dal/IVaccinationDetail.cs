using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;


namespace Dal
{
    public interface IVaccinationDetailDal
    {
        public List<VaccinationDetailTbl> GetVaccinationDetailAllAsync();
        public List<VaccinationDetailTbl> AddVaccinationDetailAsync(VaccinationDetailTbl vaccinationdetail);
        public void UpdateVaccinationDetail(int id, VaccinationDetailTbl vaccinationdetail);
        public void DeleteVaccinationDetail(int id);
        public List<VaccinationDetailTbl> getUserVaccination(int UserId);
    }
}
