using System;
using System.Collections.Generic;
using System.Text;

namespace ModelsDTO
{
    public class TeamModel
    {
        public List<string> UserIDs = new List<string>();
        public string TeamID { get; set; }
        public string TeamDescription { get; set; }
        public string TeamName { get; set; }
        public string OwnerID { get; set; }
        



        public TeamModel(string TeamID, string TeamDescription, string TeamName, string OwnerID, List<string> UserIDs)
        {
            this.TeamID = TeamID;
            this.TeamDescription = TeamDescription;
            this.TeamName = TeamName;
            this.OwnerID = OwnerID;
            this.UserIDs = UserIDs;
        }

        public TeamModel()
        {

        }
    }
  
}

//hurrdurr
