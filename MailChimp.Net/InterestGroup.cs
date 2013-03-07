using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace MailChimp.Net
{
    public class InterestGroup
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "groups")]
        public IList<Interest> Interests { get; set; }
    }

    public class Interest
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "subscribers")]
        public int SubscriberCount { get; set; }
    }

}
