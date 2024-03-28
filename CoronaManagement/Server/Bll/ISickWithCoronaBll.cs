using Dto;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Dal.SickWithCoronaDal;

namespace Bll
{
    public interface ISickWithCoronaBll
    {
        public List<SickWithCoronaTblDto> GetSickWithCoronaAllAsync();
        public List<SickWithCoronaTblDto> AddSickWithCoronaAsync(SickWithCoronaTblDto sickwithcorona);
        public void UpdateSickWithCorona(int id, SickWithCoronaTblDto sickwithcorona);
        public void DeleteSickWithCorona(int id);
        public SickWithCoronaTblDto getCoronaDate(int UserId);
    }
}
