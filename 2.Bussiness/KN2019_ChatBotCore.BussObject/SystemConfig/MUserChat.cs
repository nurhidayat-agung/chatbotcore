using System;
using System.Collections.Generic;

namespace KN2019_ChatBotCore.BussObject.SystemConfig
{
    public partial class MUserChat 
    {
        public int Id { get; set; }
        public string TxtUserId { get; set; }
        public string TxtName { get; set; }
        public string TxtGender { get; set; }
        public string TxtEmail { get; set; }
        public string TxtSection { get; set; }
        public bool? BitShpempl { get; set; }
        public bool? BitActive { get; set; }
        public string TxtCreateBy { get; set; }
        public DateTime? DtCreateDate { get; set; }
        public string TxtUpdateBy { get; set; }
        public DateTime? DtUpdateDate { get; set; }
    }
}
