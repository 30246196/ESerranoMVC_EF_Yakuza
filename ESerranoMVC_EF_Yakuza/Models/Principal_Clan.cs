using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ESerranoMVC_EF_Yakuza.Models
{
    public class Principal_Clan
    {
        [Key]
        public int Clan_Number { get; set; }
        [Required]
        [ForeignKey("Yakuza")]
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

        // NAVIGATION
        public Yakuza Yakuza { get; set; }

        // ONE TO MANY MEMBERS
        // One (Principal) Clan has many members
        // Each member belongs to a (Principal) Clan
        public virtual ICollection<Member> Members { get; set; } // check
    }
}