using DataAccessLayer;
using Interfaces.DALInterfaces;
using ModelsDTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogicLayer.Profile
{
    public class Profile : IProfile
    {
        IProfileManagerDB profileDB = new ProfileDB();


        public string UserID { get; set; }
        public string UserName { get; set; }
        public bool Darkmode { get; set; }
        public string Age { get; set; }
        public string Password { get; set; }
        public string Avatar { get; set; }


        public Profile(ProfileModel profilemodel)
        {
            UserID = profilemodel.UserID;
            UserName = profilemodel.UserName;
            Darkmode = profilemodel.Darkmode;
            Age = profilemodel.Age;
            Password = profilemodel.Password;
            Avatar = profilemodel.Avatar;


        }
        public Profile()
        {

        }

    }
}
    