using System;
using System.Collections.Generic;
using System.Text;

namespace KN2019_ChatBotCore.BussObject.master
{
    public class mChatDetail : mBussinesBase
    {
        public string txtUserID { get; set; }
        public string txtMessage { get; set; }
        public Nullable<int> intOrigin { get; set; }
        public Nullable<int> intOrder { get; set; }
    }
}
