using ModelsDTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.LogicInterfaces
{
    public interface IProfileManager
    {
        ProfileModel CreateProfile(ProfileModel model);
        ProfileModel GetProfile(string userID);
        void DeleteProfile(string userID);

    
    }
}
