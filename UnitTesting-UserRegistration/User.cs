using System.Text.RegularExpressions;

namespace UnitTesting_UserRegistration
{
    public class User
    {
        public static string USER_NAME = "^[A-Z]{1}[a-z]{2,}";
        public static string EMAIL = "^[A-Za-z]{3,}[.]{0,}[a-zA-Z]{3,}[@]{1}[a-z]{2,}[.]{1}[a-z]{2,}[.]{1}[a-z]{2,}$";
        public static string MOBILE = "^[0-9]{2}\\s[6-9]{1}[0-9]{9}$";
        public static string PASSWORD = "^[A-Za-z]{4,}[!+@+#+$+%+^+&+*+(+)+_+++~+.+,]{1,}[0-9]{3,}$";
        public static string ALLEMAIL = "^[a-zA-Z]+[.+_]{1}[a-zA-Z]+[@]{1}[a-z]+[.][a-z]{2,3}([.][a-z]{2,3}){0,1}$$";
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
        public string UserAllEmail(string[]arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                string word = arr[i];
                if (Regex.IsMatch(word, ALLEMAIL))
                    return "Valid";
            }            
            return "InValid";
        }         
    }
}