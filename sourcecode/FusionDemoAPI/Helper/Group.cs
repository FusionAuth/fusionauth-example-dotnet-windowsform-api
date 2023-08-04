using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
