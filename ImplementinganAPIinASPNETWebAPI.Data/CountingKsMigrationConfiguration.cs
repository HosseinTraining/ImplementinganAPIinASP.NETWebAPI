using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementinganAPIinASPNETWebAPI.Data
{
    public class CountingKsMigrationConfiguration : DbMigrationsConfiguration<CountingKsContext>
    {
        public CountingKsMigrationConfiguration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(CountingKsContext context)
        {
            base.Seed(context);
        }
    }
}
