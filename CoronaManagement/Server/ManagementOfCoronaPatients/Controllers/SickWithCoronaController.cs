using Bll;
using Dto;
using Entity;
using Microsoft.AspNetCore.Mvc;
using static Dal.SickWithCoronaDal;

namespace ManagementOfCoronaPatients.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SickWithCoronaController : ControllerBase
    {
        ISickWithCoronaBll sickwithcoronaBll;
        public SickWithCoronaController(ISickWithCoronaBll _sickwithcoronaBll)
        {
            this.sickwithcoronaBll = _sickwithcoronaBll;
        }
        [HttpGet]
        public List<SickWithCoronaTblDto> Get()
        {
            return sickwithcoronaBll.GetSickWithCoronaAllAsync();
        }


        [HttpGet("{UserId}")]
        public SickWithCoronaTblDto Get(int UserId)
        {
            return sickwithcoronaBll.getCoronaDate(UserId);
        }

        [HttpPut]
        public void Put([FromBody] SickWithCoronaTblDto value)
        {
            sickwithcoronaBll.AddSickWithCoronaAsync(value);
        }

        [HttpPost("{id}")]
        public void Post(int id, [FromBody] SickWithCoronaTblDto value)
        {
            sickwithcoronaBll.UpdateSickWithCorona(id, value);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            sickwithcoronaBll.DeleteSickWithCorona(id);
        }
    }
}
