namespace MeetingApp.Models
{
    public static class Repository
    {
        private static List<UserInfo> _users = new List<UserInfo>();

        static Repository()
        {

            _users.Add(new UserInfo() { Id = 1, Name = "Sinem", Email = "sinem@gmail.com", Phone = "+414554685", WillAttend = true });
            _users.Add(new UserInfo() { Id = 2, Name = "Efsa", Email = "efsa@gmail.com", Phone = "+255798962", WillAttend = false });
            _users.Add(new UserInfo() { Id = 3, Name = "Azra", Email = "azra@gmail.com", Phone = "+895952565", WillAttend = true });

        }

        public static List<UserInfo> Users { get { return _users; } }

        public static void CreateUser(UserInfo user)
        {
            user.Id = Users.Count + 1;
            _users.Add(user);
        }

        public static UserInfo? GetById(int id)
        {
            return _users.FirstOrDefault(user => user.Id == id);
        }
    }
}
