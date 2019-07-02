﻿using System;
using System.Collections.Generic;

namespace KN2019_ChatBotCore.BussObject.SystemConfig
{
    public partial class MSystemConfiguration
    {
        public string Id { get; set; }
        public string TxtKeyId { get; set; }
        public int? IntModuleId { get; set; }
        public string TxtDescription { get; set; }
        public string TxtDefaultValue { get; set; }
        public string TxtValue { get; set; }
        public string TxtCreateBy { get; set; }
        public DateTime? DtCreateDate { get; set; }
        public string TxtUpdateBy { get; set; }
        public DateTime? DtUpdateDate { get; set; }
        public bool? BitActive { get; set; }
    }
}
