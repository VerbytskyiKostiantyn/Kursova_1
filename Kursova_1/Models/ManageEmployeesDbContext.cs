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
			new Employee { Id = 3, FirstName = "Марія", LastName = "Кузьменко", Position = "Менеджер", Adress = "Київ вул. Шевченка 56", DateOfBirth = DateOnly.FromDateTime(new DateTime(1985, 3, 3)), DateOfEmployment = DateOnly.FromDateTime(new DateTime(2019, 3, 1)), Salary = 30000 },
			new Employee { Id = 4, FirstName = "Олена", LastName = "Михайлова", Position = "Програміст", Adress = "Львів вул. Липинського 22", DateOfBirth = DateOnly.FromDateTime(new DateTime(1993, 4, 4)), DateOfEmployment = DateOnly.FromDateTime(new DateTime(2021, 4, 1)), Salary = 60000 },
			new Employee { Id = 5, FirstName = "Віктор", LastName = "Петренко", Position = "Тестувальник", Adress = "Харків вул. Франка 44", DateOfBirth = DateOnly.FromDateTime(new DateTime(1994, 5, 5)), DateOfEmployment = DateOnly.FromDateTime(new DateTime(2022, 5, 1)), Salary = 55000 },
			new Employee { Id = 6, FirstName = "Анастасія", LastName = "Коваленко", Position = "Маркетолог", Adress = "Одеса вул. Лесі Українки 66", DateOfBirth = DateOnly.FromDateTime(new DateTime(1995, 6, 6)), DateOfEmployment = DateOnly.FromDateTime(new DateTime(2023, 6, 1)), Salary = 45000 },
			new Employee { Id = 7, FirstName = "Сергій", LastName = "Куліш", Position = "HR-менеджер", Adress = "Дніпро вул. Скоропадського 88", DateOfBirth = DateOnly.FromDateTime(new DateTime(1996, 7, 7)), DateOfEmployment = DateOnly.FromDateTime(new DateTime(2024, 7, 1)), Salary = 50000 },
			new Employee { Id = 8, FirstName = "Ірина", LastName = "Шевченко", Position = "Фінансист", Adress = "Запоріжжя вул. Шевченка 99", DateOfBirth = DateOnly.FromDateTime(new DateTime(1997, 8, 8)), DateOfEmployment = DateOnly.FromDateTime(new DateTime(2025, 8, 1)), Salary = 40000 },
			new Employee { Id = 9, FirstName = "Василь", LastName = "Карпенко", Position = "Системний адміністратор", Adress = "Київ вул. Грушевського 11", DateOfBirth = DateOnly.FromDateTime(new DateTime(1998, 9, 9)), DateOfEmployment = DateOnly.FromDateTime(new DateTime(2026, 9, 1)), Salary = 55000 },
			new Employee { Id = 10, FirstName = "Оксана", LastName = "Павленко", Position = "Проектний менеджер", Adress = "Львів вул. Франка 33", DateOfBirth = DateOnly.FromDateTime(new DateTime(1999, 10, 10)), DateOfEmployment = DateOnly.FromDateTime(new DateTime(2027, 10, 1)), Salary = 60000 },
			new Employee { Id = 11, FirstName = "Олександр", LastName = "Кузьменко", Position = "Бухгалтер", Adress = "Харків вул. Шевченка 55", DateOfBirth = DateOnly.FromDateTime(new DateTime(2000, 11, 11)), DateOfEmployment = DateOnly.FromDateTime(new DateTime(2028, 11, 1)), Salary = 45000 },
			new Employee { Id = 12, FirstName = "Юлія", LastName = "Михайлова", Position = "HR-менеджер", Adress = "Одеса вул. Скоропадського 77", DateOfBirth = DateOnly.FromDateTime(new DateTime(2001, 12, 12)), DateOfEmployment = DateOnly.FromDateTime(new DateTime(2029, 12, 1)), Salary = 50000 },
			new Employee { Id = 13, FirstName = "Вікторія", LastName = "Коваленко", Position = "Менеджер з продажів", Adress = "Дніпро вул. Шевченка 99", DateOfBirth = DateOnly.FromDateTime(new DateTime(2002, 1, 13)), DateOfEmployment = DateOnly.FromDateTime(new DateTime(2030, 1, 1)), Salary = 40000 },
			new Employee { Id = 14, FirstName = "Олег", LastName = "Петров", Position = "Спеціаліст з IT", Adress = "Київ вул. Грушевського 15", DateOfBirth = DateOnly.FromDateTime(new DateTime(1991, 1, 14)), DateOfEmployment = DateOnly.FromDateTime(new DateTime(2021, 1, 14)), Salary = 55000 },
			new Employee { Id = 15, FirstName = "Анастасія", LastName = "Коваленко", Position = "Менеджер з продажів", Adress = "Одеса вул. Шевченка 16", DateOfBirth = DateOnly.FromDateTime(new DateTime(1992, 2, 15)), DateOfEmployment = DateOnly.FromDateTime(new DateTime(2022, 2, 15)), Salary = 45000 },
			new Employee { Id = 16, FirstName = "Сергій", LastName = "Куліш", Position = "HR-менеджер", Adress = "Дніпро вул. Скоропадського 17", DateOfBirth = DateOnly.FromDateTime(new DateTime(1993, 3, 16)), DateOfEmployment = DateOnly.FromDateTime(new DateTime(2023, 3, 16)), Salary = 50000 },
			new Employee { Id = 17, FirstName = "Ірина", LastName = "Шевченко", Position = "Фінансист", Adress = "Запоріжжя вул. Шевченка 18", DateOfBirth = DateOnly.FromDateTime(new DateTime(1994, 4, 17)), DateOfEmployment = DateOnly.FromDateTime(new DateTime(2024, 4, 17)), Salary = 40000 },
			new Employee { Id = 18, FirstName = "Василь", LastName = "Карпенко", Position = "Системний адміністратор", Adress = "Київ вул. Грушевського 19", DateOfBirth = DateOnly.FromDateTime(new DateTime(1995, 5, 18)), DateOfEmployment = DateOnly.FromDateTime(new DateTime(2025, 5, 18)), Salary = 55000 },
			new Employee { Id = 19, FirstName = "Оксана", LastName = "Павленко", Position = "Проектний менеджер", Adress = "Львів вул. Франка 19", DateOfBirth = DateOnly.FromDateTime(new DateTime(1996, 6, 19)), DateOfEmployment = DateOnly.FromDateTime(new DateTime(2026, 6, 19)), Salary = 60000 },
			new Employee { Id = 20, FirstName = "Олександр", LastName = "Кузьменко", Position = "Бухгалтер", Adress = "Харків вул. Шевченка 19", DateOfBirth = DateOnly.FromDateTime(new DateTime(1997, 7, 20)), DateOfEmployment = DateOnly.FromDateTime(new DateTime(2027, 7, 20)), Salary = 45000 },
			new Employee { Id = 21, FirstName = "Юлія", LastName = "Михайлова", Position = "HR-менеджер", Adress = "Одеса вул. Скоропадського 19", DateOfBirth = DateOnly.FromDateTime(new DateTime(1998, 8, 21)), DateOfEmployment = DateOnly.FromDateTime(new DateTime(2028, 8, 21)), Salary = 50000 },
			new Employee { Id = 22, FirstName = "Вікторія", LastName = "Коваленко", Position = "Менеджер з продажів", Adress = "Дніпро вул. Шевченка 19", DateOfBirth = DateOnly.FromDateTime(new DateTime(1999, 9, 22)), DateOfEmployment = DateOnly.FromDateTime(new DateTime(2029, 9, 22)), Salary = 40000 },
			new Employee { Id = 23, FirstName = "Олена", LastName = "Михайлова", Position = "Програміст", Adress = "Львів вул. Липинського 23", DateOfBirth = DateOnly.FromDateTime(new DateTime(2000, 10, 23)), DateOfEmployment = DateOnly.FromDateTime(new DateTime(2030, 10, 23)), Salary = 60000 }
			);
			base.OnModelCreating(builder);

		}
	}
}
