using HellfireStore.Models;
using System;
using System.Collections.Generic;

namespace HellfireStore
{
    public class Account
    {
        public Client Client;
        public DateTime Created_At = DateTime.Now;
        public double? Discount;
        public List<Guitar> guitarsRented;
        public static int AccountsCreated { get; private set; }

        public Account(Client client, DateTime created_At, double? discount, List<Guitar> guitarsRented)
        {
            Client = client;
            Created_At = created_At;
            Discount = discount;
            this.guitarsRented = guitarsRented;
            
            AccountsCreated++;
        }

    }
}
