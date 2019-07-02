using KN2019_ChatBotCore.BussObject.SystemConfig;
using KN2019_ChatBotCore.Interface.SystemConfig;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace KN2019_ChatBotCore.DataAccess.SystemConfig
{
    public class UserRepository : iUserRepository
    {
        public Task<MUser> getById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> Persist(MUser user)
        {
            throw new NotImplementedException();
        }
    }
}
