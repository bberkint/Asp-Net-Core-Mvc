using Library.Models;
using Microsoft.EntityFrameworkCore;

namespace Library.Initializer
{
    public static class DataInitializer
    {
        public static void Seed(ModelBuilder modelBuilder)
        {

            string password1 = BCrypt.Net.BCrypt.HashPassword("123");
            string password2 = BCrypt.Net.BCrypt.HashPassword("1234");

            modelBuilder.Entity<AppUser>().HasData(
                    new AppUser() { ID = 1, UserName = "administrator", Password = password1, Role = Enums.Role.admin },
                    new AppUser() { ID = 2, UserName = "berkin", Password = password2, Role = Enums.Role.user }
                );


            modelBuilder.Entity<Student>().HasData(
                    new Student() { ID = 1, FirstName = "Veli", LastName = "Kutay", Gender = Enums.Gender.Erkek },
                    new Student() { ID = 2, FirstName = "Arda", LastName = "Kaan", Gender = Enums.Gender.Erkek },
                    new Student() { ID = 3, FirstName = "Utku", LastName = "Pirik", Gender = Enums.Gender.Erkek },
                    new Student() { ID = 4, FirstName = "Nafiz", LastName = "Balcı", Gender = Enums.Gender.Erkek }
                );

            modelBuilder.Entity<StudentDetail>().HasData(
                    new StudentDetail() { ID = 1, StudentID = 1, SchoolNumber = "100", BirthDay = new System.DateTime(1999, 11, 17) },
                    new StudentDetail() { ID = 2, StudentID = 2, SchoolNumber = "200", BirthDay = new System.DateTime(2000, 05, 18) },
                    new StudentDetail() { ID = 3, StudentID = 3, SchoolNumber = "300", BirthDay = new System.DateTime(2000, 11, 24) },
                    new StudentDetail() { ID = 4, StudentID = 4, SchoolNumber = "400", BirthDay = new System.DateTime(2000, 08, 25) }
                );

        }
    }
}
