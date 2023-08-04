using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Collections.Generic;


namespace FusionDemoAPI.Helper
{
    //For GroupUser Object Serialization
    public class MembersRoot
    {
        [JsonProperty(PropertyName = "members")]
        public MemberGroups Members;
    }

    public class MemberGroups
    {
        [JsonExtensionData]
        public Dictionary<string, JToken> groups;
    }
}
