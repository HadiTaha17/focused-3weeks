using week1_day2;

namespace TestProject_day2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
           
            User user = new User();
            AdminUser admin = new AdminUser();
            GuestUser guest = new GuestUser();
            user.GetProfile();
            admin.GetProfile();
            guest.GetProfile();
        }
    }
}