using LALHDomain.EntityModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace LALHData.Context
{
    public class LALetterHeadDBcontext : DbContext
    {
        public LALetterHeadDBcontext(DbContextOptions options) : base(options){}

        public DbSet<MasterEmployee> MasterEmployee { get; set; }
        public DbSet<UserManager> UserManager { get; set; }
        public DbSet<WinAppMap> WinAppMap { get; set; }

    }
}
