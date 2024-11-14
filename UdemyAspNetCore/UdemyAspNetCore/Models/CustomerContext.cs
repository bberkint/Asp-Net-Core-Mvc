using System.Collections.Generic;

namespace UdemyAspNetCore.Models
{
    public class CustomerContext
    {
        public static List<Customer> Customers = new() {

            new Customer {Id = 1, FirstName = "Ali" , LastName = "Veli" , Age = 35},
            new Customer {Id = 1, FirstName = "Oğuz" , LastName = "Kahraman" , Age = 20},
        };
    }
}
