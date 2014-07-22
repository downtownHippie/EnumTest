using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EnumTest
{
    public class Context : DbContext
    {
        public Context()
            : base("Context")
        {
            Database.SetInitializer<Context>(new ContextInitialzer());
        }

        public DbSet<Entity> Entities { get; set; }
    }
}