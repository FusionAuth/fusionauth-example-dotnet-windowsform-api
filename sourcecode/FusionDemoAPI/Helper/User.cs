using Newtonsoft.Json;

namespace FusionDemoAPI.Helper
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
}
