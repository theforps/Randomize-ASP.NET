using System.ComponentModel.DataAnnotations;

namespace Randomize.Models
{
    public class Digits
    {
        [Required]
        public int numberOne { get; set; }
        [Required]
        public int numberTwo { get; set; }

        public int result { get; set; }
    }
}
