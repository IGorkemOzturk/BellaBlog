using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BellaBlog.Models
{
    public class Admin
    {
        [Key]
        public int AdminId { get; set; }
        [Required(ErrorMessage = "Name field can't be empty ")]
        [StringLength(30, ErrorMessage = "Please only 1-30 length characters", MinimumLength = 1)]
        public string Name { get; set; }
        [Required(ErrorMessage = "Surname field can't be empty ")]
        [StringLength(30, ErrorMessage = "Please only 1-30 length characters", MinimumLength = 1)]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Password field can't be empty ")]
        [StringLength(10, ErrorMessage = "Please only 6-10 length characters", MinimumLength = 6)]
        public string Password { get; set; }
        [Required(ErrorMessage = "Mail field can't be empty ")]
        [StringLength(50)]
        public string Mail { get; set; }
        [Column(TypeName = "Char")]
        [StringLength(1)]
        public string Role { get; set; }

        public List<Blog> Blogs { get; set; }
    }
}
