using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace C48_G03_EF01
{
    internal class AddDbContect : DbContext
    {
        //Override -> OnConfiguring
         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=EF01;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}
