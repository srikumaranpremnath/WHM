﻿using DataLayer.Models.AbstractModels;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer.Models
{
    [Table("WareHouses", Schema = "whm")]
    public class WareHouse : Audit
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
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
        [Required]
        [DefaultValue(0)]
        public bool IsDeleted { get; set; }

        public void SetCreatedColumns()
        {
            CreatedAt = DateTime.Now;
            CreatedBy = string.Empty;
        }

        public void SetModifyColumns()
        {
            ModifiedAt = DateTime.Now;
            ModifiedBy = string.Empty;
        }

        public void Delete()
        {
            IsDeleted = true;
        }
    }
}
