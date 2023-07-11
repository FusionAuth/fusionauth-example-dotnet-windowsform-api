using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FusionDemoAPI
{
    public class Helper
    {

        //For User object
        public class User
        {
            [JsonProperty(PropertyName = "user")]
            public UserProperties UserProperties;
        }

        public class UserProperties
        {
            [JsonProperty(PropertyName = "firstname")]
            public string FirstName;
            [JsonProperty(PropertyName = "lastname")]
            public string LastName;
            [JsonProperty(PropertyName = "email")]
            public string Email;
            [JsonProperty(PropertyName = "password")]
            public string Password;
        }

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

        //For information returned from a call
        public class ReturnValue
        {
            public bool success;
            public string result;
        }

    }
}
