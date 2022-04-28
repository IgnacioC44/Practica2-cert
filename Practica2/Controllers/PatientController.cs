using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Logic;

namespace Practica2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PatientController : ControllerBase
    {
        private PatientManager _patientManager;
        public  PatientController(PatientManager patientManager)
        {
            _patientManager = patientManager;
        }

        [HttpGet]
        public IActionResult GetPatients()
        {
            

            return Ok(_patientManager.GetPatients());
        }

        [HttpPost]
        public IActionResult CreatePatients(string name, string lastname, int id)
        {
            
            Patient createdPatient = _patientManager.CreatePatients(name, lastname, id);
            return Ok(createdPatient);
        }

        [HttpPut]
        public IActionResult UpdatePatients(int id, string name, string lastname)
        {
            //PatientManager patientManager = new PatientManager();
            //Patient updatedPatient = _patientManager.UpdatePatient(id, name, lastname);
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeletePatients(int id)
        {
            //PatientManager patientManager = new PatientManager();
            //Patient deletedPatient = _patientManager.DeletePatient(id);
            return Ok();
        }
    }
}
