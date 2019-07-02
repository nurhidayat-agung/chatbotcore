using System;
using System.Collections.Generic;

namespace KN2019_ChatBotCore.BussObject.SystemConfig
{
    public partial class MMenu
    {
        public int Id { get; set; }
        public int? IntParentId { get; set; }
        public string TxtMenuName { get; set; }
        public string TxtDescription { get; set; }
        public int? IntModuleId { get; set; }
        public string TxtLink { get; set; }
        public int? IntOrderId { get; set; }
        public bool? BitActive { get; set; }
        public string TxtCreateBy { get; set; }
        public DateTime? DtCreateDate { get; set; }
        public string TxtUpdateBy { get; set; }
        public DateTime? DtUpdateDate { get; set; }
    }
}
