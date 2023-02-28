using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Firebase.Database;
using Firebase.Database.Query;
using System.Collections.Generic;

namespace JuetteJoel_LB151.Data.Firebase
{
    public class FirebaseAdmin
    {
        private const string FirebaseDatabaseUrl = "https://juettejoel-lb151-admins-default-rtdb.europe-west1.firebasedatabase.app/";
        private readonly FirebaseClient firebaseClient;

        public FirebaseAdmin()
        {
            firebaseClient = new FirebaseClient(FirebaseDatabaseUrl);
        }

        public async Task<List<Admin>> getAdmins()
        {
            var words = await firebaseClient
              .Child("admins")
              .OnceAsync<Admin>();

            return words?.Select(item => new Admin
            {
                email = item.Object.email,
                password = item.Object.password,
                salt = item.Object.salt,
            }).ToList();
        }
        /* Zum Admins hinzuzufügen
        public async Task addAdmin(Admin admin)
        {
            await firebaseClient
              .Child("admins")
              .PostAsync(admin);
        }
        */
    }
}