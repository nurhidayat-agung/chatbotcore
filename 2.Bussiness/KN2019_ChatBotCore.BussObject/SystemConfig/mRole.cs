using System;
using System.Collections.Generic;

namespace KN2019_ChatBotCore.BussObject.SystemConfig
{
    public partial class MRole
    {
        public int Id { get; set; }
        public string TxtRoleName { get; set; }
        public string TxtCreateBy { get; set; }
        public DateTime? DtCreateDate { get; set; }
        public string TxtUpdateBy { get; set; }
        public DateTime? DtUpdateDate { get; set; }
        public bool? BitSuperuser { get; set; }
        public bool? BitActive { get; set; }
    }
}
