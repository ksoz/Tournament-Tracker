using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentLibrary
{
    public class MatchupEntryModel
    {
        /// <summary>
        /// Represents one team in the matchup.
        /// </summary>
        public PersonModel PersonCompeting { get; set; }
        /// <summary>
        /// Represents score for this particular team.
        /// </summary>
        public double Score { get; set; }
        /// <summary>
        /// Represents the matchup that this person came from as the winner.
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }
        /// <summary>
        /// Following booleans are for different methods of victory,
        /// VictoryByPoints or Advantage occur if timer reaches 0:00 
        /// or Submission if Tournament is set to Submission only.
        /// </summary>
        public bool VictoryBySubmission { get; set; }
        public bool VictoryByPoints { get; set; }
        public bool VictoryByAdvantage { get; set; }
    }  
}
