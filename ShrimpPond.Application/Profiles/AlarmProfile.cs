using AutoMapper;
using ShrimpPond.Application.DTOs;
using ShrimpPond.Domain.Alarm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShrimpPond.Application.Profiles
{
    public class AlarmProfile : Profile
    {
        public AlarmProfile() {
            CreateMap<Alarm, AlarmDTO>();
        }
    }
}
