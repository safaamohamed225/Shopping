using Microsoft.EntityFrameworkCore;
using Shopping.Web.Models;

namespace Shopping.Web.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
    {
        //public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        //{

        //}
        public required DbSet<Category> categories { get; set; }
    }
}
