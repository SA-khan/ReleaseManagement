using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelloWorld.App_Code
{
    public class User
    {
        public string UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string UserRole { get; set; }
        public string UserStatus { get; set; }
        public string UserLoginDate { get; set; }
        public string UserWrongAttempt { get; set; }
    }
}