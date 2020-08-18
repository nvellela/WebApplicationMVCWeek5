using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationMVCW5._DAL.Models;

namespace WebApplicationMVCW5._DAL.Services
{
    public class DALContext : DbContext
    {
        public DALContext(DbContextOptions<DALContext> options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }

    }
}
