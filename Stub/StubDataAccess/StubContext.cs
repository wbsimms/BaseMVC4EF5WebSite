using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StubDataAccess.Entities;
using StubDataAccess.Repositories;
using StubDataAccess.Types;

namespace StubDataAccess
{
    public class StubContext : DbContext
    {
        public StubContext() : base("name=DefaultConnection")
        {
        }

        public DbSet<Review> Reviews { get; set;}
        public DbSet<Subject> Subjects { get; set; }

    }
}
