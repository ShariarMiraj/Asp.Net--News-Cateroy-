﻿using DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CnContext : DbContext
    {

        public DbSet<News> News { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
