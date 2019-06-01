using InstagramApiSharp.API;
using InstagramApiSharp.API.Builder;
using InstagramApiSharp.Classes;
using InstagramApiSharp.Logger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstaCheeze
{
    public class User
    {
        //Singleton instance of api
        private static IInstaApi _InstaApi;
        private static UserSessionData userSessionData = new UserSessionData();

        public string Username { get; set; }

        public string Password { get; set; }

        //Clears the username and password field when Remember Me is unticked
        //Only triggers when then login button is fired
        public static void ClearDefault()
        {
            Properties.Settings.Default.Reset();
        }

        public void SetUserSessionData()
        {
            userSessionData.UserName = Username;
            userSessionData.Password = Password;
            
        }

        //Instantiate api
        //function returns created api if it is instantiated before
        public static IInstaApi SessionApiBuilder()
        {
           if(_InstaApi != null)
                return _InstaApi;
            else
            {
                _InstaApi = InstaApiBuilder.CreateBuilder().SetUser(userSessionData)
                   .UseLogger(new DebugLogger(LogLevel.Exceptions))
                   .SetRequestDelay(RequestDelay.FromSeconds(0, 1))
                   .Build();

                return _InstaApi;
            }
        }
    }
}
