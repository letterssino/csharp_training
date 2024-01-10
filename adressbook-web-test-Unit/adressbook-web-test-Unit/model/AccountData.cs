namespace adressbook_web_test_Unit
{
    public class AccountData
    {
        private string username;
        private string password;

        public AccountData(string username, string password)

        {
            this.username = username;
            this.password = password;
        }
        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string Passwod 
        { 
            get { return password; } 
            set { password = value; } 
        } 
        
    }
}
