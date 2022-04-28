using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;

namespace Logic
{

    public class PatientManager
    {
        private List<Patient> _Patients;
        private IConfiguration _configuration;
        public PatientManager(IConfiguration configuration)
        {
            _configuration = configuration;
            _Patients = new List<Patient>();
            _Patients.Add(new Patient() { Name = "Erick", LastName = "Cartman", ci = 1234 });
            _Patients.Add(new Patient() { Name = "Kenny", LastName = "McCormick", ci = 3333 });
            _Patients.Add(new Patient() { Name = "Butters", LastName = "Stoch", ci = 5555 });
        }
        public List<Patient> GetPatients()
        {
            string envName = _configuration.GetSection("EnvName").Value;

            foreach(Patient pa in _Patients)
            {
                pa.Name = $"{ pa.Name} ({ envName})";
            }
            return _Patients; 
            throw new NotImplementedException();

        }

        public Patient CreatePatients(string name, string lastname, int id)
        {
            Patient createdPatient = new Patient() { Name = name, LastName=lastname, ci=id };
            _Patients.Add(createdPatient);
            return createdPatient;
        }

        public int UpdatePatient(int id, string name, string lastname)
        {
            int res = 0;
            int indPatient = _Patients.FindIndex(p => p.ci == id);
            if (indPatient < 0)
            {
                res = indPatient;
            }
            else
            {
                Patient fpatient = _Patients[indPatient];
                fpatient.Name = name;
                fpatient.LastName = lastname;
            }
            return res;
        }
        public int DeletePatient(int id)
        {
            int res = 0;
            int indPatient = _Patients.FindIndex(p => p.ci == id);
            if (indPatient < 0)
            {
                res = indPatient;
            }
            else
            {
                _Patients.RemoveAt(indPatient);
            }
            return res;
        }
    }

}

