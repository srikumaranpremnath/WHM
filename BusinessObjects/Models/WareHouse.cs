﻿using BusinessObjects.Models.Common;

namespace BusinessObjects.Models
{
    public class WareHouse : Audit
    {
        public int WareHouseId { get; set; }
        public string WareHouseName { get; set; }
        public string WareHouseCode { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public bool IsDeleted { get; set; }
    }
}
