using System.ComponentModel.DataAnnotations;

namespace UdemyAspNetCore.Models
{
    public class CustomerCreateModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Ad alanı boş geçilemez.")]
        [MaxLength(30, ErrorMessage = "En fazla 30 karakter giriniz.")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Soyad alanı boş geçilemez.")]
        [MinLength(3, ErrorMessage = "En az 30 karakter giriniz.")]
        public string LastName { get; set; }
        [Range(18, 40, ErrorMessage = "Yaş değerini 18 ve 40 arasında giriniz.")]
        public int Age { get; set; }
    }
}
