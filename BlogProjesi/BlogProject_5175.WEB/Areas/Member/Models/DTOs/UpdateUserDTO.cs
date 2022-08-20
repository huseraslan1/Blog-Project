using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject_5175.WEB.Areas.Member.Models.DTOs
{
    public class UpdateUserDTO
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Ad boş bırakılamaz")]
        [MinLength(3, ErrorMessage = "en az 3 karakter yazmalısınız")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Soyad boş bırakılamaz")]
        [MinLength(3, ErrorMessage = "en az 3 karakter yazmalısınız")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Kullanıcı adı boş bırakılamaz")]
        [MinLength(3, ErrorMessage = "en az 3 karakter yazmalısınız")]

        public string UserName { get; set; }

        [Required(ErrorMessage = "Şifre boş bırakılamaz")]
        [MinLength(3, ErrorMessage = "en az 3 karakter yazmalısınız")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public string OldPassword { get; set; }

        public string Image { get; set; }

 
        [NotMapped]        
        public IFormFile ImagePath { get; set; }

        [Required(ErrorMessage = "Mail boş bırakılamaz")]
        [DataType(DataType.EmailAddress)]
        public string Mail { get; set; }
    }
}
