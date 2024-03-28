using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;


namespace Dal
{
    public interface IUserDal
    {
        public List<UserTbl> GetUserAllAsync();
        public List<UserTbl> AddUserAsync(UserTbl user);
        public UserTbl UpdateUser(UserTbl user);
        public void DeleteUser(int id);
        public UserTbl GetUserById(string id);
        public void UploadUserPhoto(string UserId, byte[] PhotoData);

    }

    
}
