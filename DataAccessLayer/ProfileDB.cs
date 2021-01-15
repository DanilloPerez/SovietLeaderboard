using Interfaces.DALInterfaces;
using ModelsDTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
    public class ProfileDB : IProfileManagerDB
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
        public ProfileModel GetProfile(string userID)
        {
            List<string[]> param = new List<string[]>()
            {
                new string[] { "@UserID", userID },
             };
            
            List<string> UserProfile = sqlConnection.ExecuteSearchQueryParameters("SELECT * FROM Profile WHERE `UserID` = @UserID", param);

            ProfileModel profile = new ProfileModel();
                profile.UserID = UserProfile[0].ToString();
                profile.UserName = UserProfile[1].ToString();
                profile.Age = UserProfile[5].ToString();
                profile.Password = UserProfile[2].ToString();
                profile.Darkmode = Convert.ToBoolean(Convert.ToInt32((UserProfile[4])));
                profile.Avatar = UserProfile[3].ToString();               
            
            return profile;
        }
        public void DeleteProfile(string userID)
        {
            List<string[]> param = new List<string[]>()
            {
                new string[] { "@UserID", userID },
             };
            sqlConnection.ExecuteNonSearchQueryParameters("DELETE FROM Profile WHERE `UserID` = @UserID", param);
        }

       
    }
}
