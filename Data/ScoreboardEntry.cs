using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuetteJoel_LB151.Data
{
    public class ScoreboardEntry
    {
        public string playerName { get; set; }
        public DateTime dateTime { get; set; }
        public int score { get; set; }
        public int playedRounds { get; set; }

        public ScoreboardEntry() { }

        public ScoreboardEntry(string playerName, DateTime dateTime, int score, int playedRounds)
        {
            this.playerName = playerName;
            this.dateTime = dateTime;
            this.score = score;
            this.playedRounds = playedRounds;
        }
    }
}