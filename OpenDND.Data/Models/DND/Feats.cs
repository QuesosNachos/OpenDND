using System.Collections.Generic;
using Newtonsoft.Json;

namespace OpenDND.Data.Models.DND
{
    public class FeatsResult
    {
        [JsonProperty("slug")]
        public string Slug { get; set; }
        
        [JsonProperty("name")]
        public string Name { get; set; }
        
        [JsonProperty("desc")]
        public string Desc { get; set; }
        
        [JsonProperty("prerequisite")]
        public string Prerequisite { get; set; }
        
        [JsonProperty("document__slug")]
        public string DocumentSlug { get; set; }
        
        [JsonProperty("document__title")]
        public string DocumentTitle { get; set; }
    }

    public class FeatsRootObject
    {
        [JsonProperty("count")]
        public int Count { get; set; }
        
        [JsonProperty("next")]
        public object Next { get; set; }
        
        [JsonProperty("previous")]
        public object Previous { get; set; }
        
        [JsonProperty("results")]
        public List<FeatsResult> Results { get; set; }
    }
}