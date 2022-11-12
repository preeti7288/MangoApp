using MangoApps_WPF_API.Helper;
using MangoApps_WPF_API.Model;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;

namespace MangoApps_WPF_API.ViewModel
{
    public class LoginViewModel : BindableBase,IDataErrorInfo
    {
        readonly string Api_key;
        public LoginViewModel()
        {
            Api_key = ConfigurationManager.AppSettings["API_KEY"]; ;
            RaiseSignINCommand = new DelegateCommand(OnSignINCommand); 
        }
        public string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }
        private  async void OnSignINCommand()
        {          
           bool result= await ApiHelper.Autheticate(DomainURL,new MsRequest(new User(Api_key, this.LoginId, Base64Encode(this.Password))));            
        }

        private string _LoginId = "";
        public string LoginId
        {
            get { return _LoginId; }
            set
            {
                this._LoginId = value;                
                RaisePropertyChanged("LoginId");
            }
        }

        private string _Password = "";
        public string Password
        {
            get { return _Password; }
            set
            {
                this._Password = value;
                RaisePropertyChanged("Password");
            }
        }


        private string _DomainURL = "";
        public string DomainURL
        {
            get { return _DomainURL; }
            set
            {
                this._DomainURL = value;               
                RaisePropertyChanged("DomainURL");
            }
        }

        private bool _CanExecute = false;
        public bool CanExecute
        {
            get { return _CanExecute; }
            set
            {
                this._CanExecute = value;
                RaisePropertyChanged("CanExecute");
            }
        }
        private bool _RememberMe = false;
        public bool RememberMe
        {
            get { return _RememberMe; }
            set
            {
                this._RememberMe = value;
                RaisePropertyChanged("RememberMe");
            }
        }
        public DelegateCommand RaiseSignINCommand { get; }

        public string this[string columnName]
        {
            get
            {
                string error = string.Empty;

                switch (columnName)
                {
                    case nameof(LoginId):
                        if(string.IsNullOrWhiteSpace(LoginId)) break;
                        if (!(LoginId?.Length > 4 && LoginId?.Length < 100))
                        {
                            error = "The LoginId must be greater than 4 and less than 100 characters.";
                            break;
                        }   
                        if (!string.Equals(LoginId, LoginId?.ToLower()))
                            LoginId = LoginId?.ToLower();
                        if (!IsValidMail(LoginId))
                        {
                            error = "invalid email";
                            break;
                        }
                        //if(error== String.Empty)
                        //{
                        //    GenerateDomainURL( LoginId);
                        //}
                        break;    
                    case nameof(Password):
                        if (string.IsNullOrWhiteSpace(Password)) break;
                        if (!(Password?.Length > 5 && Password?.Length < 25))
                        {
                            error = "The Password must be greater than 5 and less than 25 characters.";
                        }
                        break;
                }
                CanExecute = CanLoginExecute(error);
                return error;
            }
        }
        public bool CanLoginExecute(string error)
        {
         if (string.IsNullOrWhiteSpace(LoginId) ||
                string.IsNullOrWhiteSpace(Password) ||
                string.IsNullOrWhiteSpace(DomainURL) ||
                error != "") return false;
            else return true;
        }
        //private void GenerateDomainURL(string loginId)
        //{
        //    DomainURL = loginId.Substring(loginId.IndexOf("@"))
        //                .Replace(".","-")
        //                .Replace("-com",".mangopulse.com")
        //                .Replace("@","https://")
        //                .Replace("-in", ".mangopulse.com");

              
        //}

        private static bool IsValidMail(string LoginId)
        {
            string regex = @"^[^@\s]+@[^@\s]+\.(com|co.in)$";

            return Regex.IsMatch(LoginId, regex, RegexOptions.IgnoreCase);
        }
        public string Error => string.Empty;
    }
}
