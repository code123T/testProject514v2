using BookRS.DAL.Interfaces;
using HospitalMenegment.DAL.DbModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HospitalManagement.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicinesController : ControllerBase
    {
        private readonly IGenericRepository<Medicine> _medicineRepostory;

        public MedicinesController(IGenericRepository<Medicine> medicineRepostory)
        {
            _medicineRepostory = medicineRepostory;
        }


        [HttpGet]
        public List<Medicine> GetItem()
        {
            var response = _medicineRepostory.GetItem();
            return response;
        }

        [HttpGet("{id:int}")]
        public ActionResult<Medicine> GetItemById(int id)

        {
            if (id == 0)
            {
                return BadRequest();
            }

            var response = _medicineRepostory.GetItemById(id);
            if (response == null)
            {
                return NotFound();
            }

            return Ok(response);
        }

        [HttpPost]
        public ActionResult<Medicine> Create(Medicine medicine)
        {

            var response = _medicineRepostory.AddItem(medicine);
            return Ok(response);
        }

        [HttpPut("{id:int}")]
        public ActionResult<Medicine> Update(int id, [FromBody] Medicine obj)
        {
            if (id == 0 || id != obj.Id)
            {
                return BadRequest();
            }

            var response = _medicineRepostory.GetItemById(id);
            if (response == null)
            {
                return NotFound();
            }
            response = _medicineRepostory.UpdateItem(obj);
            return Ok(response); ;
        }

        [HttpDelete("{id:int}")]

        public IActionResult Delete(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }

            var response = _medicineRepostory.GetItemById(id);
            if (response == null)
            {
                return NotFound();
            }

            _medicineRepostory.DeleteItem(id);
            return NoContent();
        }
    }
}
