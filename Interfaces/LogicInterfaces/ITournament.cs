using ModelsDTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.LogicInterfaces
{
    public interface ITournament
    {
        public string TournamentID { get; set; }
        public string TournamentName { get; set; }
        public int TournamentSize { get; set; }
        public List<TeamModel> TeamIDs { get; set; }
        public string TeamID { get; set; }
    }
}
