using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSystem.BLL
{
    public class Users_List //users with admin privilages list
    {
        public string Name { get; set; }
        public string Password { get; set; }

        public Users_List(string name, string password)
        {
            Name = name;
            Password = password;
        }
    }
}
