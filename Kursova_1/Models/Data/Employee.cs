using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Kursova_1.Models.Data
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Ім'я є обов'язковим")]
        [DisplayName("Ім'я")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Довжина імені повинна бути від 2 до 50 символів.")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Прізвище є обов'язковим")]
        [DisplayName("Прізвище")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Довжина прізвища повинна бути від 2 до 50 символів.")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Посада є обов'язковою")]
        [DisplayName("Посада")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Довжина посади повинна бути від 3 до 100 символів.")]
        public string Position { get; set; }
        [DisplayName("Дата народження")]
        public DateOnly? DateOfBirth { get; set; }
        [DisplayName("Дата прийняття на посаду")]
        [Required(ErrorMessage = "Дата на прийняття посаду є обов'язковою")]
        public DateOnly DateOfEmployment { get; set; }
        [DisplayName("Дата звільнення")]
        public DateOnly? DateOfDismissal { get; set; }
        [DisplayName("Адреса")]
        [StringLength(500, MinimumLength = 5, ErrorMessage = "Довжина адреси повинна бути від 5 до 500 символів.")]
        public string? Adress { get; set; }
        [DisplayName("Заробітна плата")]
        [Range(1, int.MaxValue, ErrorMessage = "Зарплата повинна бути числом та більшою нуля")]
        [Required(ErrorMessage = "Заробітна плата є обов'язковою")]
        public int Salary { get; set; }

    }
}
