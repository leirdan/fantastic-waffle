using HellfireStore.MIS;

namespace HellfireStore.Employees
{
    public abstract class AuthenticableEmployee : Employee, IAuthController
    {
        protected AuthenticableEmployee(string name, string cpf, int id, double wage) : base(name, cpf, id, wage)
        {
        }
        public string Passwd { protected get; set; }
        public bool Authenticate(string passwd)
        {
            return Passwd == passwd;
        }
    }
}
