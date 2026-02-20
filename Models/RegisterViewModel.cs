using System.ComponentModel.DataAnnotations;

namespace myApp.Models
{
    public class RegisterViewModel
    {
        [Required]
        [StringLength(50)]
        public string? Login { get; set; }

        [Required]
        [StringLength(50)]
        public string? Password { get; set; }
    }
}
