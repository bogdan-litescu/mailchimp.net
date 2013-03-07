using MailChimp.Net.Utils;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MailChimp.Net
{
    public static class Lists
    {
        public static IList<MailingList> GetAll()
        {
            throw new NotImplementedException();
        }

        public static MailingList GetByName(string name, ApiKey apiKey = null)
        {
            return GetByProperty("list_name", name, apiKey);
        }

        public static MailingList GetById(string id, ApiKey apiKey = null)
        {
            return GetByProperty("list_id", id, apiKey);
        }

        public static MailingList GetByProperty(string propertyName, object propertyValue, ApiKey apiKey = null)
        {
            if (apiKey == null)
                apiKey = new ApiKey(); // load from config

            var data = new Dictionary<string, object>();
            data["output"] = "json";
            data["method"] = "lists";
            data["apikey"] = apiKey.ToString();
            data["filters["+propertyName+"]"] = propertyValue;

            var lists = JsonConvert.DeserializeObject<MailingListCollection>(HttpUtils.Send(apiKey.Url, data));
            if (lists != null && lists.MailingLists.Count > 0)
                return lists.MailingLists[0];
            return null;
        }

    }
}
