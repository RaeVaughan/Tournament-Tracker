using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class PersonModel
    {
        /// <summary>
        /// Represents the first name of a team member
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Represents the last name of a team member
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Represents the email address for a team member
        /// </summary>
        public string EmailAddress { get; set; }
        /// <summary>
        /// Represents the phone number for a team member
        /// </summary>
        public string CellphoneNumber { get; set; }
    }
}
