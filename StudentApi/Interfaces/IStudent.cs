using StudentApi.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentApi.Interfaces
{
    public interface IStudent
    {
       public Student Add(Student student);
        public Student Edit(Student student);
        public Student FindById(int Id);
        public List<Student>GetAll();
        public bool Delet(int Id);




    }
}
