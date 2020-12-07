using DataAccessLayer;
using Interfaces;
using ModelsDTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogicLayer
{
    public class FriendsManager : IFriendsManager
    {
        private readonly IFriendsDB friendsDB = new DALFactory().FriendsDB();

        public FriendsModel AddFriends(FriendsModel Model)
        {
            friendsDB.AddFriend(Model);
            return Model;
        }
        public List<FriendsModel> GetFriends(FriendsModel model)
        {
            return friendsDB.GetFriends();
        }
        public void DeleteFriends(string FriendID)
        {
            friendsDB.DeleteFriends(FriendID);
        }
    }
}
