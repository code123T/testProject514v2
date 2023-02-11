using BookRS.DAL.Interfaces;
using HospitalMenegment.DAL.DbModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HospitalManagement.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HospitalsController : ControllerBase
    {
        private readonly IGenericRepository<Hospital> _hospitalRepostory;

        public HospitalsController(IGenericRepository<Hospital> hospital)
        {
            _hospitalRepostory = hospital;
        }


        [HttpGet]
        public List<Hospital> GetItem()
        {
            var response = _hospitalRepostory.GetItem();
            return response;
        }

        [HttpGet("{id:int}")]
        public ActionResult<Hospital> GetItemById(int id)

        {
            if (id == 0)
            {
                return BadRequest();
            }

            var response = _hospitalRepostory.GetItemById(id);
            if (response == null)
            {
                return NotFound();
            }

            return Ok(response);
        }

        [HttpPost]
        public ActionResult<Hospital> Create(Hospital hospital)
        {

            var response = _hospitalRepostory.AddItem(hospital);
            return Ok(response);
        }

        [HttpPut("{id:int}")]
        public ActionResult<Hospital> Update(int id, [FromBody] Hospital obj)
        {
            if (id == 0 || id != obj.Id)
            {
                return BadRequest();
            }

            var response = _hospitalRepostory.GetItemById(id);
            if (response == null)
            {
                return NotFound();
            }
            response = _hospitalRepostory.UpdateItem(obj);
            return Ok(response); ;
        }

        [HttpDelete("{id:int}")]

        public IActionResult Delete(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }

            var response = _hospitalRepostory.GetItemById(id);
            if (response == null)
            {
                return NotFound();
            }

            _hospitalRepostory.DeleteItem(id);
            return NoContent();
        }
    }
}
