using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ESerranoMVC_EF_Yakuza.Models
{
    public class YakuzaDbInitializer: DropCreateDatabaseIfModelChanges<YakuzaContext>
    {
        // If the model changes->drop the DB-> recreate it
        protected override void Seed(YakuzaContext context)
        {
            // Step 7 : Seed the Database

            // -----------------------------
            // 1. Seed Yakuza Organisations 
            // -----------------------------
            var y1 = new Yakuza
            {
                Yakuza_ID = 1,
                Origin = "Kabuki-mono, Japan",
                Creation = 1600,
                Membership = 102400,
                Activities = "Extortion, Gambling, Drug Trafficking, Prostitution, Money Laundering"
            };

            var y2 = new Yakuza
            {
                Yakuza_ID = 2,
                Origin = "Yamaguchi-gumi",
                Creation = 1915,
                Membership = 20000,
                Activities = "Crime,..."
            };

            var y3 = new Yakuza
            {
                Yakuza_ID = 3,
                Origin = "Tokyo, Japan",
                Creation = 1958,
                Membership = 30000,
                Activities = "Fraud, Money Laundering, Cybercrime" };

            
            var y4 = new Yakuza
            { 
                Yakuza_ID = 4,
                Origin = "Sumiyoshi-kai",
                Creation = 1958,
                Membership = 20000,
                Activities = "Crime,..."
            };
           
            context.Yakuza.Add(y1);
            context.Yakuza.Add(y2);
            context.Yakuza.Add(y3);
            context.Yakuza.Add(y4);

            // -----------------------------
            // 2. Seed Principal Clans
            // -----------------------------
            var clan1 = new Principal_Clan
            {
                Clan_Number = 1,
                Clan_Name = "Kobe Headquarters",
                Founding_Location = "Kobe",
                Years_Active = 100,
                Territory = "Kansai",
                Ethnicity = "Japanese",
                Membership = 6000,
                Criminal_Activities = "Extortion, Gambling",
                Yakuza_ID = 1
            };

            var clan2 = new Principal_Clan
            {
                Clan_Number = 2,
                Clan_Name = "Tokyo Branch",
                Founding_Location = "Tokyo",
                Years_Active = 60,
                Territory = "Kanto",
                Ethnicity = "Japanese",
                Membership = 3000,
                Criminal_Activities = "Fraud, Money Laundering",
                Yakuza_ID = 2
            };
            
            context.PrincipalClans.Add(clan1);
            context.PrincipalClans.Add(clan2);

            // -----------------------------
            // 3. Seed Members 
            // -----------------------------

            var members = new List<Member>
            { new Member { Member_ID = 3, Clan_Number = 1, Family_Name = "Nakamura", Personal_Name = "Taro", Date_of_Birth = 1975, Date_Joined_Clan = 1995, Date_Deceased = null, Skills = "Logistics", Level_Number = 4, Japanese_Entry_Name = "Kyodai" },
                new Member { Member_ID = 4, Clan_Number = 1, Family_Name = "Suzuki", Personal_Name = "Ichiro", Date_of_Birth = 1982, Date_Joined_Clan = 2001, Date_Deceased = null, Skills = "Enforcement", Level_Number = 5, Japanese_Entry_Name = "Shatei" },
                new Member { Member_ID = 5, Clan_Number = 1, Family_Name = "Watanabe", Personal_Name = "Daichi", Date_of_Birth = 1970, Date_Joined_Clan = 1990, Date_Deceased = null, Skills = "Finance", Level_Number = 4, Japanese_Entry_Name = "Kaikei" },
                new Member { Member_ID = 6, Clan_Number = 1, Family_Name = "Kobayashi", Personal_Name = "Ren", Date_of_Birth = 1995, Date_Joined_Clan = 2015, Date_Deceased = null, Skills = "Surveillance", Level_Number = 5, Japanese_Entry_Name = "Shatei" },
                new Member { Member_ID = 7, Clan_Number = 1, Family_Name = "Saito", Personal_Name = "Haruto", Date_of_Birth = 1988, Date_Joined_Clan = 2008, Date_Deceased = null, Skills = "Negotiation", Level_Number = 3, Japanese_Entry_Name = "Shateigashira" },
                new Member { Member_ID = 8, Clan_Number = 2, Family_Name = "Yamamoto", Personal_Name = "Kaito", Date_of_Birth = 1983, Date_Joined_Clan = 2003, Date_Deceased = null, Skills = "Cybercrime", Level_Number = 4, Japanese_Entry_Name = "Kyodai" },
                new Member { Member_ID = 9, Clan_Number = 2, Family_Name = "Ishikawa", Personal_Name = "Sora", Date_of_Birth = 1992, Date_Joined_Clan = 2012, Date_Deceased = null, Skills = "Intelligence", Level_Number = 5, Japanese_Entry_Name = "Shatei" },
                new Member { Member_ID = 10, Clan_Number = 2, Family_Name = "Fujimoto", Personal_Name = "Akira", Date_of_Birth = 1978, Date_Joined_Clan = 1998, Date_Deceased = null, Skills = "Accounting", Level_Number = 4, Japanese_Entry_Name = "Kaikei" },
                new Member { Member_ID = 11, Clan_Number = 2, Family_Name = "Takeda", Personal_Name = "Minato", Date_of_Birth = 1986, Date_Joined_Clan = 2006, Date_Deceased = null, Skills = "Strategy", Level_Number = 3, Japanese_Entry_Name = "Shingiin" },
                new Member { Member_ID = 12, Clan_Number = 2, Family_Name = "Ota", Personal_Name = "Riku", Date_of_Birth = 1994, Date_Joined_Clan = 2014, Date_Deceased = null, Skills = "Recruitment", Level_Number = 5, Japanese_Entry_Name = "Shatei" },
                new Member { Member_ID = 13, Clan_Number = 1, Family_Name = "Kondo", Personal_Name = "Sho", Date_of_Birth = 1981, Date_Joined_Clan = 2000, Date_Deceased = null, Skills = "Weapons Handling", Level_Number = 5, Japanese_Entry_Name = "Shatei" },
                new Member { Member_ID = 14, Clan_Number = 1, Family_Name = "Aoki", Personal_Name = "Yuta", Date_of_Birth = 1977, Date_Joined_Clan = 1997, Date_Deceased = null, Skills = "Legal Knowledge", Level_Number = 3, Japanese_Entry_Name = "Shingiin" },
                new Member { Member_ID = 15, Clan_Number = 1, Family_Name = "Mori", Personal_Name = "Kazuki", Date_of_Birth = 1989, Date_Joined_Clan = 2009, Date_Deceased = null, Skills = "Extortion", Level_Number = 4, Japanese_Entry_Name = "Kyodai" },
                new Member { Member_ID = 16, Clan_Number = 1, Family_Name = "Endo", Personal_Name = "Yoshio", Date_of_Birth = 1991, Date_Joined_Clan = 2011, Date_Deceased = null, Skills = "Cybersecurity", Level_Number = 5, Japanese_Entry_Name = "Shatei" },
                new Member { Member_ID = 17, Clan_Number = 1, Family_Name = "Hasegawa", Personal_Name = "Jun", Date_of_Birth = 1984, Date_Joined_Clan = 2004, Date_Deceased = null, Skills = "Money Laundering", Level_Number = 4, Japanese_Entry_Name = "Kaikei" },
                new Member { Member_ID = 18, Clan_Number = 2, Family_Name = "Nakajima", Personal_Name = "Leo", Date_of_Birth = 1985, Date_Joined_Clan = 2005, Date_Deceased = null, Skills = "Fraud", Level_Number = 4, Japanese_Entry_Name = "Kyodai" },
                new Member { Member_ID = 19, Clan_Number = 2, Family_Name = "Okada", Personal_Name = "Shin", Date_of_Birth = 1993, Date_Joined_Clan = 2013, Date_Deceased = null, Skills = "Drug Distribution", Level_Number = 5, Japanese_Entry_Name = "Shatei" },
                new Member { Member_ID = 20, Clan_Number = 2, Family_Name = "Hayashi", Personal_Name = "Toma", Date_of_Birth = 1987, Date_Joined_Clan = 2007, Date_Deceased = null, Skills = "Negotiation", Level_Number = 3, Japanese_Entry_Name = "Shateigashira" },
                new Member { Member_ID = 21, Clan_Number = 2, Family_Name = "Kato", Personal_Name = "Issei", Date_of_Birth = 1996, Date_Joined_Clan = 2016, Date_Deceased = null, Skills = "Recruitment", Level_Number = 5, Japanese_Entry_Name = "Shatei" },
                new Member { Member_ID = 22, Clan_Number = 2, Family_Name = "Ueda", Personal_Name = "Makoto", Date_of_Birth = 1979, Date_Joined_Clan = 1999, Date_Deceased = null, Skills = "Finance", Level_Number = 4, Japanese_Entry_Name = "Kaikei" } };

            members.ForEach(m => context.Members.Add(m));

            var m1 = new Member
            {
                Member_ID = 1,
                Clan_Number = 1,
                Family_Name = "Tanaka",
                Personal_Name = "Kenji",
                Date_Joined_Clan= 2000,
                Date_of_Birth = 1980,
                Date_Deceased = null,
                Skills = "Negotiation, Strategy",
                Level_Number = 4,
                Japanese_Entry_Name = "Kyodai" //Big Brother
                
            };
            
            var m2 = new Member
            {
                Member_ID = 2,
                Clan_Number = 2,
               Personal_Name = "Hiroshi",
                Family_Name = "Sato",
                Date_Joined_Clan = 2010,
                Date_of_Birth = 1990,
                Date_Deceased = null,
                Skills = "Finance, Intelligence Gathering",
                Level_Number = 4,
                Japanese_Entry_Name = "Shatei" // Junior

            };
            
            context.Members.Add(m1);
            context.Members.Add(m2);

            // -----------------------------
            // 4. Seed Yakuza Hierarchy 
            // -----------------------------

            // 1. Oyabun (Boss)
             var h1 = new Yakuza_Hierarchy
             {
                 Entry_ID = 1,
                 Parent_Entry_ID = null,
                 Yakuza_ID = 1,
                 Level_Number = 1,
                 English_Entry_Name = "Boss",
                 Japanese_Entry_Name = "Oyabun"
             };
            // 2. Saiko-komon (Senior Advisor)
            var h2 = new Yakuza_Hierarchy
            {
                Entry_ID = 2,
                Parent_Entry_ID = 1,
                Yakuza_ID = 1,
                Level_Number = 2,
                English_Entry_Name = "Senior Advisor",
                Japanese_Entry_Name = "Saiko-komon"
            };

            // 2. Wakagashira (Underboss)
            var h3 = new Yakuza_Hierarchy
            {
                Entry_ID = 3,
                Parent_Entry_ID = 1,
                Yakuza_ID = 1,
                Level_Number = 2,
                English_Entry_Name = "Underboss",
                Japanese_Entry_Name = "Wakagashira"
            };

            // 3. Shingiin (Law Advisor)
            var h4 = new Yakuza_Hierarchy
            { 
                Entry_ID = 4,
                Parent_Entry_ID = 3,
                Yakuza_ID = 1,
                Level_Number = 3,
                English_Entry_Name = "Law Advisor",
                Japanese_Entry_Name = "Shingiin"
            };

            // 3. Shateigashira (Lieutenant)
            var h5 = new Yakuza_Hierarchy
            {
                Entry_ID = 5,
                Parent_Entry_ID = 3,
                Yakuza_ID = 1,
                Level_Number = 3,
                English_Entry_Name = "Lieutenant",
                Japanese_Entry_Name = "Shateigashira"
            };
            
            // 4. Kyodai (Big Brother)
            var h6 = new Yakuza_Hierarchy
            {
                Entry_ID = 6,
                Parent_Entry_ID = 5,
                Yakuza_ID = 1,
                Level_Number = 4,
                English_Entry_Name = "Senior Member",
                Japanese_Entry_Name = "Kyodai"
            };

            // 4. Kaikei (Accountant)
            var h7 = new Yakuza_Hierarchy
            {
                Entry_ID = 7,
                Parent_Entry_ID = 5,
                Yakuza_ID = 1,
                Level_Number = 4,
                English_Entry_Name = "Accountant",
                Japanese_Entry_Name = "Kaikei"
            };
            
            // 5. Shatei (Junior)
            var h8 = new Yakuza_Hierarchy
            {
                Entry_ID = 8,
                Parent_Entry_ID = 6,
                Yakuza_ID = 1,
                Level_Number = 5,
                English_Entry_Name = "Junior Member",
                Japanese_Entry_Name = "Shatei"
            };

            // 5. Minarai (Apprentice)
            var h9 = new Yakuza_Hierarchy
            {
                Entry_ID = 9,
                Parent_Entry_ID = 8,
                Yakuza_ID = 1,
                Level_Number = 5,
                English_Entry_Name = "Apprentice",
                Japanese_Entry_Name = "Minarai"
            };
            
            // Extra Advisor (Komon)
            var h10 = new Yakuza_Hierarchy
            {
                Entry_ID = 10,
                Parent_Entry_ID = 1,
                Yakuza_ID = 1,
                Level_Number = 2,
                English_Entry_Name = "Advisor",
                Japanese_Entry_Name = "Komon"
            };

            context.YakuzaHierarchies.Add(h1);
            context.YakuzaHierarchies.Add(h2);
            context.YakuzaHierarchies.Add(h3);
            context.YakuzaHierarchies.Add(h4);
            context.YakuzaHierarchies.Add(h5);
            context.YakuzaHierarchies.Add(h6);
            context.YakuzaHierarchies.Add(h7);
            context.YakuzaHierarchies.Add(h8);
            context.YakuzaHierarchies.Add(h9);
            context.YakuzaHierarchies.Add(h10);

            // Levels in Yakuza Hierarchy:
            // 1. Oyabun (Boss)
            // 2. Saiko-komon (Senior Advisor)
            // 2. Wakagashira (Underboss)
            // 3. Shingiin: Law Advisor
            // 3. Shateigashira (Lieutenant)
            // 4. Kyodai ( Big Brother)
            // 4. Kaikei (Accountant)
            // 5. Shatei (Junior)

            // ----------------------------- 
            // Save all changes
            // -----------------------------
            context.SaveChanges();

            base.Seed(context);
        }
    }
}