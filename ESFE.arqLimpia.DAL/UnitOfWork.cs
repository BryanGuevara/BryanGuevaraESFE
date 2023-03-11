using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ESFE.arqLimpia.EN.Interfaces;

namespace ESFE.arqLimpia.DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        readonly ESFEDbContext dbContext;
        public UnitOfWork(ESFEDbContext pDbContext)
        {
            dbContext = pDbContext;
        }
        public Task<int> SaveChangesAsync()
        {
            return dbContext.SaveChangesAsync();
        }
    }
}
