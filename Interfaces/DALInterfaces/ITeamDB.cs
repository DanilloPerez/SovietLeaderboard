using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.DALInterfaces
{
    public interface ITeamDB
    {
        bool AddPlayerToTeam(string UserID, string TeamID);
    }
}
