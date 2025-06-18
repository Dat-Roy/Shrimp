using MediatR;
using ShrimpPond.Application.DTOs;
using ShrimpPond.Application.Interface.Generic;
using ShrimpPond.Domain.Farm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShrimpPond.Application.Features.Alarm.Queries
{
    public class GetFarmHandler : IRequestHandler<GetFarm, FarmDTO>
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetFarmHandler(IUnitOfWork unitWork) { 
            _unitOfWork = unitWork;
        }
        public async Task<FarmDTO> Handler(GetFarm request, CancellationToken cancellationToken)
        {
            var x = _unitOfWork.FarmRepository.FindAll();
            var data = new FarmDTO
            {
                Name = "HEHE",
                Address = "HIHI",
                Owner = "ME"
            };
            return data;
        }
    }
}
