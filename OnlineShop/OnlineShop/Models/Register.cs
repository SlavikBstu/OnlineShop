using System;
using System.ComponentModel.DataAnnotations;

namespace OnlineShop.Models
{
    public class Register
    {
        public string User_id { get; set; }

        [Required(ErrorMessage = "Введите свою фамилию")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Введите свое имя")]
        public string Name { get; set; }

        public string Sex { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Введите дату своего рождения ")]
        public DateTime Birthday { get; set; }

        [Required(ErrorMessage = "Введите свой номер телефона")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Введите свою электронную почту")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Поле должно быть установлено")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Длина строки должна быть от 3 до 50 символов")]
        public string Password { get; set; }
    }
}