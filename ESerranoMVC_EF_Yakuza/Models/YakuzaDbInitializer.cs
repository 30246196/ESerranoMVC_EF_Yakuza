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
            base.Seed(context);
        }
    }
}