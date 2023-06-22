using System;

namespace HellfireStore.Models
{
    public class Album : IDisposable
    {
        public int ID { get; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Artist { get; set; }
        public string Country { get; set; }
        public double Weight { get; set; }
        public int Stock { get; set; }
        public double Price { get; set; }

        public Album(int id, string title, string description, string artist, string country, double weight, int quantity, double price)
        {
            ID = id;
            Title = title;
            Description = description;
            Artist = artist;
            Country = country;
            Weight = weight;
            Stock = quantity;
            Price = price;
        }

        public void Dispose()
        {
            Console.WriteLine("bye bye baby !");
        }
    }
}
