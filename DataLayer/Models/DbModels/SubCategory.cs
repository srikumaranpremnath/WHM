using DataLayer.Models.AbstractModels;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer.Models
{
    [Table("SubCategories", Schema = "whm")]

    public class SubCategory : Audit
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SubCategoryID { get; set; }
        [Required]
        [StringLength(100)]
        public string SubCategoryname { get; set; }
        [Required]
        [StringLength(10)]
        public string SubCategoryCode { get; set; }
        [Required]
        public virtual int CategoryID { get; set; }
        [ForeignKey("CategoryID")]
        public virtual Category Category { get; set; }


    }
}
