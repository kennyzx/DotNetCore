using System;
using System.Collections.Generic;

namespace ASPNETCoreMVC
{
    public partial class Users
    {
        public int Userid { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Emailaddress { get; set; }
        public sbyte? Active { get; set; }
    }
}
