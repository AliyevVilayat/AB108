using AcademyManagementEFProject.Helper;
using AcademyManagementEFProject.Models;
using Microsoft.EntityFrameworkCore;

namespace AcademyManagementEFProject.Contexts;

public class AcademyManagementDbContext : DbContext
{
    public DbSet<Student> Students { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(SqlHelper.GetMsSqlConnectionStr());
        base.OnConfiguring(optionsBuilder);
    }
}
