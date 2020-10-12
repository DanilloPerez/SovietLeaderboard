using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class TeamModel
    {
        public string TeamID { get; set; }
        public string TeamDescription { get; set; }
        public string TeamName { get; set; }



        public TeamModel(string TeamID, string TeamDescription, string TeamName)
        {
            this.TeamID = TeamID;
            this.TeamDescription = TeamDescription;
            this.TeamName = TeamName;
        }
    }
}

//hurrdurr
