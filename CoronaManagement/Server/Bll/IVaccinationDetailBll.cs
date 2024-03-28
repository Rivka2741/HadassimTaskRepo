using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dto;


namespace Bll
{
    public interface IVaccinationDetailBll
    {
        public List<VaccinationDetailTblDto> GetVaccinationDetailAllAsync();
        public List<VaccinationDetailTblDto> AddVaccinationDetailAsync(VaccinationDetailTblDto vaccinationdetail);
        public void UpdateVaccinationDetail(int id, VaccinationDetailTblDto vaccinationdetail);
        public void DeleteVaccinationDetail(int id);
        public List<VaccinationDetailTblDto> getUserVaccination(int UserId);
    }
}
