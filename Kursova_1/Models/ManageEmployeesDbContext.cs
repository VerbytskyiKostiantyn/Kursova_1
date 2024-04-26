using Kursova_1.Models.Data;
using Microsoft.EntityFrameworkCore;
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
			base.OnModelCreating(builder);
		}
	}
}
