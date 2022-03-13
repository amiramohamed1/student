using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentApi.models
{
    public class Student
    {
        public int Id { get; set; }
        public String name { get; set; }
    }
}
