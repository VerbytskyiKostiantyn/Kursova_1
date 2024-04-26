using System.ComponentModel.DataAnnotations;

namespace Kursova_1.Models.Data
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Position { get; set; }
        public DateOnly DateOfBirth { get; set; }
        [Required]
        public DateOnly DateOfEmployment { get; set; }
        public DateOnly DateOfDismissal { get; set; }
		public string Adress { get; set; }
        [Required]
        public int Salary { get; set; }

    }
}
