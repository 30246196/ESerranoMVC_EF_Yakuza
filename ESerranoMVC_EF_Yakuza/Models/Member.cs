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
        public DataType Date_Joined_Clan { get; set; }
        public DataType Date_of_Birth { get; set; }
        public DataType Date_Deceased { get; set; }
        public string Skills { get; set; }
         
        // NAVIGATION
        public virtual Principal_Clan Clan { get; set; }
    }
}