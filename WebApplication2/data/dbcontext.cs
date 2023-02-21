using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;
namespace WebApplication2.data
{
    public class dbcontext:DbContext
    {
        public dbcontext(DbContextOptions<dbcontext> options) : base(options)
        {

        }
        public DbSet<chartr> charttdb { get; set; }
    }
}
