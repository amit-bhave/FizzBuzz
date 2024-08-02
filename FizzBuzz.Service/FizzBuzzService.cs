using FizzBuzz.Models;

namespace FizzBuzz.Service
{
    public class FizzBuzzService : IFizzBuzzService
    {
        public List<FizzBuzzResult> GetFizzBuzzResults()
        {
            var resultlist = new List<FizzBuzzResult>();

            for (int i = 1; i <= 100; i++)
            {

                var tempresult = string.Empty;

                if (i % 3 == 0)
                {
                    tempresult = "Fizz";
                }

                if (i % 5 == 0)
                {
                    tempresult += "Buzz";
                }

                resultlist.Add(new FizzBuzzResult(i, string.IsNullOrEmpty(tempresult) ? i.ToString() : tempresult));
            }

            return resultlist;
        }
    }
}
