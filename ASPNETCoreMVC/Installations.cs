using System;
using System.Collections.Generic;

namespace ASPNETCoreMVC
{
    public partial class Installations
    {
        public string Version { get; set; }
        public DateTime Installationdate { get; set; }
        public int Userid { get; set; }
        public string Userdomain { get; set; }
        public uint Id { get; set; }
    }
}
