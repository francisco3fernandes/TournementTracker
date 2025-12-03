using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class MatchupEntryModel
    {
        public int Id { get; set; }

        public int TeamCompetingId { get; set; }

        /// <summary>
        /// Representa uma equipa no jogo
        /// </summary>
        public TeamModel TeamCompeting { get; set; }

        /// <summary>
        /// Representa a pontuação de uma determinada equipa
        /// </summary>
        public double Score { get; set; }

        public int ParentMatchupId { get; set; }

        /// <summary>
        /// Representa o confronto de onde esta equipa saiu vencedora. 
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }
    }
}
