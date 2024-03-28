using Microsoft.AspNetCore.Mvc;
using Dto;
using Bll;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using System.IO;
using System.Threading.Tasks;


namespace ManagementOfCoronaPatients.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        IUserBll userBll;
        public UserController(IUserBll _userBll)
        {
            this.userBll = _userBll;
        }

        [HttpGet]
        public List<UserTblDto> Get()
        {
            return userBll.GetUserAllAsync();
        }

        [HttpGet("{identityCard}")]
        public UserTblDto Get(string identityCard)
        {
            return userBll.GetUserById(identityCard);
        }

        
        [HttpPut]
        public void put([FromBody] UserTblDto user)
        {
            userBll.AddUserAsync(user);
        }

        [HttpPost()]
        public UserTblDto Post([FromBody] UserTblDto value)
        {
            return userBll.UpdateUser(value);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            userBll.DeleteUser(id);
        }

        [HttpPost("{UserId}")]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> UploadUserPhoto(string UserId, [FromForm] IFormFile PhotoData)
        {
            if (PhotoData == null || PhotoData.Length == 0)
                return BadRequest("Photo data is required.");

            // Convert the uploaded photo data to a byte array
            using (var memoryStream = new MemoryStream())
            {
                await PhotoData.CopyToAsync(memoryStream);
                var bytes = memoryStream.ToArray();
                userBll.UploadUserPhoto(UserId, bytes);
            }

            return Ok();
        }
    }
}