using JuetteJoel_LB151.Data.Firebase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace JuetteJoel_LB151.Data
{
    public class Authentication
    {
        public async Task<bool> login(string email, string password)
        {
            FirebaseAdmin firebaseAdmin = new FirebaseAdmin();

            List<Admin> admins = await firebaseAdmin.getAdmins();

            foreach (Admin admin in admins)
            {
                string hashedPassword = computeHash(Encoding.UTF8.GetBytes(password), Encoding.UTF8.GetBytes(admin.salt));

                if (admin.password == hashedPassword && admin.email == email)
                {
                    return true;
                }
            }

            return false;
        }

        //From https://www.automationmission.com/2020/09/17/hashing-and-salting-passwords-in-c/
        private string computeHash(byte[] bytesToHash, byte[] salt)
        {
            var byteResult = new Rfc2898DeriveBytes(bytesToHash, salt, 10000);
            return Convert.ToBase64String(byteResult.GetBytes(24));
        }

        /* Um Admins hinzuzufügen
        private string GenerateSalt()
        {
            var bytes = new byte[128 / 8];
            var rng = new RNGCryptoServiceProvider();
            rng.GetBytes(bytes);
            return Convert.ToBase64String(bytes);
        }

        public async void addAdmintoDB(string email, string password)
        {
            FirebaseAdmin firebaseAdmin = new FirebaseAdmin();
            string salt = GenerateSalt();
            await firebaseAdmin.addAdmin(new Admin(email, computeHash(Encoding.UTF8.GetBytes(password), Encoding.UTF8.GetBytes(salt)), salt));
        }
        */
    }
}