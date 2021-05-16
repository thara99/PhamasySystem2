using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PhamasySystem2.MedicinesData;
using PhamasySystem2.Model;

namespace PhamasySystem2.Controllers
{
    
    [ApiController]
    public class MedicinesController : ControllerBase
    {

        private IMedicines _medicines;

        public MedicinesController(IMedicines medicines)
        {
            _medicines = medicines;
        }

        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult GetMedicines()
        {
            return Ok(_medicines.GetMedicines());
        }

        [HttpGet]
        [Route("api/[controller]/{id}")]
        public IActionResult GetMedicine(Guid id)
        {
            var medicines = _medicines.GetMedicine(id);

            if (medicines != null)
            {
                return Ok(_medicines.GetMedicine(id));
            }
            return NotFound($"Medicine with ID: {id} was not found");
        }

        [HttpPost]
        [Route("api/[controller]")]
        public IActionResult AddMedicine(Medicines medicines)
        {
            _medicines.AddMedicine(medicines);

            return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Host + HttpContext.Request.Path + "/" +
                medicines.Id, medicines);
        }

        [HttpDelete]
        [Route("api/[controller]/{id}")]
        public IActionResult DeleteMedicine(Guid id)
        {
            var medicines = _medicines.GetMedicine(id);

            if(medicines != null)
            {
                _medicines.DeleteMedicine(medicines);
                return Ok();

            }
            return NotFound($"Medicine with ID: {id} was not found");

        }

        [HttpPatch]
        [Route("api/[controller]/{id}")]
        public IActionResult EditMedicine(Guid id, Medicines medicines)
        {
            var exixtingMedicine = _medicines.GetMedicine(id);

            if (exixtingMedicine != null)
            {
                medicines.Id = exixtingMedicine.Id;
                _medicines.EditMedicine(medicines);

            }
            return Ok(medicines);

        }


    }
}