namespace HellfireStore.MIS
{
    class Supplier : IAuthController
    {
        public string Name { get; set; }
        public string Passwd { protected get; set; }
        public bool Authenticate(string passwd)
        {
            return this.Passwd == passwd;
        }
    }
}