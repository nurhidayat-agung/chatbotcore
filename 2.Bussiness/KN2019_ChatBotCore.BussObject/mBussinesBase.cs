using System;

namespace KN2019_ChatBotCore.BussObject
{
    public class mBussinesBase
    {
        public int? Id { get; set; }
        public string TxtCreateBy { get; set; }
        public DateTime? DtCreateDate { get; set; }
        public string TxtUpdateBy { get; set; }
        public DateTime? DtUpdateDate { get; set; }
        public bool? BitActive { get; set; }
    }
}
