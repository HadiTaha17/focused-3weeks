using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace week1_day1
{
    [Route("api/[controller]")]
    [ApiController]
    public class Prime : ControllerBase
    {
        [HttpGet]
        public List<int> GetPrime(int start , int end)
        {   
            if (start <= 0 && end <= 0)
            {
                return null;
            }
            List<int> primes = new List<int>();
            for (int i = start; i < end;i++)
            {
                if (isPrime(i))
                {
                    primes.Add(i);
                }
            }
            return primes;
        }

        public Boolean isPrime(int num)
        {   if(num <= 1)
            {
                return false;
            }
            for(int j=2; j <= Math.Sqrt(num); j++)
            {
                if(num % j ==0)  //check if have divisors if yes so isnt prime because prime numbers have 1 and itself
                {
                    return false;
                }
            }
            return true;
        }
    }
}
