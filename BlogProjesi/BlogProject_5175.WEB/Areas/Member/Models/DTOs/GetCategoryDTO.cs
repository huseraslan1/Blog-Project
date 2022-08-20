using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject_5175.WEB.Areas.Member.Models.DTOs
{
    public class GetCategoryDTO
    {
        public int ID { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
    }
}
