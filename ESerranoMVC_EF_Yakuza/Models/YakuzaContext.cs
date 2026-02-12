using System;// Brings in basic .NET types like String, INt32, DateTime,...
using System.Collections.Generic;// Let's us use generic collections like List<T> and ICollections<T>
using System.Data.Entity;// imports Entity Framework types: DbContext and DbSet<>.
using System.Linq;// enables LINQ queries(.Where(...), Select(...)) on collections and DbSets
using System.Web;//provides ASP>NET web-related types , used in this MVC project

namespace ESerranoMVC_EF_Yakuza.Models
{
    public class YakuzaContext:DbContext // inherits from DbContext, which is the core EF class that represents a session with the db.The YakuzaContext is the bridge between C# classes and tables in the db.
    {
        public YakuzaContext(): base("YakuzaConnection") { } // added when <connectionStrings> is added in Web.config

        public DbSet<Yakuza> Yakuza { get; set; } // Yakuza is the table of Yakuza records.
        public DbSet<Principal_Clan> PrincipalClans { get; set; }// PrincipalClans is the table for Principal_Clan entities
        public DbSet<Member> Members { get; set; }// Members is the table for Member entities
        public DbSet<Yakuza_Hierarchy> YakuzaHierarchies { get; set; }// YakuzaHierarchies is the table for Yakuza_Hierarcy entities

        // this method lets customise how EF builds the model (tables relationships, keys)
        // EF passes in a builder object  
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Yakuza_Hierarchy has a self-join: optional parent, many children, using Parent_Entry_ID as the FK.
            // Self-referencing hierarchy
            modelBuilder.Entity<Yakuza_Hierarchy>()// start configuring the Yakuza_Hierarchy
                .HasOptional(h => h.Parent) //each Yakuza_Hierarchy row may or may not have a parent (nullable FK) is optional
                .WithMany(h => h.Children)//  one parent can have many children, points to the Children Collection navigation in the same class
                .HasForeignKey(h => h.Parent_Entry_ID);// this links a child row to its parent row in the same table 

            base.OnModelCreating(modelBuilder);// calls the base DbContext implementation so EF can apply its default conventions.
        }
    }
}