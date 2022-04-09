using BusinessObjects.Models.Common;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BussinessObjects.Models
{
    public class WareHouse : Audit
    {
        [Required]
        public int WareHouseId { get; set; }
        [Required]
        public string WareHouseName { get; set; }
        [Required]
        public string WareHouseCode { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string State { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]
        public double Latitude { get; set; }
        [Required]
        public double Longitude { get; set; }
        [DefaultValue(0)]
        public bool IsDeleted { get; set; }

    }
}
