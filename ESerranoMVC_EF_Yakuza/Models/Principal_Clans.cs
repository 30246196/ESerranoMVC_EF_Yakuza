using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ESerranoMVC_EF_Yakuza.Models
{
    public class Principal_Clans
    {
        public int Clan_Number { get; set; }
        public int Yakuza_ID { get; set; }
        public string Clan_Name { get; set; }
        public string Founding_Location { get; set; }
        public int Years_Active { get; set; }
        public string Territory { get; set; }
        public string Ethnicity { get; set; }
        public int Membership { get; set; }
        public string Criminal_Activities { get; set; }

        // Principal Clans in Yakuza:
        // 1. Yamaguchi-gumi
        // 2. Sumiyoshi-kai
        // 3. Inagawa-kai
    }
}