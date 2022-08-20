using BlogProject_5175.Models.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject_5175.WEB.Areas.Member.Models.DTOs
{
    public class ArticleUpdateDTO
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Başlık boş bırakılamaz")]
        [MinLength(2), MaxLength(100)]
        public string Title { get; set; }

        public string PreviousTitle { get; set; }

        [Required(ErrorMessage = "İçerik boş bırakılamaz")]
        [MinLength(2), MaxLength(15000)]
        public string Content { get; set; }


        public string Image { get; set; }

       // [Required]   NOT => MAKALE güncellenirken foto değişmeyedebilir diye required kaldırıldı.
        [NotMapped]
        public IFormFile ImagePath { get; set; }

        [Required]   // kategorisiz makale olmaz 
        public int CategoryID { get; set; }

        [Required]
        public int AppUserID { get; set; }
        public List<ArticleCategory> ArticleCategories { get; set; }

        public int ReadCount { get; set; }

        public List<GetCategoryDTO> Categories { get; set; } // kategorinin bazı proplarını göndereceğim List<Category>  değil bu yüzden .  Aslında dto içine dto gömülmüş oluyor. 


    }
}
