using ModelsDTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.DALInterfaces
{
   public interface IProfileManagerDB
    {
        bool CreateProfile(ProfileModel model);
        ProfileModel GetProfile(string userID);
        void DeleteProfile(string userID);

    }
}
