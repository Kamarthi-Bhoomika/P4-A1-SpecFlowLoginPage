namespace UserLoginAssignment
{
    public class UserLogin
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Login()
        {
            if(string.IsNullOrEmpty(UserName) && Password == "admin@123")
            {
                return "Please enter username";
            }
            else if (UserName == "admin" && string.IsNullOrEmpty(Password))
            {
                return "Please enter password";
            }
            else if (string.IsNullOrEmpty(UserName) && string.IsNullOrEmpty(Password))
            {
                return "Please enter username and password";
            }
            else if(UserName == "admin" && Password == "admin@123")
            {
                return "Welcome " + UserName; 
            }
            else
            {
                return "Invalid Credentials";
            }
        }
    }
}