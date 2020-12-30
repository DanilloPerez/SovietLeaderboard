using ModelsDTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.DALInterfaces
{
   public interface IProfileDB
    {
        bool CreateProfile(ProfileModel model);
        ProfileModel GetProfile();

    }
}
