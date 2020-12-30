using Interfaces.DALInterfaces;
using Interfaces.LogicInterfaces;
using ModelsDTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogicLayer
{
    public class ProfileManager : IProfileManager
    {
        private readonly IProfileDB profileDB = new DALFactory().profileDB();

        public ProfileModel CreateProfile(ProfileModel createprofileModel)
        {
            profileDB.CreateProfile(createprofileModel);
            return createprofileModel;
        }
        public ProfileModel GetProfile(string userID)
        {
            
            return profileDB.GetProfile(userID);
        }
        public void DeleteProfile(string userID)
        {
            profileDB.DeleteProfile(userID);
        }

    }
}
