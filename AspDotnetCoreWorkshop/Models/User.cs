using System.ComponentModel.DataAnnotations;

namespace AspDotnetCoreWorkshop.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Lütfen Bu alanı Doldurunuz")]
        [MaxLength(30, ErrorMessage = "Max 30 karakter girebilirsiniz")]
        [MinLength(3, ErrorMessage = "Min 3 karakter girebilirsiniz")]
        public string NameSurname { get; set; }

        [Required(ErrorMessage ="Lütfen Bu alanı Doldurunuz")]
        [MaxLength(50, ErrorMessage = "Max 30 karakter girebilirsiniz")]
        [EmailAddress(ErrorMessage ="Geçerli bir Email Adress Giriniz")]
        public string Email { get; set; }
    }
}
