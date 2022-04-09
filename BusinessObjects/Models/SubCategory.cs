using BusinessObjects.Models.Common;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessObjects.Models
{
    [Table("SubCategories", Schema = "whm")]

    public class SubCategory : Audit
    {
        [Required]
        public int SubCategoryId { get; set; }
        [Required]
        [StringLength(100)]
        public string SubCategoryName { get; set; }
        [Required]
        [StringLength(10)]
        public string SubCategoryCode { get; set; }
        [Required]
        public virtual int CategoryId { get; set; }
        [ForeignKey("CategoryID")]
        public virtual Category Category { get; set; }
        [DefaultValue(0)]
        public bool IsDeleted { get; set; }
    }
}
