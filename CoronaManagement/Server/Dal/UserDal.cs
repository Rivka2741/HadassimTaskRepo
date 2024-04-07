using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using Entity;
 

namespace Dal
{
    public class UserDal : IUserDal
    {
        CoronaManagementSystemContext _context;
        public UserDal(CoronaManagementSystemContext context)
        {
            this._context = context;
        }
        public List<UserTbl> AddUserAsync(UserTbl user)
        {
            this._context.Users.AddAsync(user);
            this._context.SaveChanges();
            return GetUserAllAsync();
        }

        public void DeleteUser(int id)
        {
            var userVaccinations = this._context.VaccinationDetails.Where(x => x.UserId == id);
            foreach (var userVaccination in userVaccinations)
            {
                this._context.VaccinationDetails.Remove(userVaccination);
            }

            var userCoronaDate = this._context.SickWithCoronas.FirstOrDefault(x => x.UserId == id);
            if (userCoronaDate!=null)
            {
                this._context.SickWithCoronas.Remove(userCoronaDate);
            }
            

            var userToDelet = this._context.Users.First(x => x.UserId == id);
            this._context.Users.Remove(userToDelet);
            this._context.SaveChanges();


        }

        public List<UserTbl> GetUserAllAsync()
        {
            return this._context.Users.ToList();
        }

        public UserTbl GetUserById(string id)
        {
             return this._context.Users.First(x => x.IdentityCard == id);
        }

        
        public UserTbl UpdateUser(UserTbl user)
        {
            var existingUser = this._context.Users.FirstOrDefault(x => x.UserId == user.UserId);

            if (existingUser == null)
            {
                // Handle the case where the user is not found
                throw new ArgumentException("User not found");
            }

            // Update the properties of the existing user entity
            existingUser.FirstName = user.FirstName;
            existingUser.LastName = user.LastName; 
            existingUser.City = user.City; // Update the City value
            existingUser.Street = user.Street;
            existingUser.Number = user.Number;
            existingUser.DateOfBirth = user.DateOfBirth;
            existingUser.Phone = user.Phone;
            existingUser.CellPhone = user.CellPhone;
            existingUser.Photo = user.Photo;

            // Save changes to the database
            this._context.SaveChanges();

            return existingUser;
        }

        public void UploadUserPhoto(string UserId, byte[] PhotoData)
        {
            // Retrieve the user from the data access layer
            var user = this._context.Users.FirstOrDefault(x => x.IdentityCard == UserId);

            // Check if the user exists
            if (user != null)
            {
                user.Photo = PhotoData;
                this._context.SaveChanges();
            }
        }

    }


}
