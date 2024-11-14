using System.ComponentModel.DataAnnotations;

namespace Library.Models.MetaDataTypes
{
    public class AuthorMetaData
    {
        [Required(ErrorMessage = "Zorunlu Alan")]
        [MaxLength(15, ErrorMessage = "Maksimum 15 karakter girebilirsiniz.")]
        public string FirstName { get; set; }
    }
}
