using MediatR;
using ShrimpPond.Application.DTOs;
using ShrimpPond.Domain.Farm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ShrimpPond.Application.Features.Alarm.Queries
{
    public class GetFarm : IRequest<FarmDTO>
    {
        public GetFarm(int id) {
            Id = id;
        }
        public int Id { get; set; }
    }
}
