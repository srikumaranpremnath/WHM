using DataLayer.Models.AbstractModels;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer.Models
{
    [Table("Categories", Schema = "whm")]
    public class Category : Audit
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CategoryID { get; set; }
        [Required]
        [StringLength(100)]
        public string Categoryname { get; set; }
        [Required]
        [StringLength(10)]
        public string CategoryCode { get; set; }
    }
}
