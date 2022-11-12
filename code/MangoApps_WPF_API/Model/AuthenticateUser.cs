using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangoApps_WPF_API.Model
{
    public class MsRequest
    {
        public User user { get; set; }

        public MsRequest(User user)
        {
            this.user = user;
        }
    }

    public class AuthenticateUser
    {
        public MsRequest ms_request { get; set; }
        public AuthenticateUser(MsRequest msRequest)
        {
            this.ms_request = msRequest;
        }
    }

    public class User
    {
        public User(string api_key, string username, string password)
        {
            //{ "ms_request":{ "user":{ "api_key":"MangoWindowsMessenger",
            //                "password":"dGVtcDEyMzQ=","os_version":"10.0.19043.0",
            //                "os_name":"Windows 10","current_version":"16.0.6.0",
            //                "client_id":"Windows Messenger","device_id":"4f15b965-1c6f-1711-2fdc-d3192f2f0bba",
            //                "username":"vijayg@mangospring.com"} } }

            this.api_key = api_key;
            this.username = username;
            this.password = password;
            this.os_version = "10.0.19043.0";
            this.os_name = "Windows 10";
            this.current_version = "16.0.6.0";
            this.client_id = "Windows Messenger";
            this.device_id = "4f15b965-1c6f-1711-2fdc-d3192f2f0bba";
        }
        public string api_key { get; set; }
        public string password { get; set; }
        public string os_version { get; set; }
        public string os_name { get; set; }
        public string current_version { get; set; }
        public string client_id { get; set; }
        public string device_id { get; set; }
        public string username { get; set; }
    }

     
}
