using BusinessObjects.DTO.Common;

namespace BusinessObjects.DTO
{
    public class SubCategoryDto : Audit
    {
        public int SubCategoryId { get; set; }
        public string SubCategoryName { get; set; }
        public string SubCategoryCode { get; set; }
        public virtual int CategoryId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
