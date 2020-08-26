using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class MatchupModel
    {
        /// <summary>
        /// Represents an array of entries in a matchup
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();
        /// <summary>
        /// Represents the team that wins a matchup
        /// </summary>
        public TeamModel Winner { get; set; }
        /// <summary>
        /// Represents which round the matchup is played in
        /// </summary>
        public int MatchupRound { get; set; }
    }
}
