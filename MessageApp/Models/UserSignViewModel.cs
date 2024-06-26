using System.ComponentModel.DataAnnotations;

namespace MessageApp.WebUI.Models
{
    public class UserSignViewModel
    {

        [Display(Name = "Kullanıcı Adı")]
        [Required(ErrorMessage = "Kullanıcı Adını giriniz...!")]
        public string UserName { get; set; }

        [Display(Name = "Şifre")]
        [Required(ErrorMessage = "Şifreyi giriniz...!")]
        public string Password { get; set; }
    }
}
