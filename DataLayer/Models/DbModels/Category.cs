﻿using DataLayer.Models.AbstractModels;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer.Models
{
    [Table("Categories", Schema = "whm")]
    public class Category : Audit
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CategoryId { get; set; }
        [Required]
        [StringLength(100)]
        public string Categoryname { get; set; }
        [Required]
        [StringLength(10)]
        public string CategoryCode { get; set; }
        [Required]
        [DefaultValue(0)]
        public bool IsDeleted { get; set; }
    }
}
