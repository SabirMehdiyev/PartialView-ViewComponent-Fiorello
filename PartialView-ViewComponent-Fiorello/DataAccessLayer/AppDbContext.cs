using Microsoft.EntityFrameworkCore;
using PartialView_ViewComponent_Fiorello.DataAccessLayer.Entities;

namespace PartialView_ViewComponent_Fiorello.DataAccessLayer;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
    }
    public DbSet<Product> Products { get; set; }
    public DbSet<Footer> Footers { get; set; }
    public DbSet<Header> Headers { get; set; }
}
