using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Spotivy
{
    public class User
    {
        public int amountOfUsers = 0;
        public string Username;
        private int Id;
        private int Followers;
        private int Following;
        private List<User> Users;

        public void createUser(string username)
        {
            this.Username = username;
            this.Id = amountOfUsers;
            this.amountOfUsers++;

            Console.WriteLine(this.Username + " (" + this.Id + ") aangemaakt.");
        }

        public int getUserAmount()
        {
            return this.amountOfUsers;
        }
    }
}
