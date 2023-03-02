using Firebase.Database;
using Firebase.Database.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuetteJoel_LB151.Data.Firebase
{
    public class FirebaseWord
    {
        private const string FirebaseDatabaseUrl = "https://juettejoel-lb151-words-default-rtdb.europe-west1.firebasedatabase.app/";
        private readonly FirebaseClient firebaseClient;

        public FirebaseWord()
        {
            firebaseClient = new FirebaseClient(FirebaseDatabaseUrl);
        }
        public async Task<List<Word>> getWords()
        {
            var words = await firebaseClient
              .Child("words")
              .OnceAsync<Word>();

            return words?.Select(item => new Word
            {
                word = item.Object.word,
                category = item.Object.category,
            }).ToList();
        }

        public async Task addWord(Word word)
        {
            await firebaseClient
              .Child("words")
              .Child(word.word)
              .PutAsync(word);
        }

        public async Task removeWord(Word word)
        {
            await firebaseClient
              .Child("words")
              .Child(word.word)
              .DeleteAsync();
        }

        public async Task updateWordCategory(Word word)
        {
            await firebaseClient
              .Child("words")
              .Child(word.word)
              .PutAsync(word);
        }

        public async Task updateWordName(Word word, string name)
        {
            await removeWord(word);
            word.word = name;
            await firebaseClient
              .Child("words")
              .Child(word.word)
              .PutAsync(word);
        }
    }
}