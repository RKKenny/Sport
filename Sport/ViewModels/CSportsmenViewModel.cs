using Sport.Models;
using System.ComponentModel.DataAnnotations;

namespace Sport.ViewModels
{
    public class CSportsmenViewModel
    {

        [Required]
        [RegularExpression(@"^[а-яА-Я]+$", ErrorMessage = "Необходимо ввести имя кириллицей")]
        [Display(Name = "Имя")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Фамилия")]
        [RegularExpression(@"^[а-яА-Я]+$", ErrorMessage = "Необходимо ввести фамилию кириллицей")]      
        public string LastName { get; set; }

        [Required(ErrorMessage = "Необходимо выбрать пол")]
        [Display(Name = "Пол")]
        public string Sex { get; set; }

        [Required(ErrorMessage = "Необходимо ввести возраст")]
        [Display(Name = "Возраст")]
        [Range(7, 100, ErrorMessage = "Введите возраст от 7 до 100")]
        public byte Age { get; set; }

        [Required(ErrorMessage = "Необходимо ввести стаж")]
        [Display(Name = "Стаж")]
        [Range(7, 100, ErrorMessage = "Введите стаж от 7 до 100")]
        public byte Experience { get; set; }

        [Required]
        [Display(Name = "Город")]
        [RegularExpression(@"^[а-яА-Я]+$", ErrorMessage ="Допустима только кириллица")]
        public string City { get; set; }

        public CSportsmen ToUser()
        {
            return new CSportsmen
            {
                FirstName = this.FirstName,
                LastName = this.LastName,
                Sex = this.Sex,
                Age = this.Age,
                Experience = this.Experience,
                City = this.City
            };
        }
    }
}
