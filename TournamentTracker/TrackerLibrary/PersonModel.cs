using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    /// <summary>
    /// Represents one person
    /// </summary>
    public class PersonModel
    {
        /// <summary>
        /// Represents the first name of this team member
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// The last name of this team member
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// The email address for this team member
        /// </summary>
        public string EmailAddress { get; set; }
        /// <summary>
        /// The phone number for this team member
        /// </summary>
        public string CellphoneNumber { get; set; }
    }
}
