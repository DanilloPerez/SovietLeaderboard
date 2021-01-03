using System;
using System.Collections.Generic;
using System.Text;

namespace ModelsDTO
{
    public class PositionModel
    {
     
        public string TournamentID { get; set; }
        public string PositionID { get; set; }
        public TeamModel team { get; set; }

    }
}
