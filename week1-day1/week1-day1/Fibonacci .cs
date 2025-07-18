using Microsoft.AspNetCore.Mvc;

namespace week1_day1
{
    [Route("api/[Controller]")]
    [ApiController]
    public class Fibonacci:ControllerBase
    {
        public Fibonacci()
        {

        }
        [HttpGet("Fibonacci")]
        public List<int> getFibonacci(int count)
        {       
            List<int> fibonacci = new List<int>();
            if(count > 0)
            {
                fibonacci.Add(0);
                fibonacci.Add(1);
                for (int i = 2; i < count; i++)
                {
                    int num = fibonacci[i-1] + fibonacci[i-2];
                    fibonacci.Add(num);
                }
            }
            return fibonacci;
        }
    }
}
