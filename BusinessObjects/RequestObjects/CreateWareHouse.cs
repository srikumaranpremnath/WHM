using System.ComponentModel.DataAnnotations;

namespace BusinessObjects.RequestObjects
{
    public class CreateWareHouse
    {
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
    }
}
