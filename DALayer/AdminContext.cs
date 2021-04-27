using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALayer
{
    class AdminContext : DbContext
    {

        public DbSet<Admin> Admins { get; set; }
    }
}
