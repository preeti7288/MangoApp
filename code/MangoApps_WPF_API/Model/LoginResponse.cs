using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangoApps_WPF_API.Model
{
    /// <summary>
    ///  this class will help the error response in class tree structure 
    /// </summary>
     
        public class LoginResponse
        {
            public MsErrors? ms_errors { get; set; }
        }
        public class Error
        {
            public string? message { get; set; }
            public string? error_code { get; set; }
        }

        public class MsErrors
        {
            public object? transaction_id { get; set; }
            public Error? error { get; set; }
        }

        

    
}
