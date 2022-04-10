using BusinessObjects.Models.Common;

namespace BusinessObjects.Models
{
    public class Product : Audit
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductCode { get; set; }
        public int PricePerProduct { get; set; }
        public int Count { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public DateTime ManufactureDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public virtual int SubCategoryId { get; set; }
        public virtual int WareHouseId { get; set; }

    }
}
