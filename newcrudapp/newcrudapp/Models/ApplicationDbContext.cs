using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
    

namespace newcrudapp.Models
{
    //data base eka object ekata dala front ekt pass karnva
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)

        {


        }
        public DbSet<NewCusClass> customer{ get; set; }
    }
}
