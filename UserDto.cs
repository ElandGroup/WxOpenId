using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WxOpenId
{
    public class UserDto
    {
        public string Access_token { get; set; }
        public string Expires_in { get; set; }
        public string OpenId { get; set; }
        public string Refresh_token { get; set; }
        public string Scope { get; set; }
    }
}