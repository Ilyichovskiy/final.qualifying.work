using ContactCenter.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ContactCenter.Domain;

public class AppDbContext : IdentityDbContext<IdentityUser>
{
    private readonly string _roleId;
    private readonly string _userId;

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        _roleId = Guid.NewGuid().ToString();
        _userId = Guid.NewGuid().ToString();
    }
    
    public DbSet<TextField>? TextFields { get; set; }
    public DbSet<ServiceItem>? ServiceItems { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
        {
            Id = _roleId,
            Name = "admin",
            NormalizedName = "ADMIN"
        });

        modelBuilder.Entity<IdentityUser>().HasData(new IdentityUser
        {
            Id = _userId,
            UserName = "admin",
            NormalizedUserName = "ADMIN",
            Email = "admin@email.com",
            NormalizedEmail = "ADMIN@email.com",
            EmailConfirmed = true,
            PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "admin"),
            SecurityStamp = string.Empty
        });

        modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
        {
            RoleId = _roleId,
            UserId = _userId
        });

        modelBuilder.Entity<TextField>().HasData(new TextField
        {
            Id = Guid.NewGuid(),
            CodeWord = "PageIndex",
            Title = "Главная"
        });
        
        modelBuilder.Entity<TextField>().HasData(new TextField
        {
            Id = Guid.NewGuid(),
            CodeWord = "PageServices",
            Title = "Сервисы"
        });
        
        modelBuilder.Entity<TextField>().HasData(new TextField
        {
            Id = Guid.NewGuid(),
            CodeWord = "PageContacts",
            Title = "Контакты"
        });
    }
}