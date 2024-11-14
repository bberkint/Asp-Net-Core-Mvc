namespace CodeFirst.Models
{
    public class AppUserDetail : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
       
        public int AppUserID { get; set; }


        //Relational Property
        public virtual AppUser AppUser { get; set; }
    }
}
