using BakingSystemUI.Core;
using BakingSystemUI.Managers;
using BakingSystemUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BakingSystemUI.Data
{
    public class DbContext
    {
        public DbSet<User> Users;
        public DbSet<Card> Cards;

        public DbContext()
        {
            Users = new DbSet<User>();
            Cards = new DbSet<Card>();
            AddDefaultUsers();
            AddGefaultCards();
        }

        private List<User> defaultUsers = new List<User>
        {
            new User { Id = Identificator<User>.GetId(), Email = "maryam@gmail.com", Password = "123456", UserType = Roles.UserType.User },
            new User { Id = Identificator<User>.GetId(), Email = "admin@gmail.com", Password = "admin1", UserType = Roles.UserType.Admin},
            new User { Id = Identificator<User>.GetId(), Name = "Julia", Surname = "Rustamova", Age = 38, Email = "julia@gmail.com", Password = "J08101982A", UserType = Roles.UserType.User}
        };

        public void AddDefaultUsers()
        {
            Users.Add(defaultUsers[0]);
            Users.Add(defaultUsers[1]);
            Users.Add(defaultUsers[2]);
        }

        private void AddGefaultCards()
        {
            Cards.Add(new CardManager("Kapital Bank", "5", "Debet", defaultUsers[2]).GetCard());
            Cards.Add(new CardManager("BTB Bank", "1", "Scolarship", defaultUsers[0]).GetCard());
        }
    }
}
