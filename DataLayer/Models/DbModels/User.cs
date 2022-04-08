using DataLayer.Models.AbstractModels;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer.Models
{
    [Table("Users",Schema ="whm")]
    public class User : Audit
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [StringLength(10)]
        public string EmployeeId { get; set; }
        [Required]  
        [StringLength(100)]
        public string UserName { get; set; }  
        [Required]
        [StringLength(15)]
        public string Password { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public long Mobile { get; set; }

    }
}
