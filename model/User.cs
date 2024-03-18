namespace ProjectCS.model
{
    public class User : HasID<int>
    {
        public User(string username, string password)
        { 
            this.Username = username;
            this.Password = password;
        }

        public string Username { get; set; }

        public string Password { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}