using AutoMapper;
using ShrimpPond.Application.DTOs;
using ShrimpPond.Domain.Farm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShrimpPond.Application.Profiles
{
    public class FarmProfile : Profile
    {
        public FarmProfile() {
            CreateMap<Farm, FarmDTO>();
        }
    }
}
