using System;


namespace ConsoleCalsss
{
    internal class User
    {
        private int Id;
        private string name;
        private string lasname;
        private string userName;
        private string password;
        private string email;


        public User()
        {
            Id = 0;
            name = String.Empty;
            lasname = String.Empty;
            userName = String.Empty;
            password = String.Empty;
            email = String.Empty;
        }

        public User(int id, string name, string lasname, string userName, string password, string email)
        {
            this.Id = id;
            this.name = name;
            this.lasname = lasname;
            this.userName = userName;
            this.password = password;
            this.email = email;
        }
    }
}
