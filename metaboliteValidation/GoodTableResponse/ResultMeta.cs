﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metaboliteValidation.GoodTableResponse
{
    public class ResultMeta
    {
        [JsonProperty("")]
        public Dictionary<string, ResultContext> obj { get; set; }
    }
}