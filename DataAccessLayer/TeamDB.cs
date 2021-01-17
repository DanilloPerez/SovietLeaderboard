using Interfaces.DALInterfaces;
using Models;
using ModelsDTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
    public class TeamDB : ITeamManagerDB,ITeamDB
    {
        private ISqlConnection sqlConnection = new ConnectionFactory().SqlConnection();
        public bool CreateTeam(TeamModel model)
        {
            List<string[]> param = new List<string[]>()
            {
              
                new string[] {"@TeamName",model.TeamName},
                new string[] {"@Teamdesc",model.TeamDescription},

            };
            sqlConnection.ExecuteNonSearchQueryParameters("INSERT INTO Teams(`TeamName`,`TeamDescription`) VALUES( @TeamName , @Teamdesc)", param);
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

        public bool AddPlayerToTeam(string UserID, string TeamID)
        {
            List<string[]> param = new List<string[]>()
            {
                new string[] {"@UserID", UserID},
                new string[] {"@TeamID", TeamID},
            };
            var result = sqlConnection.ExecuteNonSearchQueryParameters("INSERT INTO UserTeamKoppeltabel (UserID,TeamID) VALUES (@UserID, @TeamID)", param);
            return result;
        }

        public TeamModel FindTeamByID(string TeamID)
        {
            List<string[]> param = new List<string[]>()
            {
                new string[] {"@TeamID", TeamID},
            };
            var result = sqlConnection.ExecuteSearchQueryWithArrayReturn("SELECT * FROM Teams WHERE TeamID = @TeamID", param);
            if (result.Count != 0)
            {
                return GenerateDTOFromRow(result[0]);
            }
            return null;
        }
        private TeamModel GenerateDTOFromRow(string[] row)
        {
            TeamModel teamModel = new TeamModel()
            {
                TeamID = row[0],
                OwnerID = row[1],
                TeamName = row[2],
                TeamDescription = row[3],
            };
            return teamModel;
        }
    }
}
