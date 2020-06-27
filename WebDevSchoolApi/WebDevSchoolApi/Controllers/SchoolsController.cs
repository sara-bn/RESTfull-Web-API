using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebDevSchoolApi.Entities;
using WebDevSchoolApi.Services;

namespace WebDevSchoolApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SchoolsController : ControllerBase
    {

        private readonly ISchoolProgramRepository _repo;
        private readonly IMapper _mapper;

        public SchoolsController(ISchoolProgramRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<School>> GetAllSchools()
        {
            return Ok( _repo.GetSchools());
        }

        [HttpGet("{id}", Name = "SchoolId")]
        public IActionResult GetSchoolById(Guid id)
        {
            var schoolToReturn = _repo.GetSchoolById(id);

            if (schoolToReturn == null)
            {
                return NotFound();
            }

            return Ok(schoolToReturn);
        }

        [HttpPost]
        //the school that Iwe are sending here doesn't have Id
        public ActionResult<School> AddSchool(School school)
        {
            var schoolToAdd = _mapper.Map<Entities.School>(school);

            _repo.AddSchool(schoolToAdd);
            _repo.Save();

            return CreatedAtRoute("SchoolId",new { schoolToAdd.Id }, schoolToAdd);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteSchool(Guid id)
        {
            var schoolToRemove = _repo.GetSchoolById(id);

            if (schoolToRemove == null)
            {
                return NotFound();
            }

            _repo.DeleteSchool(schoolToRemove);

            _repo.Save();

            return NoContent();
            
        }

    }
    
}