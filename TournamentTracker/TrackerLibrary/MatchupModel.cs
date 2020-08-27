using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    /// <summary>
    /// Represents one match in the tournament
    /// </summary>
    public class MatchupModel
    {
        /// <summary>
        /// An array of teams entered in this match
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();
        /// <summary>
        /// The team that wins this match
        /// </summary>
        public TeamModel Winner { get; set; }
        /// <summary>
        /// Which round this match is played in
        /// </summary>
        public int MatchupRound { get; set; }
    }
}
