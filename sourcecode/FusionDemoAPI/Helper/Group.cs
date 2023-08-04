using Newtonsoft.Json;
using System.Collections.Generic;

namespace FusionDemoAPI.Helper
{
    //For Group object
    public class Group
    {
        public string ID;
        public List<GroupUser> Users;
    }

    public class GroupUser
    {
        [JsonProperty(PropertyName = "userId")]
        public string UserID;
    }

}
