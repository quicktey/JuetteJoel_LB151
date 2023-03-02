using Firebase.Database;
using Firebase.Database.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuetteJoel_LB151.Data.Firebase
{
    public class FirebaseScoreboard
    {
        private const string FirebaseDatabaseUrl = "https://juettejoel-lb151-scoreboard-default-rtdb.europe-west1.firebasedatabase.app/";
        private readonly FirebaseClient firebaseClient;

        public FirebaseScoreboard()
        {
            firebaseClient = new FirebaseClient(FirebaseDatabaseUrl);
        }
        public async Task<List<ScoreboardEntry>> getScoreboardEntries()
        {
            var scoreboardEntries = await firebaseClient
              .Child("scoreboardEntries")
              .OnceAsync<ScoreboardEntry>();

            return scoreboardEntries?.Select(item => new ScoreboardEntry
            {
                playerName = item.Object.playerName,
                dateTime = item.Object.dateTime,
                score = item.Object.score,
                playedRounds = item.Object.playedRounds,
            }).ToList();
        }

        public async Task addScoreboardEntry(ScoreboardEntry scoreboardEntry)
        {
            await firebaseClient
              .Child("scoreboardEntries")
              .Child(scoreboardEntry.playerName)
              .PutAsync(scoreboardEntry);
        }

        public async Task removeScoreboardEntry(ScoreboardEntry scoreboardEntry)
        {
            await firebaseClient
              .Child("scoreboardEntries")
              .Child(scoreboardEntry.playerName)
              .DeleteAsync();
        }
    }
}