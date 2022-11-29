using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Task6.Models;

namespace Task6.Data;

public sealed class ApplicationDbContext : IdentityDbContext<User>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
        Database.EnsureCreated();
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    => optionsBuilder.UseSqlServer("Data Source=SQL5105.site4now.net;Initial Catalog=db_a90967_task5;User Id=db_a90967_task5_admin;Password=z123456789", x => x.MigrationsHistoryTable("__MyMigrationsHistoryForDBContextA", "mySchema"));
}