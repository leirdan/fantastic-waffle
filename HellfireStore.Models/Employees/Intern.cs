using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HellfireStore.Employees
{
    internal class Intern : Employee
    {
        public Intern(string name, string cpf, int id, double wage) : base(name, cpf, id, wage)
        {
        }

        internal protected override double GetBonus()
        {
            return Wage * 0.5;
        }

        public override void IncreaseWage()
        {
            Wage *= 1.05;
        }
    }
}
