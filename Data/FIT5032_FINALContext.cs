using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FIT5032_FINAL.Data
{
    public class FIT5032_FINALContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public FIT5032_FINALContext() : base("name=FIT5032_FINALContext")
        {
        }

        public System.Data.Entity.DbSet<FIT5032_FINAL.Models.Student> Students { get; set; }

        public System.Data.Entity.DbSet<FIT5032_FINAL.Models.Group> Groups { get; set; }

        public System.Data.Entity.DbSet<FIT5032_FINAL.Models.Location> Locations { get; set; }

        public System.Data.Entity.DbSet<FIT5032_FINAL.Models.Image> Images { get; set; }
    }
}
