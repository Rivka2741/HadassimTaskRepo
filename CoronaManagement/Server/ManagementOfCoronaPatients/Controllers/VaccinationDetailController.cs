using Bll;
using Dto;
using Microsoft.AspNetCore.Mvc;

namespace ManagementOfCoronaPatients.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VaccinationDetailController : ControllerBase
    {    
        IVaccinationDetailBll vaccinationdetailBll;
        public VaccinationDetailController(IVaccinationDetailBll _vaccinationdetailBll)
        {
            this.vaccinationdetailBll = _vaccinationdetailBll;
        }
        [HttpGet]
        public List<VaccinationDetailTblDto> Get()
        {
            return vaccinationdetailBll.GetVaccinationDetailAllAsync();
        }

        [HttpGet("{UserId}")]
        public List<VaccinationDetailTblDto> Get(int UserId)
        {
            return vaccinationdetailBll.getUserVaccination(UserId);
        }

        [HttpPut]
        public void Put([FromBody] VaccinationDetailTblDto value)
        {
            vaccinationdetailBll.AddVaccinationDetailAsync(value);
        }

        [HttpPost("{id}")]
        public void Post(int id, [FromBody] VaccinationDetailTblDto value)
        {
            vaccinationdetailBll.UpdateVaccinationDetail(id, value);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            vaccinationdetailBll.DeleteVaccinationDetail(id);
        }
    }
}
