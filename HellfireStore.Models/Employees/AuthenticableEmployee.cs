using HellfireStore.MIS;
using HellfireStore.Models.Helpers;

namespace HellfireStore.Employees
{
    public abstract class AuthenticableEmployee : Employee, IAuthController
    {
        protected AuthenticableEmployee(string name, string cpf, int id, double wage) : base(name, cpf, id, wage)
        {
        }
        public string Passwd { protected get; set; }
        private AuthHelper _authHelper = new AuthHelper();
        public bool Authenticate(string passwd)
        {
            return _authHelper.ComparePasswd(this.Passwd, passwd);
        }
    }
}
