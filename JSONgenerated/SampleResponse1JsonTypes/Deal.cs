﻿// Generated by Xamasoft JSON Class Generator
// http://www.xamasoft.com/json-class-generator

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Example.SampleResponse1JsonTypes;

namespace Example.SampleResponse1JsonTypes
{

    internal class Deal
    {

        [JsonProperty("Description")]
        public string Description { get; set; }

        [JsonProperty("DiscountPercent")]
        public string DiscountPercent { get; set; }

        [JsonProperty("QualifyingPrice")]
        public string QualifyingPrice { get; set; }
    }

}