
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Persistance.Tests
{
    public class InMemoryDbContext : ApplicationDbContext
    {
        public InMemoryDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

      
        public override void Dispose()
        {
            Database.EnsureDeleted();
            base.Dispose();
        }
    }
}
