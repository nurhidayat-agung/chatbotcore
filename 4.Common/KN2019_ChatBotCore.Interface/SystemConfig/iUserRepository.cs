using KN2019_ChatBotCore.BussObject.SystemConfig;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace KN2019_ChatBotCore.Interface.SystemConfig
{
    public interface iUserRepository
    {
        Task<MUser> getById(int id);
        Task<int> Persist(MUser user);
    }
}
