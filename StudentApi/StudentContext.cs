using Microsoft.EntityFrameworkCore;
using StudentApi.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentApi
{
    public class StudentContext : DbContext
    {
        public StudentContext(DbContextOptions opt):base(opt)
        {

        }
       public DbSet<Student> Students { get; set; }
    }
}
