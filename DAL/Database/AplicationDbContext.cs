using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Database
{
    public class AplicationDbContext:DbContext
    {
        public AplicationDbContext(DbContextOptions options):base(options)
        {

        }
       
        public DbSet<player> players { get; set; }
        public DbSet<Teem> Teems { get; set; }
    }
}
