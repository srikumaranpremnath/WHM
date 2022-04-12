using BusinessObjects.DTO.Common;

namespace BusinessObjects.DTO
{
    public class CategoryDto : Audit
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string CategoryCode { get; set; }
        public bool IsDeleted { get; set; }
    }
}
