using ModelsDTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
    public class FriendsDB : IFriendsDB
    {
        
        private ISqlConnection sqlConnection = new ConnectionFactory().SqlConnection();
        public bool AddFriend(FriendsModel model)
        {
            List<string[]> param = new List<string[]>()
            {
                new string[] {"@UserID",model.UserID },
                new string[] {"@FriendID",model.FriendID},

            };
            sqlConnection.ExecuteNonSearchQueryParameters(" INSERT INTO Friends (`FriendID`,`UserID`) VALUES ( @FriendID , @UserID )", param);
            return true;
        }

        public List<FriendsModel> GetFriends()
        {
            List<FriendsModel> Friends = new List<FriendsModel>();
            List<string[]> result = sqlConnection.ExecuteSearchQueryWithArrayReturn("SELECT * FROM Friends", new List<string[]>());
            foreach (string[] row in result)
            {
                FriendsModel friends = new FriendsModel();
                friends.FriendID = row[0].ToString();
                friends.UserID = row[1].ToString();


                Friends.Add(friends);
            }

            return Friends;
        }
        public void DeleteFriends(string FriendID)
        {
            List<string[]> param = new List<string[]>()
            {
                new string[] { "@FriendID", FriendID },
             };
            sqlConnection.ExecuteNonSearchQueryParameters("DELETE FROM Friends WHERE `FriendID` = @FriendID", param);
        }
    }
}
