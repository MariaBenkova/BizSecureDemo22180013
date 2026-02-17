using System.Collections.Generic;
using BizSecureDemo22180013.Models;
using Microsoft.EntityFrameworkCore;
namespace BizSecureDemo22180013.Data;
public class AppDbContext : DbContext
{
    public DbSet<AppUser> Users => Set<AppUser>();
    public DbSet<Order> Orders => Set<Order>();
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
}

