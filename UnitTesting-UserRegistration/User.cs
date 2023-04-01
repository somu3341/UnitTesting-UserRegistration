using System.Text.RegularExpressions;

namespace UnitTesting_UserRegistration
{
    public class User
    {
        public static string USER_NAME = "^[A-Z]{1}[a-z]{2,}";
        public static string EMAIL = "^[A-Za-z]{3,}[.]{0,}[a-zA-Z]{3,}[@]{1}[a-z]{2,}[.]{1}[a-z]{2,}[.]{1}[a-z]{2,}$";
        public string UserFirst(string name)
        {
            if (Regex.IsMatch(name, USER_NAME))
                return "Valid";
            return "InValid";
        }
        public string UserLast(string name)
        {
            if (Regex.IsMatch(name, USER_NAME))
                return "Valid";
            return "InValid";
        }
        public string Email(string email)
        {
            if (Regex.IsMatch(email, EMAIL))
                return "Valid";
            return "InValid";
        }
    }
}