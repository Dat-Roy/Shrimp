using ShrimpPond.Application.Interface.Generic;
using ShrimpPond.Persistant.DatabaseContext;
using ShrimpPond.Application.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShrimpPond.Persistant.Repository.Abstract
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ShrimpPondDbContext _context;

        public UnitOfWork(ShrimpPondDbContext context) {
            _context = context;
            FarmRepository = new FarmRepository(_context);
            AlarmRepository = new AlarmRepository(_context);
        }
        public IAlarmRepository AlarmRepository {  get; private set; }
        public IFarmRepository FarmRepository { get; private set; }

    }
}
