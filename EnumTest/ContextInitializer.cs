using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EnumTest
{
    public class ContextInitialzer : System.Data.Entity.CreateDatabaseIfNotExists<Context>
    {
        protected override void Seed(Context context)
        {
            var entities = new List<Entity>()
            {
                new Entity {
                    //Stuff = Stuff.A,
                    OtherStuff = 1
                },
                new Entity {
                    //Stuff = Stuff.B,
                    OtherStuff = 2
                },
                new Entity {
                    //Stuff = Stuff.C,
                    OtherStuff = 3
                }
            };
            entities.ForEach(e => context.Entities.Add(e));
            context.SaveChanges();
        }
    }
}