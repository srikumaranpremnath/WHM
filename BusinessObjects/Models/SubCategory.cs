using BusinessObjects.Models.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessObjects.Models
{
    [Table("SubCategories", Schema = "whm")]

    public class SubCategory : Audit
    {
        public int SubCategoryId { get; set; }
        public string SubCategoryName { get; set; }
        public string SubCategoryCode { get; set; }
        public virtual int CategoryId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
