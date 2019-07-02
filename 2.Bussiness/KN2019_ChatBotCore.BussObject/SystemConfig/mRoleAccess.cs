using System;
using System.Collections.Generic;

namespace KN2019_ChatBotCore.BussObject.SystemConfig
{
    public partial class MRoleAccess
    {
        public int Id { get; set; }
        public int? IntRoleId { get; set; }
        public int? IntModuleId { get; set; }
        public bool? BitEdit { get; set; }
        public bool? BitView { get; set; }
        public bool? BitDelete { get; set; }
        public bool? BitPrint { get; set; }
        public string TxtCreateBy { get; set; }
        public DateTime? DtCreateDate { get; set; }
        public string TxtUpdateBy { get; set; }
        public DateTime? DtUpdateDate { get; set; }
        public bool? BitActive { get; set; }
    }
}
