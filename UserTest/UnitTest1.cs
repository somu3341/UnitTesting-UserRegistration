using UnitTesting_UserRegistration;

namespace UserTest
{
    public class Tests
    {
        [Test]
        public void GivenUserFirstName_WhenAnalyze_ReturnValid()
        {
            string first = "Soma";
            User user = new User();
            string result = user.UserFirst(first);
            Assert.AreEqual(result,"Valid");
        }
        [Test]
        public void GivenUserLastName_WhenAnalyze_ReturnValid()
        {
            string Last = "Shekar";
            User user = new User();
            string result = user.UserFirst(Last);
            Assert.AreEqual(result, "Valid");
        }
        [Test]
        public void GivenUserEmail_WhenAnalyze_ReturnValid()
        {
            string Email = "abc.xyz@bl.co.in";
            User user = new User();
            string result = user.Email(Email);
            Assert.AreEqual(result,"Valid");
        }
        [Test]
        public void GivenUserMobileNumber_WhenAnalyze_ReturnValid()
        {
            string mobile = "91 9919819801";
            User user = new User();
            string result = user.Mobile(mobile);
            Assert.AreEqual(result, "Valid");
        }
        [Test]
        public void GivenUserPasswordRule4_WhenAnalyze_ReturnValid()
        {
            string pass = "SOmu@2733";
            User user = new User();
            string result = user.Password(pass);
            Assert.AreEqual(result, "Valid");
        }
        [Test]
        public void GivenUserAllEmail_WhenAnalyze_ReturnValid()
        {
            string[] arr = { "abc@yahoo.com","abc-100@yahoo.com","abc.100@yahoo.com","abc111@abc.com","abc-100@abc.net","abc.100@abc.com.au","abc@1.com","abc@gmail.com.com","abc+100@gmail.com", "abc@.com.my","abc123@gmail.a","abc123@.com","abc123@.com.com",".abc@abc.com","abc()*@gmail.com","abc..2002@gmail.com","abc.@gmail.com","bc@abc@gmail.com","abc@%*.com","abc@gmail.com.1a","abc@gmail.com.aa.au"};          
            User user = new User();
            string result = user.UserAllEmail(arr);
            for (int i = 0;i < arr.Length;i++)
            {
                if (arr[i] == "Valid") 
                    Assert.AreEqual (result, "Valid");
                else
                    Assert.AreEqual (result, "InValid");
            }
        }
    }
}