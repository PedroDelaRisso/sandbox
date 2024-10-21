using Microsoft.EntityFrameworkCore;
using GesFin.Domain.Models.User;

namespace GesFin.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<User> Users { get; set; }
}
