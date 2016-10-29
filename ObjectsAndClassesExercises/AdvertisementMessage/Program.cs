using System;


namespace AdvertisementMessage
{
   public class Program
    {
        public static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            string[] phrases = {"Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product." };
            string[] events = {"Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!"};
            string[] author = {"Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"};
            string[] cities = {"Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"};
            for (int i = 0; i < input; i++)
            {                
                int iPhrase = rnd.Next(0, phrases.Length);
                int iEvent = rnd.Next(0, events.Length);
                int iAuthor = rnd.Next(0, author.Length);
                int iCities = rnd.Next(0, cities.Length);
                Console.WriteLine("{0} {1} {2} - {3}", phrases[iPhrase], events[iEvent], author[iAuthor], cities[iCities]);
            }
        }
    }
}
