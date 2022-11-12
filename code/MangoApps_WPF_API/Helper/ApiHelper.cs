using ControlzEx.Standard;
using MangoApps_WPF_API.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MangoApps_WPF_API.Helper
{
    public class ApiHelper
    {
        public static async Task<bool> Autheticate(string url, MsRequest MsRequest)
        {
            using (HttpClient client = new HttpClient())
            {

                client.BaseAddress = new Uri(url);
                client.DefaultRequestHeaders
                      .Accept
                      .Add(new MediaTypeWithQualityHeaderValue("application/json")); 
                HttpRequestMessage request = new HttpRequestMessage();
                HttpResponseMessage response = await client.SendAsync(request);


                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    AuthenticateUser LoginRequest = new AuthenticateUser(MsRequest);
                    var json = JsonConvert.SerializeObject(LoginRequest);
                    request.Content = new StringContent(json,Encoding.UTF8, "application/json"); 

                    response = await client.PostAsync("api/login.json", request.Content);
                    response.EnsureSuccessStatusCode();

                    string result = await response.Content.ReadAsStringAsync();
                    if (result != String.Empty)
                    {
                        if (!result.Contains("user"))
                        {
                            LoginResponse? loginResponse = JsonConvert.DeserializeObject<LoginResponse>(result);
                            MessageBox.Show(loginResponse.ms_errors.error.message.ToString(), "Error",MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                        else
                        {
                            MessageBox.Show("Successful Login");
                         
                        }
                        
                    }
                    return  true;
                }
                else return InvalidDomainURL();
            }
        }

      
         private static bool InvalidDomainURL()
        {
            MessageBoxResult messageBoxResult = MessageBox.Show("We were unable to reach the server or it did not properly respond. \n \n \n " +
                       "Kindly verify the following and try again: \n" +
                       "1. Your Domain URL  is correct (e.g. https://demo.mangoapps.com) \n" +
                       "2. You are connected to the Internet \n" +
                       "3. The proxy setting are configured correctly in Preferences" +
                       " (id you use a proxy to connect to the internet) \n" +
                       "4. Server may be temporary down. Please re-try in a few minutes.", "Unable to connect", MessageBoxButton.OK, MessageBoxImage.Error);
            return false;
        }
    }
}
