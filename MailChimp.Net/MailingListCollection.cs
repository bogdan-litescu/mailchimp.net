using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MailChimp.Net
{
    public class MailingListCollection
    {
        public MailingListCollection()
        {
            MailingLists = new List<MailingList>();
        }

        [JsonProperty(PropertyName = "data")]
        public IList<MailingList> MailingLists { get; set; }

    }
}
