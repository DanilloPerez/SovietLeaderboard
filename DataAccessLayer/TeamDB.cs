using Models;
using ModelsDTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
    public class TeamDB : ITeamDB
    {
        private ISqlConnection sqlConnection = new SqlConnection();
        public bool CreateTeam(TeamModel model)
        {
            List<string[]> param = new List<string[]>()
            {
                new string[] {"@TeamID",model.TeamID },
                new string[] {"@OwnerID",model.OwnerID },
                new string[] {"@TeamName",model.TeamName},
                new string[] {"@Teamdesc",model.TeamDescription},

            };
            sqlConnection.ExecuteNonSearchQueryParameters("INSERT INTO Teams(`TeamID`,`OwnerID`,`TeamName`,`TeamDescription`) VALUES( @TeamID , @OwnerID , @TeamName , @Teamdesc)", param);
            return true;
        }
        public bool EditTeam(TeamModel model)
        {
            List<string[]> param = new List<string[]>()
            {
                new string[] {"@TeamID",model.TeamID },
                new string[] {"@OwnerID",model.OwnerID },
                new string[] {"@TeamName",model.TeamName},
                new string[] {"@Teamdesc",model.TeamDescription}
            };
            sqlConnection.ExecuteNonSearchQueryParameters("UPDATE Teams SET `TeamID` = @TeamID, `OwnerID` = @OwnerID, `TeamName`= @TeamName ,`TeamDescription` = @Teamdesc WHERE `TeamID` = @TeamID", param);
            return true;
        }
        public List<TeamModel> GetTeams()
        {
            List<TeamModel> Teams = new List<TeamModel>();
            List<string[]> result = sqlConnection.ExecuteSearchQueryWithArrayReturn("SELECT * FROM Teams", new List<string[]>());
            foreach (string[] row in result)
            {
                TeamModel teams = new TeamModel();
                teams.TeamID = row[0].ToString();
                teams.OwnerID = row[1].ToString();
                teams.TeamName = row[2].ToString();
                teams.TeamDescription = row[3].ToString();

                Teams.Add(teams);
            }

            return Teams;
        }
        public void DeleteTeams(string teamID)
        {
            List<string[]> param = new List<string[]>()
            {
                new string[] { "@TeamID", teamID },
             };
            sqlConnection.ExecuteNonSearchQueryParameters("DELETE FROM Teams WHERE `TeamID` = @TeamID", param);
        }
    }
}
