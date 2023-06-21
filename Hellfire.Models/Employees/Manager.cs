using CSharpWithPOO.Employees;

namespace HellfireStore.Employees
{
    class Manager : AuthenticableEmployee
    {
        public Manager(string name, string cpf, int id, double wage) : base(name, cpf, id, wage)
        {
        }
        public override double GetBonus() { return Wage * 0.30; }

        public override void IncreaseWage()
        {
            Wage *= 1.50;
        }
    }
}
