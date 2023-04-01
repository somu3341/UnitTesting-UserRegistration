using System.Text.RegularExpressions;

namespace UnitTesting_UserRegistration
{
    public class User
    {
        public static string USER_NAME = "^[A-Z]{1}[a-z]{2,}";
        public static string EMAIL = "^[A-Za-z]{3,}[.]{0,}[a-zA-Z]{3,}[@]{1}[a-z]{2,}[.]{1}[a-z]{2,}[.]{1}[a-z]{2,}$";
        public static string MOBILE = "^[0-9]{2}\\s[6-9]{1}[0-9]{9}$";
        public static string PASSWORD = "^[A-Z]{1}[0-9a-z]{7,}$";
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
        public string Mobile(string mobile)
        {
            if (Regex.IsMatch(mobile, MOBILE))
                return "Valid";
            return "InValid";
        }
        public string Password(string password)
        {
            if (Regex.IsMatch(password, PASSWORD))
                return "Valid";
            return "InValid";
        }
    }
}