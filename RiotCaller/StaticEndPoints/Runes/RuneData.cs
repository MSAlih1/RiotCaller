﻿using Newtonsoft.Json;
using RiotCaller.StaticEndPoints.Item;
using System.Collections.Generic;

namespace RiotCaller.StaticEndPoints.Runes
{
    public class RuneData
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("image")]
        public StaticImage Image { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("rune")]
        public StaticRune Rune { get; set; }

        [JsonProperty("sanitizedDescription")]
        public string SanitizedDescription { get; set; }

        [JsonProperty("stats")]
        public StaticStats Stats { get; set; }

        [JsonProperty("tags")]
        public List<string> Tags { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}