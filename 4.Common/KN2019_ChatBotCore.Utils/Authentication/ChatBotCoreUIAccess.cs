using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc.Filters;

namespace KN2019_ChatBotCore.Utils.Authentication
{
    public class ChatBotCoreUIAccess : ActionFilterAttribute
    {
        private string COOKIE_USER_ACCESS = Constant.COOKIE_USER_ACCESS;
        private ICookieManager _cookieManager;
        //private ICMSUserTokenRepository _cmsUserTokenRepo;
        //private IConfigCreator _config;
    }
}
