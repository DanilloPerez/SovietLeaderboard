using ModelsDTO;
using System.Collections.Generic;

namespace DataAccessLayer
{
    public interface IFriendsDB
    {
        bool AddFriend(FriendsModel model);
        void DeleteFriends(string FriendID);
        List<FriendsModel> GetFriends();
    }
}