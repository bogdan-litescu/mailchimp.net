using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MailChimp.Net
{
    public class MailingList
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "date_created")]
        public string DateCreated { get; set; }

        //IList<InterestGroup> _InterestGroups = null;
        //public IList<InterestGroup> InterestGroups
        //{
        //    get {
        //        if (_InterestGroups == null)
        //            _InterestGroups = Lists.GetInterestGroups(Id);
        //        return _InterestGroups;
        //    }
        //    set { _InterestGroups = value; }
        //}
    }
}
