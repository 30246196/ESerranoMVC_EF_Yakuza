using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ESerranoMVC_EF_Yakuza.Models
{
    public class Yakuza
    {
        [Key]
        public int Yakuza_ID { get; set; }

        public string Origin { get; set; }
        public int Creation { get; set; } // year of creation a integer
        public int Membership { get; set; }
        public string Activities { get; set; }

        // The Yakuza Organisation
        // Origin: The Kabuki-mono, Japan
        // Date Founded: 1600s
        // Membership: 102,400
        // Activities: Extortion, Gambling, Drug Trafficking, Prostitution, Money Laundering, etc.

        // ONE TO MANY
        // One Yakuza has many Principal Clans
        // Each Clan belongs to exactly one Yakuza
        public virtual ICollection<Principal_Clan> Principal_Clans { get; set; }
    }
}