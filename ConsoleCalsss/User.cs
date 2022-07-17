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

        //setters & getters


        public int ID
        {
            get { return this.Id; }
            set { this.Id = value; }
        }
        public string Name
        {
            get { return this.Name; }
            set { this.name = value; }
        }

        public string Lastname
        {
            get { return this.lasname; }
            set { this.lasname = value; }
        }
        public string UserName
        {
            get { return this.userName; }
            set { this.userName = value; }
        }
        public string Password
        {
            get { return this.password; }
            set { this.password = value; }
        }
        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }
    }
}
