using System;

namespace Library.Models
{
    public class Operation : BaseEntity
    {

        public int StudentID { get; set; }
        public int BookID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        // RELATIONAL PROPERTY

        public Student Student { get; set; }
        public Book Book { get; set; }

    }
}
