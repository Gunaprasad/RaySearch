using System;
using System.Collections.Generic;
using System.Text;

namespace RayHospital.Interfaces
{
    public class DoctorModel
    {
        private string _doctorname = String.Empty;

        private DoctorModel objdoctor = null;

        private List<DoctorModel> _doctors;

        public string[] _roles = { };

        public DoctorModel()
        {
            objdoctor = new DoctorModel();
            foreach (var item in RayHospital.Resources.HospitalResources.Doctors)
            {
                objdoctor.Name = item.Name;
                if(item.Roles.ToString().IndexOf(',')==1)
                {
                    objdoctor.Roles = item.Roles.ToString().Split();
                }
                else
                {
                    objdoctor.Roles = item.Roles;
                }
                
            }
            Doctors.Add(objdoctor);
            this._doctors = Doctors;
        }

        public string Name
        {
            get
            {
                return _doctorname;
            }
            set
            {
                _doctorname = value;
            }
        }

        public string[] Roles
        {
            get
            {

                return _roles;
            }
            set
            {
                _roles = value;
            }
        }

        public List<DoctorModel> Doctors
        {
            get
            {
                
                return _doctors;
            }
        }

    }
}
