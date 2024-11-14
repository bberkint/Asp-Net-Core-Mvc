using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirst.Models
{
    public class OrderDetail : BaseEntity
    {

        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public short Quantity { get; set; }
        
        [Column(TypeName ="numeric(18,1)")]
        public decimal? TotalPrice { get; set; }


        // Relational Property
        public virtual Product Product { get; set; }
        public virtual Order Order  { get; set; }
    }
}
