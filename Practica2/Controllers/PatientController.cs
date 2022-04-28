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
        public  PatientController()
        {

        }

        [HttpGet]
        public IActionResult GetPatient()
        {
            List<Patient> retrievedPatients = new List<Patient>();
            retrievedPatients.Add(new Patient() { Name = "ALdo", LastName = "Garcia" });
            return Ok(retrievedPatients);
        }
    }
}
