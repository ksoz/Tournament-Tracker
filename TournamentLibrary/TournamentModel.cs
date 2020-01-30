using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentLibrary
{
    class TournamentModel
    {
        public string TournamentName { get; set; }
        /// <summary>
        /// Total number of people competing against in the tournament.
        /// </summary>
        public List<PersonModel> EnteredPersons { get; set; } = new List<PersonModel>();
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();
        /// <summary>
        /// Total number of rounds/matches in the tournament.
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();
        public Boolean SubmissionOnly { get; set; }
    }
}
