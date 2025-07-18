using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week1_day2
{
    public class AdminUser : IUserService
    {
        public void GetProfile()
        {
            Console.WriteLine("admin user is here");
        }
    }
}
