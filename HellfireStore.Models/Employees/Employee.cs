using System;

namespace HellfireStore.Employees
{
    public abstract class Employee
    {
        public int ID { get; }
        public string Name { get; set; }
        public string CPF { get; private set; }
        public double Wage { get; protected set; }

        public static int Employees;

        public abstract void IncreaseWage();

        // Internal protected é 1 modificador de acesso (não 2) que indica que o método é acessível em todo o projeto (HellfireStore.Models) e em quaisquer classes fora deste que o implementem.
        internal protected abstract double GetBonus();

        public Employee(string name, string cpf, int id, double wage)
        {
            if (id <= 0)
            {
                throw new ArgumentException("ID inválido!", nameof(id));
            }
            
            if (name == "")
            {
                throw new ArgumentException("Nome inválido!", nameof(name));
            }
            ID = id;
            Name = name;
            CPF = cpf;
            Wage = wage;
            Employees++;
        }
        
    }
}
