﻿using Newtonsoft.Json;

// ReSharper disable once CheckNamespace
namespace Meetup.Api
{
    public class Member
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("member_id")]
        public int MemberId { get; set; }
    }
}