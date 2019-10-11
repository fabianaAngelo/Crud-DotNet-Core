using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CrudDotNetCore.Models
{
    public class CrudDotNetCoreContext : DbContext
    {
        public CrudDotNetCoreContext (DbContextOptions<CrudDotNetCoreContext> options)
            : base(options)
        {
        }

        public DbSet<CrudDotNetCore.Models.Movie> Movie { get; set; }
    }
}
