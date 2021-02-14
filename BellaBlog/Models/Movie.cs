using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BellaBlog.Models
{
    public class Movie
    {
        [Key]
        public int MovieId { get; set; }
        [Required(ErrorMessage = "This field can't be empty ")]
        [StringLength(100)]
        public string Name { get; set; }
        [Required(ErrorMessage = "This field can't be empty ")]
        [StringLength(100)]
        public string Platform { get; set; }

        public string Location { get; set; }
        [Required(ErrorMessage = "This field can't be empty ")]
        [StringLength(100)]
        public string Director { get; set; }
        [Required(ErrorMessage = "This field can't be empty ")]       
        public int Rate { get; set; }
        public bool isActive { get; set; }
    }
}
