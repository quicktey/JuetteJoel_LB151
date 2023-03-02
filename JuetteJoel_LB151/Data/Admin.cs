using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuetteJoel_LB151.Data
{
    public class Admin
    {
        public string email { get; set; }
        public string password { get; set; }
        public string salt { get; set; }

        public Admin() { }
        public Admin(string email, string password, string salt)
        {
            this.email = email;
            this.password = password;
            this.salt = salt;
        }
    }
}