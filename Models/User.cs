using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace myApp.Models
{
    public class User
    {
        [Key]
        public int IDUser { get; set; }
        [Required]
        [StringLength(50)]
        public string login { get; set; }

        [Required]
        [StringLength(50)]
        public string Password { get; set; }
        
        public int IdRole { get; set; }
        [ForeignKey("IdRole")]

        public Role? Role { get; set; }
    }
}
