using BookRS.DAL.Interfaces;
using HospitalMenegment.DAL.DbModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HospitalManagement.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientsController : ControllerBase
    {
        private readonly IGenericRepository<Patient> _patientRepostory;
        public PatientsController(IGenericRepository<Patient> patientRepostory)
        {
            _patientRepostory = patientRepostory;
        }


        [HttpGet]
        public List<Patient> GetItem()
        {
            var response = _patientRepostory.GetItem();
            return response;
        }
        [HttpGet("{id:int}")]
        public ActionResult<Patient> GetItemById(int id)

        {
            if (id == 0)
            {
                return BadRequest();
            }

            var response = _patientRepostory.GetItemById(id);
            if (response == null)
            {
                return NotFound();
            }

            return Ok(response);
        }

        [HttpPost]
        public ActionResult<Patient> Create(Patient patient)
        {

            var response = _patientRepostory.AddItem(patient);
            return Ok(response);
        }

        [HttpPut("{id:int}")]
        public ActionResult<Patient> Update(int id, [FromBody] Patient obj)
        {
            if (id == 0 || id != obj.Id)
            {
                return BadRequest();
            }

            var response = _patientRepostory.GetItemById(id);
            if (response == null)
            {
                return NotFound();
            }
            response = _patientRepostory.UpdateItem(obj);
            return Ok(response); ;
        }

        [HttpDelete("{id:int}")]

        public IActionResult Delete(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }

            var response = _patientRepostory.GetItemById(id);
            if (response == null)
            {
                return NotFound();
            }

            _patientRepostory.DeleteItem(id);
            return NoContent();
        }
    }
}
