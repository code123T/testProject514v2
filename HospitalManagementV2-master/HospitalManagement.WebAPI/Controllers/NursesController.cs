using BookRS.DAL.Interfaces;
using HospitalMenegment.DAL.DbModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HospitalManagement.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NursesController : ControllerBase
    {
        private readonly IGenericRepository<Nurse> _nurseRepostory;

        public NursesController(IGenericRepository<Nurse> nurseRepostory)
        {
            _nurseRepostory = nurseRepostory;
        }


        [HttpGet]
        public List<Nurse> GetItem()
        {
            var response = _nurseRepostory.GetItem();
            return response;
        }

        [HttpGet("{id:int}")]
        public ActionResult<Nurse> GetItemeById(int id)

        {
            if (id == 0)
            {
                return BadRequest();
            }

            var response = _nurseRepostory.GetItemById(id);
            if (response == null)
            {
                return NotFound();
            }

            return Ok(response);
        }

        [HttpPost]
        public ActionResult<Nurse> Create(Nurse nurse)
        {

            var response = _nurseRepostory.AddItem(nurse);
            return Ok(response);
        }

        [HttpPut("{id:int}")]
        public ActionResult<Nurse> Update(int id, [FromBody] Nurse obj)
        {
            if (id == 0 || id != obj.Id)
            {
                return BadRequest();
            }

            var response = _nurseRepostory.GetItemById(id);
            if (response == null)
            {
                return NotFound();
            }
            response = _nurseRepostory.UpdateItem(obj);
            return Ok(response); ;
        }

        [HttpDelete("{id:int}")]

        public IActionResult Delete(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }

            var response = _nurseRepostory.GetItemById(id);
            if (response == null)
            {
                return NotFound();
            }

            _nurseRepostory.DeleteItem(id);
            return NoContent();
        }
    }
}
