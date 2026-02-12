using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ESerranoMVC_EF_Yakuza.Models
{
    public class Yakuza
    {
        public int Yakuza_ID { get; set; }
        public string Origin { get; set; }
        public int DataTime { get; set; }
        public int Membership { get; set; }
        public string Activities { get; set; }

        // The Yakuza Organisation
        // Origin: The Kabuki-mono, Japan
        // Date Founded: 1600s
        // Membership: 102,400
        // Activities: Extortion, Gambling, Drug Trafficking, Prostitution, Money Laundering, etc.

    }
}