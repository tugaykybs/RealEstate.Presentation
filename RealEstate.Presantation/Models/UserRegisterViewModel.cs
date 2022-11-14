using System.ComponentModel.DataAnnotations;

namespace RealEstate.PresentationLayer.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage = "ad alanı boş geçilmez")]
        public string Name { get; set; }

        [Required(ErrorMessage = " soyad alanı boş geçilmez")]
        public string Surname { get; set; }

        [Required(ErrorMessage = " Kullanıcı adı alanı boş geçilmez")]
        public string Username { get; set; }

        [Required(ErrorMessage = " mail alanı boş geçilmez")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Şifre Tekrar Alanı Boş Geçilmez")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Şifre Tekrar Alanı Boş Geçilmez")]
        [Compare("Password", ErrorMessage = "Şifreler Birbiriyle uyuşmuyor")]
        public string comfirmpassword { get; set; }
    }
}
