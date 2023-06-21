namespace HellfireStore
{
    enum HandOrientation
    {
        LEFT = 0,
        RIGHT = 1,
        BOTH = 2
    }

    class Guitar
    {
        public int ID { get; }
        public string Model;
        public long ItemNumber;
        public string Brand;
        public string Color;
        public string PredominantMaterial;
        public HandOrientation HandOrientation;
        public double Price;

        public Guitar(int id, string Model, long ItemNumber, string Brand, string Color, string PredominantMaterial, HandOrientation handOrientation, double Price)
        {
            ID = id;
            this.Model = Model;
            this.ItemNumber = ItemNumber;
            this.Brand = Brand;
            this.Color = Color;
            this.Price = Price;
            this.PredominantMaterial = PredominantMaterial;
            HandOrientation = handOrientation;
        }
    }
}