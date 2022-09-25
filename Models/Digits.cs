using System.ComponentModel.DataAnnotations;

namespace Randomize.Models
{
    public class Digits
    {
        [Required (ErrorMessage = "Введите число в диапазоне от -10000 до 10000")]
        public int numberOne { get; set; }

        [Required (ErrorMessage = "Введите число в диапазоне от -10000 до 10000")]
        public int numberTwo { get; set; }

        public int result { get; set; }
    }
}
