using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class TournamentModel
    {
        /// <summary>
        /// Represents the name of a tournament
        /// </summary>
        public string TournamentName { get; set; }
        /// <summary>
        /// Represents the cost of tournament entry
        /// </summary>
        public decimal EntryFee { get; set; }
        /// <summary>
        /// Represents an array of teams entered to participate in a tournament
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();
        /// <summary>
        /// Represents an array of prizes that can be won
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();
        /// <summary>
        /// Represents an array of matchups inside an array of rounds 
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();
    }
}
