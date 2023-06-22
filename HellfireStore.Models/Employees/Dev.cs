namespace HellfireStore.Employees
{ 
   public class Dev : AuthenticableEmployee
   {
        public Dev(string name, string cpf, int id, double wage) : base(name, cpf, id, wage)
        {
        }

        internal protected override double GetBonus()
        {
            return Wage * 0.25;
        }

        public override void IncreaseWage()
        {
            Wage *= 1.25;
        }
    }
}
