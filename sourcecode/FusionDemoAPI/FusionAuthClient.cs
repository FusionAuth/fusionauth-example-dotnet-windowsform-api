using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using FusionDemoAPI.Helper;
using System.Configuration;

namespace FusionDemoAPI
{

    public class FusionAuthClient
    {
        private string FUSIONAUTH_HOST = "";
        private string CLIENT_SECRET = "";

        public FusionAuthClient()
        {
            FUSIONAUTH_HOST = ConfigurationManager.AppSettings.Get("FusionAuthUrl");
            CLIENT_SECRET = ConfigurationManager.AppSettings.Get("ClientSecret");
        }

        private HttpClient GetClient()
        {
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(FUSIONAUTH_HOST);
            httpClient.DefaultRequestHeaders.Add("Authorization", CLIENT_SECRET);
            return httpClient;
        }

       
        public async Task<ReturnValue> CreateUser(User userToCreate)
        {
            //returns HttpClient with correct setting for instance
            HttpClient httpClient = GetClient();

            //initialize the return value 
            ReturnValue returnVal = new ReturnValue()
            {
                success = false
            };

            try
            {
                //set the endpoint for creating a user
                string apiURL = $"/api/user";

                var payload = JsonConvert.SerializeObject(userToCreate);
                var content = new StringContent(payload, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await httpClient.PostAsync($"{FUSIONAUTH_HOST}{apiURL}", content);

                if (response.IsSuccessStatusCode)
                {
                    
                    string responseBody = await response.Content.ReadAsStringAsync();
                    JObject result = JObject.Parse(responseBody);
                    returnVal.success = true;
                    //assign the newly created user id to the result
                    returnVal.result = result["user"]["id"].ToString();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"There was an error in the request {ex.Message}");
                returnVal.result = ex.Message;
            }
           

            return returnVal;
        }

        public async Task<ReturnValue> DeleteUser(string userToDelete)
        {
            HttpClient httpClient = GetClient();
            ReturnValue returnVal = new ReturnValue()
            {
                success = false
            };

            try
            {
                string apiURL = $"/api/user/{userToDelete}?hardDelete=true";

                HttpResponseMessage response = await httpClient.DeleteAsync($"{FUSIONAUTH_HOST}{apiURL}").ConfigureAwait(continueOnCapturedContext: false);

                if (response.IsSuccessStatusCode)
                {

                    returnVal.success = true;
                    returnVal.result = "";
                }
                else
                {
                    returnVal.result = "";
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"There was an error in the request {ex.Message}");
                returnVal.result = ex.Message;
            }

            return returnVal;
        }

        public async Task<ReturnValue> AddUserToGroup(List<Group> groups)
        {
            //returns HttpClient with correct setting for instance
            HttpClient httpClient = GetClient();

            //initialize the return value 
            ReturnValue returnVal = new ReturnValue()
            {
                success = false
            };

            try
            {
                //set the endpoint for creating a user
                string apiURL = $"/api/group/member";

                var payload = FormatGroupUserJSON(groups);
                var content = new StringContent(payload, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await httpClient.PostAsync($"{FUSIONAUTH_HOST}{apiURL}", content);

                if (response.IsSuccessStatusCode)
                {

                    string responseBody = await response.Content.ReadAsStringAsync();
                    JObject result = JObject.Parse(responseBody);
                    returnVal.success = true;
                    returnVal.result = $"Member ID for added user: {result["members"].First().First()[0]["id"]}";
                }
                else
                {
                    returnVal.result = $"Adding user to the group failed.\nPayload\n{payload}\n{response}";
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"There was an error in the request {ex.Message}");
                returnVal.result = ex.Message;
            }


            return returnVal;
        }

        private string FormatGroupUserJSON(List<Group> groups)
        {
            string returnValue = "";

            MembersRoot memberRoot = new MembersRoot();

            Dictionary<string, JToken> memberGroupsDictionary = new Dictionary<string, JToken>();
            JArray usersToAddToGroup = new JArray();

            foreach (Group group in groups)
            {
                usersToAddToGroup.Clear();
                foreach (GroupUser groupUser in group.Users)
                {
                    GroupUser userToAdd = new GroupUser { UserID = groupUser.UserID };
                    usersToAddToGroup.Add(JObject.FromObject(userToAdd));
                }

                memberGroupsDictionary.Add(group.ID, usersToAddToGroup);
            }

            MemberGroups memberGroups = new MemberGroups();
            memberGroups.groups = memberGroupsDictionary;

            memberRoot.Members = memberGroups;

            returnValue = JsonConvert.SerializeObject(memberRoot);
            return returnValue;
        }


        public string SerializeTest(MembersRoot members)
        {
            var payload = JsonConvert.SerializeObject(members);
            return payload;
        }

        

    }
}
