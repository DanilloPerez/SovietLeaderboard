﻿using ModelsDTO;
using System.Collections.Generic;

namespace DataAccessLayer
{
    public interface ILeaderboardDB
    {
        bool AddLeaderBoard(LeaderboardModel model);
        
        void DeleteLeaderBoard(string leaderboardID);
        bool EditLeaderBoard(LeaderboardModel model);
       
        List<LeaderBoardEntryModel> GetLeaderBoardEntries(string LeaderboardID);
       
        List<LeaderboardModel> GetLeaderBoards();
       
    }
}