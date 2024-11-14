using Library.Models.MetaDataTypes;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Library.Models
{
    [ModelMetadataType(typeof(AuthorMetaData))]
    public class Author : BaseEntity
    {
        public string  FirstName { get; set; }
        public string LastName { get; set; }

        //public string FullName       OĞUZHAN ABİNİN GÖSTERDİĞİ PRATİK YÖNTEM
        //{
        //    get
        //    {
        //        return $"Adı : {FirstName} Soyadı:{LastName}";
        //    }
        //}
        

        //RELATIONAL PROPERTY

        public List<Book> Books { get; set; }
    }
}
