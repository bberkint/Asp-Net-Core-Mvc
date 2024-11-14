using System.Collections.Generic;

namespace Library.Models
{
    public class BookType : BaseEntity
    {
        public string Name { get; set; }

        //RELATIONAL PROPERTY

        public List<Book> Books { get; set; }
    }
}
