using BookRS.DAL.Interfaces;
using HospitalMenegment.DAL.DbModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HospitalManagement.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorsController : ControllerBase
    {
        private readonly IGenericRepository<Doctor> _doctorRepostory;
        public DoctorsController(IGenericRepository<Doctor> doctor)
        {
            _doctorRepostory = doctor;
        }


        [HttpGet]
        public List<Doctor> GetItem()
        {
            var response = _doctorRepostory.GetItem();
            return response;
        }

        [HttpGet("{id:int}")]
        public ActionResult<Doctor> GetItemById(int id)

        {
            if (id == 0)
            {
                return BadRequest();
            }

            var response = _doctorRepostory.GetItemById(id);
            if (response == null)
            {
                return NotFound();
            }

            return Ok(response);
        }

        [HttpPost]
        public ActionResult<Doctor> Create(Doctor doctor)
        {

            var response = _doctorRepostory.AddItem(doctor);
            return Ok(response);
        }

        [HttpPut("{id:int}")]
        public ActionResult<Doctor> Update(int id, [FromBody] Doctor obj)
        {
            if (id == 0 || id != obj.Id)
            {
                return BadRequest();
            }

            var response = _doctorRepostory.GetItemById(id);
            if (response == null)
            {
                return NotFound();
            }
            response = _doctorRepostory.UpdateItem(obj);
            return Ok(response); ;
        }

        [HttpDelete("{id:int}")]

        public IActionResult Delete(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }

            var response = _doctorRepostory.GetItemById(id);
            if (response == null)
            {
                return NotFound();
            }

            _doctorRepostory.DeleteItem(id);
            return NoContent();
        }
    }
}
