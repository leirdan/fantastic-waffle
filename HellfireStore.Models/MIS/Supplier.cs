using HellfireStore.Models.Helpers;

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

        private AuthHelper _authHelper = new AuthHelper();
        public bool Authenticate(string passwd)
        {
            return _authHelper.ComparePasswd(this.Passwd, passwd);
        }
    }
}