namespace basics.Models
{
    public class Repository
    {
        private static readonly List<Course> _courses = new();
        static Repository()
        {
            _courses = new List<Course>()
            {
                new Course(){Id = 1 , Title = "ASPNET KURSU", Description="Güzel kurs", Image="1.jpg",Tags = new string[]{"aspnet","web geliştirme"},isActive=true,isHome=true},
                new Course(){Id = 2 , Title = "PYTHON KURSU", Description="Güzel kurs",Image="2.jpg",Tags = new string[]{"python","web geliştirme"},isActive=true,isHome=true},
                new Course(){Id = 3 , Title = "JAVASCRIPT KURSU", Description="Güzel kurs" , Image="3.jpg",isActive=true,isHome=false},
                new Course(){Id = 4 , Title = "DJANGO KURSU", Description="Güzel kurs",Image="4.jpg",isActive=true,isHome=true},
            };
        }
        public static List<Course> Courses { get { return _courses; } }

        public static Course? GetById(int? id)
        {
            return _courses.FirstOrDefault(c => c.Id == id);
        }
    }
}
