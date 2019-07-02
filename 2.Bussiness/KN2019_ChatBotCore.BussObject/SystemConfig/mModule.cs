using System;
using System.Collections.Generic;

namespace KN2019_ChatBotCore.BussObject.SystemConfig
{
    public partial class MModule
    {
        public int Id { get; set; }
        public string TxtModuleName { get; set; }
        public string TxtDescription { get; set; }
        public string TxtCreateBy { get; set; }
        public DateTime? DtCreateDate { get; set; }
        public string TxtUpdateBy { get; set; }
        public DateTime? DtUpdateDate { get; set; }
        public bool? BitActive { get; set; }
    }
}
