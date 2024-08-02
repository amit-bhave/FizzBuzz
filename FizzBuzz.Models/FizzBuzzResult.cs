namespace FizzBuzz.Models
{
    public class FizzBuzzResult
    {
        public int FizzBuzzNumber { get; set; }
        public string FizzBuzzResultText { get; set; }
        public FizzBuzzResult(int fizzbuzznumber, string fizzbuzzresulttext)
        {
            FizzBuzzNumber = fizzbuzznumber;
            FizzBuzzResultText = fizzbuzzresulttext;
        }
    }
}
