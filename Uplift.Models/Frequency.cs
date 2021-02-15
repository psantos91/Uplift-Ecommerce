using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Uplift.Models
{
    public class Frequency
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 3)]
        [Display(Name = "Frequency Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Frequency Count")]
        public int FrequencyCount { get; set; }
    }
}
