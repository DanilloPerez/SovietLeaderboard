using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
   public class TeamDB
    {
        private SqlConnection sqlConnection = new SqlConnection();
        public bool AddTeam(TeamModel model)
        {
            List<string[]> param = new List<string[]>()
            {
                new string[] {"@TeamID",model.TeamID },
                new string[] {"@TeamName",model.TeamName},
                new string[] {"@Teamdesc",model.TeamDescription}
            };
            sqlConnection.ExecuteNonSearchQueryParameters(" INSERT INTO Teams ('TeamID','TeamName','TeamDescription') VALUES ( @TeamID , @TeamName , @Teamdesc )", param);
            return true;
        }
    }
}
