﻿using System;
using System.Security.AccessControl;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NorthwindEntities.Concrete;

namespace Northwind.DataAccess.Concrete.EntityFramework
{
    public class NorthwindContext:DbContext
    {
        public DbSet <Product> Products { get; set; }
        public DbSet<Category> Categories{ get; set; }

    }
}
