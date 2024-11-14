using CodeFirst.Enums;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirst.Models
{
    public class AppUser : BaseEntity
    {
        public string UserName { get; set; }
        public string  Password { get; set; }

        [NotMapped]
        public string RePassword { get; set; }
        public Role Role { get; set; }

        // Relational Property

        public AppUserDetail AppUserDetail { get; set; }
        public virtual List<Order> Orders { get; set; }

    }
}
