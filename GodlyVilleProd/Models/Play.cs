using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace GodlyVilleProd.Models
{
    public class Play
    {

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public byte? DurationInMinutes { get; set; }

        [Display(Name="Acts")]
        [Range(0,3)]
        public byte NumberOfActs { get; set; }

        [Display(Name="Musical")]
        public bool IsMusical { get; set; }

        [Required]
        [StringLength(255)]
        public string Description { get; set; }
    }
}