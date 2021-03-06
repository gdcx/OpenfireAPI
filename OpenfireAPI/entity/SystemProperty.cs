﻿using Newtonsoft.Json;
using RestSharp.Deserializers;

namespace OpenfireAPI.entity
{
    public class SystemProperty
    {
        [JsonProperty("@key")]
        [DeserializeAs(Name = "@key")]
        public string key { get; set; }

        [JsonProperty("@value")]
        [DeserializeAs(Name = "@value")]
        public string value { get; set; }

        public override string ToString()
        {
            return "key: " + key + " ,value: " + value + "\n";
        }
    }
}
