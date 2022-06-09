using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiscGolfapp.Data
{
    public class DgDbContext : DbContext
    {
        
        public DgDbContext(DbContextOptions<DgDbContext> options) : base(options)
        {

        }
    }

    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public int Score { get; set; }
    }
}
