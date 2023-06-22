namespace HellfireStore.MIS
{
    class Supplier : IAuthController
    {
        public string Name { get; set; }
        public string Passwd { protected get; set; }
        public Supplier(string name, string passwd)
        {
            Name = name; 
            Passwd = passwd;
        }
        public bool Authenticate(string passwd)
        {
            return this.Passwd == passwd;
        }
    }
}