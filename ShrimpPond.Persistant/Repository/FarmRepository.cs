using ShrimpPond.Application.Interface;
using ShrimpPond.Domain.Farm;
using ShrimpPond.Persistant.DatabaseContext;
using ShrimpPond.Persistant.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShrimpPond.Persistant.Repository
{
    public class FarmRepository : RepositoryBase<Farm>, IFarmRepository
    {
        public FarmRepository(ShrimpPondDbContext context) : base(context) { }
    }
}
