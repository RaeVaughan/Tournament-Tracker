using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class PrizeModel
    {
        /// <summary>
        /// Represents the place for which a specific prize is awarded
        /// </summary>
        public int PlaceNumber { get; set; }
        /// <summary>
        /// Represents the name of the place for which a specific prize is awarded
        /// </summary>
        public string PlaceName { get; set; }
        /// <summary>
        /// Represents the total amount of a prize
        /// </summary>
        public decimal PrizeAmount { get; set; }
        /// <summary>
        /// Represents the percentage of the prize amount
        /// </summary>
        public double PrizePercentage { get; set; }
    }
}
