using System;
using System.Collections.Generic;

namespace KN2019_ChatBotCore.BussObject.SystemConfig
{
    public partial class MUser
    {
        public int Id { get; set; }
        public string TxtUserName { get; set; }
        public string TxtNick { get; set; }
        public string TxtEmpId { get; set; }
        public string TxtEmail { get; set; }
        public int? IntDepartmentId { get; set; }
        public int? IntLobid { get; set; }
        public string TxtCompanyCode { get; set; }
        public bool? BitActive { get; set; }
        public string TxtDomainName { get; set; }
        public bool? BitUseActiveDirectory { get; set; }
        public string TxtPassword { get; set; }
        public string TxtCreateBy { get; set; }
        public DateTime? DtCreateDate { get; set; }
        public string TxtUpdateBy { get; set; }
        public DateTime? DtUpdateDate { get; set; }
    }
}
