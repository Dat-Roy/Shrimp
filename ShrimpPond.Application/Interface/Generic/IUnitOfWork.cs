using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShrimpPond.Application.Interface.Generic
{
    public interface IUnitOfWork
    {
        public IAlarmRepository AlarmRepository { get; }
        public IFarmRepository FarmRepository { get; }
    }
}
