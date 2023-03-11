using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ESFE.arqLimpia.Ne;
using Microsoft.EntityFrameworkCore;

namespace ESFE.arqLimpia.DAL
{
    public class ESFEDbContext : DbContext
    {
        public ESFEDbContext(DbContextOptions<ESFEDbContext> options) : base(options) { }
        public DbSet<User> User { get; set; }
    }
}
