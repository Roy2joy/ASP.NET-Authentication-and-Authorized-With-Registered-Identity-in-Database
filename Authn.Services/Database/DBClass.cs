//using Authn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;
using Authn.Services;
//using Authn.Data;

namespace Authn.Database
{
    public class DBClass : DbContext
    {
        public DBClass() : base()
        {

        }


        public DbSet<AppUser> AppUsers
        {
            set;
            get;
        }


    }
}
