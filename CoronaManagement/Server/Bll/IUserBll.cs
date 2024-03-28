using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dto;
namespace Bll
{
    public interface IUserBll
    {
        public List<UserTblDto> GetUserAllAsync();
        public List<UserTblDto> AddUserAsync(UserTblDto user);
        public UserTblDto UpdateUser(UserTblDto user);
        public void DeleteUser(int id);
        public UserTblDto GetUserById(string id);
        public void UploadUserPhoto(string UserId, byte[] PhotoData);
    }
}
