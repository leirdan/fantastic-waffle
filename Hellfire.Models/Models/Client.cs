namespace HellfireStore
{
    class Client
    {
        public string Name { get; set; }

        public int AlbumsBought { get; set; }

        public int GuitarsRented { get; } 

        public int ID { get; }

        public string Address { get; set; }

        public Client(int id, string name, string address, int albumsBought)
        {
            ID = id;
            Name = name;
            Address = address;
            AlbumsBought = albumsBought;
        }
    }
}
