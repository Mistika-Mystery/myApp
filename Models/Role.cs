using System.ComponentModel.DataAnnotations;

namespace myApp.Models
{
    public class Role
    {
        [Key]
        public int IDRole { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public ICollection<User> Users { get; set; }

        
    }
}
