using HellfireStore.Employees;
using HellfireStore.Models;
using System;

namespace HellfireStore.MIS
{
    public class App
    {
        public double Cash { get; set; }

        public void EnterProgram(Dev user, string passwd)
        {
            try
            {
                if (Authenticate(user, passwd))
                {
                    Console.WriteLine("Hello, where do you want to go? 1 - Sell Records; 2 - Register Employee; 3 - Register Supplier");
                    var option = Convert.ToInt32(Console.ReadLine());
                    if (option == 1)
                    {
                        Console.WriteLine("Which album?");
                        var title = Console.ReadLine();
                        Console.WriteLine("From which artist?");
                        var artist = Console.ReadLine();
                        Console.WriteLine("How many units in the stock this album has?");
                        var quantity = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("How many it costs?");
                        var price = Convert.ToDouble(Console.ReadLine());

                        Album album = new Album(1, title, "", artist, "", 0, quantity, price);
                        Console.WriteLine("Now, who's trying to buy?");
                        var name = Console.ReadLine();
                        Console.WriteLine("How many albums was bought by this client?");
                        var bought = Convert.ToInt32(Console.ReadLine());

                        Client client = new Client(1, name, "", bought);

                        SellRecord(album, client);

                    }
                    else if (option == 2)
                    {
                        try
                        {
                            RegisterEmployee();
                        }
                        catch (FormatException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        catch (ArgumentException e)
                        {
                            Console.WriteLine(e.Message);
                            Console.WriteLine(e.ParamName);
                        }
                        catch (Exception)
                        {
                            throw new Exception();
                        }
                    }
                    else if (option == 3)
                    {
                        RegisterSupplier();
                    }
                };

            }
            catch (ArgumentException e)
            {
                Console.WriteLine("an error has occurred with one parameter...");
                Console.WriteLine(e.ParamName);
            }
            catch (FormatException e)
            {
                Console.WriteLine("your parameter has an error type");
                Console.WriteLine(e.Message);
            }
            catch (Exception ex)
            { Console.WriteLine(ex.ToString()); }
        }

        public static bool Authenticate(Dev auth, string passwd)
        {
            bool isAuth = auth.Authenticate(passwd);
            if (isAuth)
            {
                Console.WriteLine("Authenticated!");
                return true;
            }
            else
            {
                Console.WriteLine("Wrong password.");
                return false;
            }
        }

        public void SellRecord(Album album, Client client)
        {
            Console.WriteLine($"Welcome! Do you wanna buy a record of {album.Artist}'s {album.Title}, right?");
            var op = Console.ReadLine();
            if (op == "yes" || op == "y")
            {
                Console.WriteLine("How many records do you want?");
                int amount = Convert.ToInt32(Console.ReadLine());
                if (amount <= 0)
                {
                    throw new ArgumentException($"You can't request {amount} records!", nameof(amount));
                }

                if (album.Stock > 0 && album.Stock >= amount)
                {
                    Console.WriteLine($"This album costs US${album.Price}, so it will cost US${album.Price * amount}. Can i finish this sale?");
                    var choice = Console.ReadLine();
                    if (choice == "y")
                    {
                        try
                        {
                            album.Stock -= amount;
                            Cash += album.Price * amount;
                            client.AlbumsBought++;
                            Console.WriteLine("Thank you, have a nice day!");
                        }
                        catch (ArithmeticException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ok, goodbye.");
                    }
                }
            }
            else
            {
                Console.WriteLine("Ok, goodbye.");
            }
        }

        protected void RegisterEmployee()
        {
            try
            {
                Console.WriteLine("Insert here its infos!");
                Console.WriteLine("Name:");
                string name = Console.ReadLine();
                Console.WriteLine("CPF:");
                string cpf = Console.ReadLine();
                Console.WriteLine("ID:");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Wage:");
                double wage = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Is it a dev, manager or designer?");
                var option = Console.ReadLine();
                Employee em = new Dev("", "", 1, 1);
                if (option == "dev")
                {
                    em = new Dev(name, cpf, id, wage);
                }
                else if (option == "manager")
                {
                    em = new Manager(name, cpf, id, wage);
                }
                else if (option == "designer")
                {
                    em = new Designer(name, cpf, id, wage);
                }
                Console.WriteLine($"Employee {em.Name} registered!");
                Employee.Employees++;
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        void RegisterSupplier()
        {
            try
            {
                Console.WriteLine("insert here its info!");
                Console.WriteLine("Name:");
                string name = Console.ReadLine();
                Console.WriteLine("Password:");
                string passwd = Console.ReadLine();
                Supplier s = new Supplier(name, passwd);
                Console.WriteLine($"Supplier {s.Name} registered!");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

    }
}
