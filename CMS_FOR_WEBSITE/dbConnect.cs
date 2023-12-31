﻿using CMS_FOR_WEBSITE.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;

using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CMS_FOR_WEBSITE
{
    class dbConnect:DbContext
    {
        private string Path;
        public DbSet<Machinery> Machinery { get; set; }
        public DbSet<HadImgPath> HadImgPath { get; set; }
        public DbSet<HadImgPathT> HadImgPathT { get; set; }
        public DbSet<Technic> Technic { get; set; }
        public DbSet<TechnicImg> TechnicImg { get; set; }
        public DbSet<MachinesImg> MachinesImg { get; set; }
        public DbSet<FildType> FildType { get; set; }
        public DbSet<NameofFirm> NameofFirm { get; set; }

        public dbConnect(DbContextOptions<dbConnect> options) : base(options)
        {
    
        }
        public dbConnect(string Path) { this.Path = Path;  }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlite("DataSource="+Path+"");
        }

    }
}
