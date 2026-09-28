using Microsoft.EntityFrameworkCore;
using StudentManagementCRUD.Models;

namespace StudentManagementCRUD.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<Student> Students { get; set; }
}