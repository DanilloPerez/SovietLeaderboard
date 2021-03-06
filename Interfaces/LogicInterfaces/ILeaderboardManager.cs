﻿using ModelsDTO;
using System.Collections.Generic;

namespace Interfaces
{
    public interface ILeaderboardManager
    {
        LeaderboardModel AddLeaderBoard(LeaderboardModel leaderboardModel);
        void DeleteLeaderBoard(string leaderboardID);
        LeaderboardModel EditLeaderBoard(LeaderboardModel leaderboardModel);
        List<LeaderBoardEntryModel> GetLeaderBoardEntries(string LeaderBoardID);
        List<LeaderboardModel> GetLeaderBoards();
    }
}