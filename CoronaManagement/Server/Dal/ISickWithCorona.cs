using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace Dal
{
    public interface ISickWithCoronaDal
    {
        public List<SickWithCoronaTbl> GetSickWithCoronaAllAsync();
        public List<SickWithCoronaTbl> AddSickWithCoronaAsync(SickWithCoronaTbl user);
        public void UpdateSickWithCorona(int UserId, SickWithCoronaTbl user);
        public void DeleteSickWithCorona(int UserId);
        public SickWithCoronaTbl getCoronaDate(int UserId);
    }
}
