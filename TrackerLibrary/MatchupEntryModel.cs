using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class MatchupEntryModel
    {
        /// <summary>
        /// Representa uma equipa no jogo
        /// </summary>
        public TeamModel TeamCompeting { get; set; }

        /// <summary>
        /// Representa a pontuação de uma determinada equipa
        /// </summary>
        public double Score { get; set; }

        /// <summary>
        /// Representa o confronto de onde esta equipa saiu vencedora. 
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }
    }
}
