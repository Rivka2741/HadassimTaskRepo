using Bll;
using Dto;
using Microsoft.AspNetCore.Mvc;

namespace ManagementOfCoronaPatients.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VaccineManufacturerController : ControllerBase
    {
        IVaccineManufacturerBll vaccinemanufacturerBll;
        public VaccineManufacturerController(IVaccineManufacturerBll _vaccinemanufacturerBll)
        {
            this.vaccinemanufacturerBll = _vaccinemanufacturerBll;
        }
        [HttpGet]
        public List<VaccineManufacturerTblDto> Get()
        {
            return vaccinemanufacturerBll.GetVaccineManufacturerAllAsync();
        }

        [HttpGet("{id}")]
        public VaccineManufacturerTblDto Get(int id)
        {
            return vaccinemanufacturerBll.GetVaccineManufacturerById(id);
        }

        [HttpPut]
        public void put([FromBody] VaccineManufacturerTblDto value)
        {
            vaccinemanufacturerBll.AddVaccineManufacturerAsync(value);
        }

        [HttpPost("{id}")]
        public void Post(int id, [FromBody] VaccineManufacturerTblDto value)
        {
            vaccinemanufacturerBll.UpdateVaccineManufacturer(id, value);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            vaccinemanufacturerBll.DeleteVaccineManufacturer(id);
        }
    }
}
