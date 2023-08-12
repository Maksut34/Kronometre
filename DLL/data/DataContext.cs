using Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.data
{
    public class DataContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=Maksut-OZDEMIR\\SQLEXPRESS02; database=Kronometre uid=sa; pwd=1;");

        }
        DbSet<Süreler> sürelers { get; set; }
    }
}
