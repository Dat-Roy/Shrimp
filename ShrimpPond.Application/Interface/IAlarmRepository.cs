using ShrimpPond.Application.Interface.Generic;
using ShrimpPond.Domain.Alarm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShrimpPond.Application.Interface
{
    public interface IAlarmRepository : IRepositoryBase<Alarm>
    {
    }
}
