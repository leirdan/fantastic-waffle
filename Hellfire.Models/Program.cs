using System;
using HellfireStore;
using HellfireStore.Employees;
using HellfireStore.MIS;

internal class Program
{
        #region old
        //var guitarsRented = new List<Guitar>
        //{
        //    new Guitar(1, "Stratocaster", 02485132, "Fender", "Sonic Gray", "Poplar", HandOrientation.LEFT, 199.0),
        //    new Guitar(2, "Les Paul", 2648502, "Michael", "Wine red", "Tília", HandOrientation.RIGHT, 300.0)
        //};

        //Account nergal = new Account
        //    (
        //    new Client(1, "Adam 'Nergal' Michal Darski", "Ocean Boulevard", 14),
        //    DateTime.Now,
        //    0,
        //    guitarsRented
        //);

        //Account andy = new Account(
        //    new Client(-1, "Andrew 'Andy Leo' Rockhold", "Central Park", 6),
        //    DateTime.Now,
        //    0.10,
        //    null
        //);

        //Console.WriteLine(Account.AccountsCreated); // 2

        //Manager dio = new Manager("Ronnie James Dio", "032-412-666-09", 1, 6666.00);
        //Console.WriteLine(dio.Name);
        //Console.WriteLine(dio.GetBonus());

        //Dev zayn = new Dev("Zayn Malik", "935-102-305-23", 3, 5000.00);
        //Console.WriteLine(zayn.Name);
        //Console.WriteLine(zayn.GetBonus());

        //Designer louis = new Designer("Louis Tomlinson", "759-246-784-36", 4, 3500.00);
        //Console.WriteLine(louis.Name);
        //Console.WriteLine(louis.GetBonus());

        //var ctrl = new BonusesManagement();
        //ctrl.InsertBonus(dio);
        //ctrl.InsertBonus(louis);
        //ctrl.InsertBonus(zayn);

        //Console.WriteLine("Total de bônus: " + ctrl.Total);
        //Console.WriteLine("Total de funcionários: {0}", Employee.Employees);
        #endregion
        #region auth
        //Console.WriteLine("Quem está tentando entrar? 1 - Dev, 2 - Manager, 3 - Supplier");
        //int opc = Convert.ToInt32(Console.ReadLine());
        
        //if (opc == 1)
        //{
        //    Console.WriteLine("Insira os seus dados!");
        //    Console.WriteLine("CPF: ");
        //    var cpf = Console.ReadLine();
        //    Console.WriteLine("Nome: ");
        //    var name = Console.ReadLine();

        //    Dev dev = new Dev(name, cpf, 0, 0)
        //    {
        //        Passwd = "temp123"
        //    };
        //    Console.WriteLine("Digite a senha: ");
        //    string p = Console.ReadLine();
        //    EnterSystem(dev, p);
        //}
        //else if (opc == 2)
        //{
        //    Console.WriteLine("Insira os seus dados!");
        //    Console.WriteLine("CPF: ");
        //    var cpf = Console.ReadLine();
        //    Console.WriteLine("Nome: ");
        //    var name = Console.ReadLine();

        //    Manager man = new Manager(name, cpf, 0, 0)
        //    {
        //        Passwd = "temp123"
        //    };
        //    Console.WriteLine("Digite a senha: ");
        //    string p = Console.ReadLine();
        //    EnterSystem(man, p);
        //}
        //else if (opc == 3)
        //{
        //    Supplier sup = new Supplier()
        //    {
        //        Passwd = "temp123"
        //    };
        //    Console.WriteLine("Digite a senha: ");
        //    string p = Console.ReadLine();
        //    EnterSystem(sup, p);
        //}
        //else
        //{
        //    Console.WriteLine("Tal opção não existe!");
        //}
        #endregion
            #region exception1
            //Console.WriteLine("Insira os dados do álbum: ");
            //Console.Write("Título:");
            //var title = Console.ReadLine();
            //Console.Write("Descrição:");
            //var description = Console.ReadLine();
            //Console.Write("Origem:");
            //var country = Console.ReadLine();
            //Console.Write("Peso:");
            //var weight = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Quantidade em estoque:");
            //var quantity = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Preço:");
            //var price = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Dias da última compra:");
            //var daysLastPurchase = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Desconto:");
            //var discount = Convert.ToDouble(Console.ReadLine());

            //var album = new Album(
            //    title, description, country, weight, quantity, price, daysLastPurchase, discount
            //);
            //Console.WriteLine(album.Title);
            //Console.WriteLine(album.Quantity);
            #endregion
    static void Main(string[] args)
    {
        App app = new App();
        var user = new Dev("nergal", "666-666-666-66", 1, 5000.00)
        {
            Passwd = "temp123"
        };
        app.EnterProgram(user, "temp123");
        Console.WriteLine("Press key to continue...");
        Console.ReadKey();
    }
}
