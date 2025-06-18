using ShrimpPond.Application.Interface;
using ShrimpPond.Application.Interface.Generic;
using ShrimpPond.Domain.Alarm;
using ShrimpPond.Persistant.DatabaseContext;
using ShrimpPond.Persistant.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShrimpPond.Persistant.Repository
{
    public class AlarmRepository : RepositoryBase<Alarm>, IAlarmRepository
    {
        public AlarmRepository(ShrimpPondDbContext context): base(context) { }
    }
}
