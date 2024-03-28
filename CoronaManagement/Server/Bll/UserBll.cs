using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dto;
using Dal;
using Entity;
using AutoMapper;
namespace Bll
{
    public class UserBll : IUserBll
    {
        IUserDal _userDal;
        private readonly IMapper _mapper;
        public UserBll(IUserDal userDal, IMapper mapper)
        {
            this._userDal = userDal;
            _mapper = mapper;
        }
        public List<UserTblDto> AddUserAsync(UserTblDto user)
        {
            this._userDal.AddUserAsync(_mapper.Map<UserTbl>(user));
            return GetUserAllAsync();

        }

        public void DeleteUser(int id)
        {
            this._userDal.DeleteUser(id);
        }

        public List<UserTblDto> GetUserAllAsync()
        {
            return _mapper.Map<List<UserTblDto>>(this._userDal.GetUserAllAsync());
        }

        public UserTblDto GetUserById(string id)
        {
            return _mapper.Map<UserTblDto>(this._userDal.GetUserById(id));
        }

        public UserTblDto UpdateUser( UserTblDto user)
        {
            this._userDal.UpdateUser(_mapper.Map<UserTbl>(user));
            return _mapper.Map<UserTblDto>(this._userDal.GetUserById(user.IdentityCard));
        }

        public void UploadUserPhoto(string UserId, byte[] PhotoData)
        {
            _userDal.UploadUserPhoto(UserId, PhotoData);
        }

    }
}
