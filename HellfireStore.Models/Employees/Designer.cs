namespace HellfireStore.Employees
{
    class Designer : Employee
    {
        public Designer(string name, string cpf, int id, double wage) : base (name, cpf, id, wage)
        {
        }

        internal protected override double GetBonus()
        {
            return Wage * 0.15;
        }
        public override void IncreaseWage()
        {
            Wage *= 1.15;
        }
    }
}
