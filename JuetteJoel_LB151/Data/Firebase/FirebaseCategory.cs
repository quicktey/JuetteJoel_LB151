using Firebase.Database;
using Firebase.Database.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuetteJoel_LB151.Data.Firebase
{
    public class FirebaseCategory
    {
        private const string FirebaseDatabaseUrl = "https://juettejoel-lb151-categories-default-rtdb.europe-west1.firebasedatabase.app/";
        private readonly FirebaseClient firebaseClient;

        public FirebaseCategory()
        {
            firebaseClient = new FirebaseClient(FirebaseDatabaseUrl);
        }

        public async Task<List<Category>> GetCategories()
        {
            var categories = await firebaseClient
              .Child("categories")
              .OnceAsync<Category>();

            return categories?.Select(item => new Category
            {
                categoryName = item.Object.categoryName,
            }).ToList();
        }
        
        public async Task addCategory(Category category)
        {
            await firebaseClient
              .Child("categories")
              .Child(category.categoryName)
              .PutAsync(category);
        }
    }
}
