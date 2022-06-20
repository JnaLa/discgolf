using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiscGolfapp.Models
{
    public class DiscgolfDBContext:DbContext
    {
        public DiscgolfDBContext(DbContextOptions<DiscgolfDBContext> options):base(options)
        {

        }

        public DbSet<DgUser> DgUsers { get; set; }
    }
}
