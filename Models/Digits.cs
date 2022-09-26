using System.ComponentModel.DataAnnotations;

namespace Randomize.Models
{
    public class Digits
    {
        [Required (ErrorMessage = "Enter a number in the range from -10000 to 10000")]
        public int numberOne { get; set; }

        [Required (ErrorMessage = "Enter a number in the range from -10000 to 10000")]
        public int numberTwo { get; set; }

        public int result { get; set; }
    }
}
