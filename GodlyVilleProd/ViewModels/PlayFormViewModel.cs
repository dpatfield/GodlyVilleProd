using GodlyVilleProd.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GodlyVilleProd.ViewModels
{
    public class PlayFormViewModel
    {

        public int? Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public byte? DurationInMinutes { get; set; }

        [Display(Name = "Acts")]
        [Range(0, 3)]
        public byte NumberOfActs { get; set; }

        [Display(Name = "Musical")]
        public bool IsMusical { get; set; }

        [Required]
        [StringLength(255)]
        public string Description { get; set; }

        public string Title
        {
            get
            {
                return (Id != 0 ? "Edit Play" : "New Play");
            }
        }

        public PlayFormViewModel()
        {
            Id = 0;
        }

        public PlayFormViewModel(Play play)
        {
            Id = play.Id;
            Name = play.Name;
            Description = play.Description;
            NumberOfActs = play.NumberOfActs;
            DurationInMinutes = play.DurationInMinutes;
            IsMusical = play.IsMusical;
        }

    }
}