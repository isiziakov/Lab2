using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Lab2.Model
{
    class Flat
    {
        [Required]
        public int district_id { get; set; }
        [Key]
        public int flat_id { get; set; }
        [Required]
        public double square { get; set; }
        [Required]
        public byte floor { get; set; }
        [Required]
        [StringLength(50)]
        public string material { get; set; }
    }
}
