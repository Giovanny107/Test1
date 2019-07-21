using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Test2.Models;
using Test2.Process;

namespace Test2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilteredController : ControllerBase
    {
        private Filtered _filtered;
        private Student _student;

        public FilteredController(Filtered filtered, Student student)
        {
            _filtered = filtered;
            _student = student;
        }
        
        [HttpGet("{mark}")]
        public ActionResult<List<Student>> FilterMarks([FromRoute] int mark)
        {            
            return Ok(_filtered.FilterMarks(_student.Students, mark));
        }

        [HttpGet]
        public ActionResult<List<Student>> FilterNames()
        {
            return Ok(_filtered.FilterNames(_student.Students));
        }

        [HttpGet("{name}/{mark}")]
        public ActionResult<List<Student>> FilterMix([FromRoute] string name, [FromRoute] int mark)
        {
            return Ok(_filtered.FilterMix(_student.Students, mark, name));
        }
    }
}
