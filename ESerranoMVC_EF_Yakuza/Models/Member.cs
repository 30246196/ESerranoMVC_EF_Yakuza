using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;// added to ForeignKey
using System.Linq;
using System.Web;

namespace ESerranoMVC_EF_Yakuza.Models
{
    public class Member
    {
        [Key]
        public int Member_ID { get; set; }
        [Required]
        [ForeignKey("Clan")]
        public int Clan_Number { get; set; }

        public string Family_Name { get; set; }
        public string Personal_Name { get; set; }

        public int Date_Joined_Clan { get; set; }
        public int Date_of_Birth { get; set; }
        public int? Date_Deceased { get; set; }

        public string Skills { get; set; }

        public int Level_Number { get; set; }
        public string Japanese_Entry_Name { get; set; }
        
         
        // NAVIGATION
        public virtual Principal_Clan Clan { get; set; }
    }
}
// Levels in Yakuza Hierarchy:
// 1. Oyabun (Boss)
// 2. Saiko-komon (Senior Advisor)
// 2. Wakagashira (Underboss)
// 3. Shingiin: Law Advisor
// 3. Shateigashira (Lieutenant)
// 4. Kyodai ( Big Brother)
// 4. Kaikei (Accountant)
// 5. Shatei (Junior)