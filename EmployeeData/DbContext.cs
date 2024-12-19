//namespace EmployeeData
//{
//    public class DbContext
//    {
//    }
//}
using EmployeeData.Models;
using System.Collections.Generic;
//using System.Data.Entity;
using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext
{
    public DbSet<EmployeeModel> Employees{ get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }
}