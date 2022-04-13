using JopSelectData.Models;
using Microsoft.EntityFrameworkCore;

namespace JopSelectData;

public class SqlLiteDbContext : DbContext
{
    public DbSet<Address> Addresses { get; set; } = null;
    public DbSet<City> Cities { get; set; } = null;
    public DbSet<Country> Countries { get; set; } = null;
    public DbSet<User> Users { get; set; } = null;
    public DbSet<Branche> Branches { get; set; }
    public DbSet<CarLicense> CarLicenses { get; set; }
    public DbSet<Company> Companies { get; set; }
    public DbSet<Experiance> Experiances { get; set; }
    public DbSet<Favorite> Favorites { get; set; }

    public DbSet<Reaction> Reactions { get; set; }


    public DbSet<Resume> Resumes { get; set; }
    public DbSet<Skill> Skills { get; set; }
    public DbSet<SkillScore> SkillScores { get; set; }
    public DbSet<Vacancy> Vacancies { get; set; }

    public string DbPath { get; set; }

    public SqlLiteDbContext(DbContextOptions options) : base(options)
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        DbPath = System.IO.Path.Join(path, "jop-select-database.db");
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options) =>
        options.UseSqlite($"Data Source={DbPath}");
}