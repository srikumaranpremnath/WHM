using BusinessObjects.Models.Common;

namespace BusinessObjects.Models
{
    public class Category : Audit
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string CategoryCode { get; set; }
        public bool IsDeleted { get; set; }
    }
}
