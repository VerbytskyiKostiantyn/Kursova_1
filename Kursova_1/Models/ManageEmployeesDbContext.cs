using Kursova_1.Models.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System.Reflection.Emit;
using System.Text.RegularExpressions;

namespace Kursova_1.Models
{
	public class ManageEmployeesDbContext : DbContext
	{
		public ManageEmployeesDbContext(DbContextOptions<ManageEmployeesDbContext> options) : base(options)
		{

		}

		public DbSet<Employee> Employees { get; set; }

		protected override void OnModelCreating(ModelBuilder builder)
		{
            builder.Entity<Employee>().HasData(
            new Employee { Id = 1, FirstName = "Андрій", LastName = "Романов", Position = "Адміністратор", Adress = "Київ вул. Шевченка 13", DateOfBirth = DateOnly.FromDateTime(new DateTime(1990, 1, 1)), DateOfEmployment = DateOnly.FromDateTime(new DateTime(2020, 1, 1)), Salary = 50000 },
            new Employee { Id = 2, FirstName = "Роман", LastName = "Денисенко", Position = "Дизайнер", Adress = "Київ вул. Лесі Українки 67", DateOfBirth = DateOnly.FromDateTime(new DateTime(1992, 2, 2)), DateOfEmployment = DateOnly.FromDateTime(new DateTime(2020, 2, 1)), Salary = 40000 },
            new Employee { Id = 3, FirstName = "Марія", LastName = "Кузьменко", Position = "Менеджер", Adress = "Київ вул. Шевченка 56", DateOfBirth = DateOnly.FromDateTime(new DateTime(1985, 3, 3)), DateOfEmployment = DateOnly.FromDateTime(new DateTime(2019, 3, 1)), Salary = 30000 }
        );
            base.OnModelCreating(builder);

		}
	}
}
