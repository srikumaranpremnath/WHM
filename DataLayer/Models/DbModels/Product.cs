using DataLayer.Models.AbstractModels;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer.Models
{
    [Table("Products", Schema = "whm")]
    public class Product : Audit
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId { get; set; }

        [Required]
        public string ProductName { get; set; }
        [Required]
        public string ProductCode { get; set; }
        [Required]
        public int PricePerProduct { get; set; }
        [Required]
        public int Count { get; set; }
        [Required]
        public string Brand { get; set; }
        public string Model { get; set; }
        [Required]
        public DateTime ManufactureDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        [Required]
        public virtual int SubCategoryID { get; set; }
        [ForeignKey("SubCategoryID")]
        public virtual SubCategory SubCategory{ get; set; }
        [Required]
        public virtual int WareHouseID { get; set; }
        [ForeignKey("WareHouseID")]
        public virtual WareHouse Warehouse { get; set; }


    }
}
