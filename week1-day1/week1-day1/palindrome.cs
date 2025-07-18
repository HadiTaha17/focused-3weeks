using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace week1_day1
{
    [Route("api/[controller]")]
    [ApiController]
    public class palindrome : ControllerBase
    {
        [HttpGet("")]
        public Boolean IsPalindrome(String input)
        {   if(input.Length> 0)
            {
                int len = input.Length;
                for (int i = 0; i <len/2; i++)
                {
                    if (input[i] != input[len -1 -i])
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }
    }


}
