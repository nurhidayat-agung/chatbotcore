using System;
using System.Collections.Generic;

namespace KN2019_ChatBotCore.BussObject.SystemConfig
{
    public partial class MChatDetail
    {
        public int Id { get; set; }
        public string TxtUserId { get; set; }
        public string TxtMessage { get; set; }
        public int? IntOrigin { get; set; }
        public int? IntOrder { get; set; }
        public bool? BitActive { get; set; }
        public string TxtCreateBy { get; set; }
        public DateTime? DtCreateDate { get; set; }
        public string TxtUpdateBy { get; set; }
        public DateTime? DtUpdateDate { get; set; }
    }
}
