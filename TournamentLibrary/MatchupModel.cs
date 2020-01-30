using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentLibrary
{
    public class MatchupModel
    {
        /// <summary>
        /// List of Persons that are matched against each other.
        /// </summary>
        public List<PersonModel> Entries { get; set; } = new List<PersonModel>();
        public PersonModel Winner { get; set; }
        
    }
}
