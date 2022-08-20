using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject_5175.WEB.Areas.Member.Models.DTOs
{
    public class CreateCategoryDTO
    {
        [Required(ErrorMessage ="bu alan boş bırakılamaz")]
        [MinLength(2),MaxLength(50)]
        public string Name { get; set; }

        [Required(ErrorMessage = "bu alan boş bırakılamaz")]
        [MinLength(2), MaxLength(250)]
        public string Description { get; set; }
    }
}
