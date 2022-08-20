using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject_5175.WEB.Areas.Member.Models.VMs
{
    public class GetArticleVM
    {
        public int ArticleID { get; set; }  // LİSTELEME SAYFASINDA UPDATE-DELETE GİDERKEN GEREKLİ
        public string Title { get; set; }

        public string Content { get; set; }

        public string Image { get; set; }

        public string UserFullName { get; set; } // oluşturan tam ad

        public string CategoryName { get; set; }  // kategori Adı

        public DateTime CreateDate { get; set; }
        public int AppUserID { get; set; }
    }
}
