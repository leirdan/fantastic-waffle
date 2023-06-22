using HellfireStore.Employees;

namespace HellfireStore
{
    class BonusesManagement
    {
        public double Total { get; private set; }

        public double InsertBonus (Employee employee) {
            Total += employee.GetBonus();
            return Total;
        }

    } 
}
