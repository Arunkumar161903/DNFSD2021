using Apihome.Models;
using Apihome.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Apihome.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly StudentRep _emp;

        public StudentController(StudentRep studentRep)
        {
            _emp = studentRep;
        }
        [HttpGet]
        public ActionResult<List<Student>>GetStude()
        {
            return _emp.Get();
        }
    }
}
