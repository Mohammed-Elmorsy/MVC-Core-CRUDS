using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVC_Core_CRUD.Models;

namespace MVC_Core_CRUD.Data
{
    public class DBContext : DbContext
    {
        public DBContext (DbContextOptions<DBContext> options)
            : base(options)
        {
        }

        public DbSet<MVC_Core_CRUD.Models.Student> Student { get; set; }
    }
}
