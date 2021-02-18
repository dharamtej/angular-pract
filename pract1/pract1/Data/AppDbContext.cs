using Microsoft.EntityFrameworkCore;
using pract1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pract1.Data
{
    public class AppDbContext : DbContext

    {
        public AppDbContext( DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<People>peoples { get; set; }
    }
}
