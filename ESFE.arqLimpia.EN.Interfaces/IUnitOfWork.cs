using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESFE.arqLimpia.EN.Interfaces
{
     public interface IUnitOfWork
    {
        Task<int> SaveChangesAsync();
    }
}
