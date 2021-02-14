using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BellaBlog.Models
{
    public class Blog
    {
        [Key]
        public int BlogId { get; set; }
        [Required(ErrorMessage = "This field can't be empty ")]
        [StringLength(100)]
        public string Title { get; set; }
        [Required(ErrorMessage = "This field can't be empty ")]
        [StringLength(900)]
        public string Content { get; set; }
        public DateTime Date { get; set; }
        [Required]
        public bool isActive { get; set; }
        public Admin Admin { get; set; }
    }
}
