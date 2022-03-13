using Microsoft.AspNetCore.Mvc;
using StudentApi.Interfaces;
using StudentApi.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentApi.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class StudentController :Controller
    {
        private readonly IStudent _repo;
        public StudentController(IStudent repo)
        {
            _repo = repo;
        }
        [HttpPost]
        public ActionResult Add (Student student)
        {
            _repo.Add(student);
            return Ok(student);
        }
        [HttpPost]
        public ActionResult Edit(Student student)
        {
            _repo.Edit(student);
            return Ok(student);
        }
        [HttpPost]
        public ActionResult Delet(int Id)
        {
           
            return Ok(_repo.Delet(Id));
        }
        [HttpGet]
        public ActionResult FindById(int Id)
        {

            return Ok(_repo.FindById(Id));
        }
        [HttpGet]
        public ActionResult GetAllStudent()
        {

            return Ok(_repo.GetAll());
        }
    }
}
