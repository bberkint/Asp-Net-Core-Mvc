using System.ComponentModel.DataAnnotations;

namespace FormsApp.Models
{

    public class Product
    {
        [Display(Name = "ID")]
        public int ProductId { get; set; }

        [Required]
        [StringLength(100)]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Örnek hata mesajı gönderme")]
        [Range(0, 100000)]
        public decimal? Price { get; set; }

        public string? Image { get; set; }

        public bool IsActive { get; set; }
        [Required]
        public int? CategoryId { get; set; }
    }
}
