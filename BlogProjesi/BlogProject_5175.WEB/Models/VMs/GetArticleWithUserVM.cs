using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject_5175.WEB.Models.VMs
{
    public class GetArticleWithUserVM
    {
        public string Title { get; set; }

        public string Content { get; set; }

        public DateTime  CreatedDate { get; set; }

        public string CategoryName { get; set; }

        public int UserId { get; set; }

        public string UserFullName { get; set; }

        public string Image { get; set; }

        public int ArticleId { get; set; }

    }
}
