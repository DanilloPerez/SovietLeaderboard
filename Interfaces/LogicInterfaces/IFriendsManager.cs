using ModelsDTO;
using System.Collections.Generic;

namespace LogicLayer
{
    public interface IFriendsManager
    {
        FriendsModel AddFriends(FriendsModel Model);
        void DeleteFriends(string FriendID);
        List<FriendsModel> GetFriends(FriendsModel model);
    }
}