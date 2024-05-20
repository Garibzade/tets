
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Data;
using WebApplication1.Models;

namespace Anyar.DataAccesLayer
{
    public class SperingsContext : IdentityDbContext
    {
        public SperingsContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
       

    }
}
