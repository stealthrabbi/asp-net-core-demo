using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AspNetMvcTestApp.Models
{
    public class AspNetMvcTestAppContext : DbContext
    {
        public AspNetMvcTestAppContext (DbContextOptions<AspNetMvcTestAppContext> options)
            : base(options)
        {
        }

        public DbSet<AspNetMvcTestApp.Models.Movie> Movie { get; set; }
    }
}
