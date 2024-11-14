using Library.Enums;
using System;

namespace Library.Models
{
    public class BaseEntity
    {
        public int ID { get; set; }
        public DataStatus Status { get; set; }
        public DateTime CreatedData { get; set; }
        public DateTime ModifiedDate { get; set; }

        //public int xDateDay { get
        //    {
        //        return (CreatedData - ModifiedDate).Days;
        //    } }

        public BaseEntity()
        {
            CreatedData = DateTime.Now;
            Status = DataStatus.Inserted;
        }


    }
}
