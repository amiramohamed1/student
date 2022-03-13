using StudentApi.Interfaces;
using StudentApi.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentApi.Repostries
{
    public class StudentRepo : IStudent
    {
        private readonly StudentContext _db;
        public StudentRepo(StudentContext db)
        {
            _db = db;
        }

        public Student Add(Student student)
        {
            _db.Students.Add(student);
            _db.SaveChanges();
            return student;
        }

        public bool Delet(int Id)
        {
        var student= _db.Students.Find(Id);
            _db.Students.Remove(student);
            _db.SaveChanges();
            return true;

        }

        public Student Edit(Student student)
        {
            _db.Students.Update(student);
            _db.SaveChanges();
            return student;
        }

        public Student FindById(int Id)
        {
            return _db.Students.Find(Id);
        }

        public List<Student> GetAll()
        {
            return _db.Students.ToList();
        }
    }
}