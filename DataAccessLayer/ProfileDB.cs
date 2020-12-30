using Interfaces.DALInterfaces;
using ModelsDTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
    public class ProfileDB : IProfileDB
    {
        private ISqlConnection sqlConnection = new ConnectionFactory().SqlConnection();
        public bool CreateProfile(ProfileModel model)
        {
            List<string[]> param = new List<string[]>()
            {
                new string[] {"@UserID",model.UserID },
                new string[] {"@UserName",model.UserName},
                new string[] {"@Age",model.Age},
                new string[] {"@Password",model.Password},
                new string[] {"@DarkMode",model.Darkmode.ToString()},
                new string[] {"@Avatar",model.Avatar},
            };
            sqlConnection.ExecuteNonSearchQueryParameters("INSERT INTO Profile(`UserID`,`UserName`,`Age`,`Password`,`Darkmode`,`Avatar`) VALUES( @UserID , @UserName , @Age , @Password , @Darkmode, @Avatar)", param);
            return true;
        }
        public ProfileModel GetProfile()
        {
            ProfileModel Profile = new ProfileModel();
            List<string[]> result = sqlConnection.ExecuteSearchQueryWithArrayReturn("SELECT * FROM Profile", new List<string[]>());
            foreach (string[] row in result)
            {
                ProfileModel profile = new ProfileModel();
                profile.UserID = row[0].ToString();
                profile.UserName = row[1].ToString();
                profile.Age = row[2].ToString();
                profile.Password = row[3].ToString();
                profile.Darkmode = Convert.ToBoolean(Convert.ToInt32((row[4])));
                profile.Avatar = row[5].ToString();               
            }

            return Profile;
        }
    }
}
