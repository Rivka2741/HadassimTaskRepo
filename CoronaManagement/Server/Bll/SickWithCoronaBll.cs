using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dto;
using Dal;
using Entity;
using AutoMapper;
using static Dal.SickWithCoronaDal;

namespace Bll
{
    public class SickWithCoronaBll : ISickWithCoronaBll
    {
        
        ISickWithCoronaDal _sickwithcoronaDal;
        private readonly IMapper _mapper;
        public SickWithCoronaBll(ISickWithCoronaDal sickwithcoronaDal, IMapper mapper)
        {
            this._sickwithcoronaDal = sickwithcoronaDal;
            _mapper = mapper;
        }
        public List<SickWithCoronaTblDto> AddSickWithCoronaAsync(SickWithCoronaTblDto sickwithcorona)
        {
            this._sickwithcoronaDal.AddSickWithCoronaAsync(_mapper.Map<SickWithCoronaTbl>(sickwithcorona));
            return GetSickWithCoronaAllAsync();

        }

        public void DeleteSickWithCorona(int id)
        {
            this._sickwithcoronaDal.DeleteSickWithCorona(id);
        }

        public List<SickWithCoronaTblDto> GetSickWithCoronaAllAsync()
        {
            return _mapper.Map<List<SickWithCoronaTblDto>>(this._sickwithcoronaDal.GetSickWithCoronaAllAsync());
        }

        public SickWithCoronaTblDto getCoronaDate(int UserId)
        {
            return _mapper.Map<SickWithCoronaTblDto>(this._sickwithcoronaDal.getCoronaDate(UserId));
        }

        public void UpdateSickWithCorona(int id, SickWithCoronaTblDto sickwithcorona)
        {
            this._sickwithcoronaDal.UpdateSickWithCorona(id, _mapper.Map<SickWithCoronaTbl>(sickwithcorona));
        }


    }
}
