using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace Dal
{
    public class SickWithCoronaDal : ISickWithCoronaDal
    {
        CoronaManagementSystemContext _context;
        public SickWithCoronaDal(CoronaManagementSystemContext context)
        {
            this._context = context;
        }
        
        public List<SickWithCoronaTbl> AddSickWithCoronaAsync(SickWithCoronaTbl sickwithcorona)
        {
            this._context.SickWithCoronas.AddAsync(sickwithcorona);
            this._context.SaveChanges();
            return GetSickWithCoronaAllAsync();
        }

        public void DeleteSickWithCorona(int id)
        {
            var cust = this._context.SickWithCoronas.First(x => x.SickId == id);
            this._context.SickWithCoronas.Remove(cust);
            this._context.SaveChanges();
        }

        public List<SickWithCoronaTbl> GetSickWithCoronaAllAsync()
        {
            return this._context.SickWithCoronas.ToList();
        }


        public SickWithCoronaTbl getCoronaDate(int UserId)
        {
            return this._context.SickWithCoronas.FirstOrDefault(x => x.UserId == UserId);
        }

        
        public void UpdateSickWithCorona(int id, SickWithCoronaTbl sickwithcorona)
        {
            var existingSickWithCorona = this._context.SickWithCoronas.FirstOrDefault(x => x.UserId == id);

            if (existingSickWithCorona == null)
            {
                // Handle the case where the user is not found
                throw new ArgumentException("SickWithCorona not found");
            }

            // Update the properties of the existing user entity
            existingSickWithCorona.SickId = existingSickWithCorona.SickId;
            existingSickWithCorona.UserId = existingSickWithCorona.UserId;
            existingSickWithCorona.PositiveResultDate = existingSickWithCorona.PositiveResultDate; // Update the City value
            existingSickWithCorona.RecoveryDate = existingSickWithCorona.RecoveryDate;
            //existingSickWithCorona.User = existingSickWithCorona.User;
            

            // Save changes to the database
            this._context.SaveChanges();
        }

    }
}
