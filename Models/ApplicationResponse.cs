using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission4.Models
{
    public class ApplicationResponse
    {
        [Key]
        [Required]
        public int id { get; set; }
        [Required]
        public string Category { get; set; }

        [Required] 
        public string Title { get; set; }

        [Required]
        [Range(0,3000)]
        public int Year { get; set; }

        [Required]
        public string Director { get; set; }

        [Required]
        public string Rating { get; set; }

        [Required] 
        public bool Edited { get; set; }

        public string LentTo { get; set; }

        [MaxLength(25)]
        public string Notes { get; set; }
    }
}
