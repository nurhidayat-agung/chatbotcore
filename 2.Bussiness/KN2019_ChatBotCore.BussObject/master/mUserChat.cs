using System;
using System.Collections.Generic;
using System.Text;

namespace KN2019_ChatBotCore.BussObject.master
{
    public class mUserChat : mBussinesBase
    {
        public string txtUserID { get; set; }
        public string txtName { get; set; }
        public string txtGender { get; set; }
        public string txtEmail { get; set; }
        public string txtSection { get; set; }
        public Nullable<bool> bitSHPEmpl { get; set; }
    }
}
