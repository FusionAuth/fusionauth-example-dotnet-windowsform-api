using Newtonsoft.Json;

namespace FusionDemoAPI.Helper
{
    public class User
    {
        [JsonProperty(PropertyName = "user")]
        public UserProperties UserProperties;
    }

    public class UserProperties
    {
        [JsonProperty(PropertyName = "firstName")]
        public string FirstName;
        [JsonProperty(PropertyName = "lastName")]
        public string LastName;
        [JsonProperty(PropertyName = "email")]
        public string Email;
        [JsonProperty(PropertyName = "password")]
        public string Password;
    }
}
