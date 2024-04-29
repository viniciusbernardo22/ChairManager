using ChairManager.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ChairManager.API.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    
    public DbSet<Chair> Chairs { get; set; }
    public DbSet<Allocation> Allocations { get; set; }
    
}