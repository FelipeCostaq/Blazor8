namespace Blazor8.Models
{
    public class RandomNumber
    {
        public int numberIdentify {get; set;}

        public RandomNumber()
        {
            Random rdn = new Random();
            numberIdentify = rdn.Next(0, 10_000);
        }
    }
}
