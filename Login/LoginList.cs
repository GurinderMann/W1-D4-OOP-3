using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    public class LoginList
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public DateTime AccessTime { get; set; }
        public LoginList(string username, DateTime accessTime)
        {
            UserName = username;
            AccessTime = accessTime;
        }
    }
}
