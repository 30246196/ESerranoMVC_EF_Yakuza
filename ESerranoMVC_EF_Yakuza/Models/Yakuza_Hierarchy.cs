using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;//added
using System.Linq;
using System.Web;

namespace ESerranoMVC_EF_Yakuza.Models
{
    public class Yakuza_Hierarchy
    {
        [Key]
        public int Entry_ID { get; set; }

        // Self-referencing parent
        [ForeignKey("Parent")]
        public int? Parent_Entry_ID { get; set; }

        // Foreign Key
        [ForeignKey("Yakuza")]
        public int Yakuza_ID { get; set; }

        public int Level_Number { get; set; }
        public string English_Entry_Name { get; set; }
        public string Japanese_Entry_Name { get; set; }

        // Levels in Yakuza Hierarchy:
        // 1. Oyabun (Boss)
        // 2. Saiko-komon (Senior Advisor)
        // 2. Wakagashira (Underboss)
        // 3. Shingiin: Law Advisor
        // 3. Shateigashira (Lieutenant)
        // 4. Kyodai ( Big Brother)
        // 4. Kaikei (Accountant)
        // 5. Shatei (Junior)

        // One Yakuza organisation has many hierarchy entries or levels.

        // NAVIGATION
        public virtual Yakuza Yakuza    { get; set; }
        public virtual Yakuza_Hierarchy Parent { get; set; } 
        public virtual ICollection<Yakuza_Hierarchy> Children { get; set; }
    }
}