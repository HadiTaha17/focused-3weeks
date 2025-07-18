using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week1_day2
{
    public class GuestUser : IUserService
    {
        public void GetProfile()
        {
            Console.WriteLine("guest user is here");
        }
    }
}
