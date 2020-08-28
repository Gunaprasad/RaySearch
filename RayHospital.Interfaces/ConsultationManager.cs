using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace RayHospital.Interfaces
{
    public class ConsultationManager : IConsultationsManager
    {
        // Check if the Consultation is available for the particular room

        private ConsultationModel _objconsultation = null;

        private List<ConsultationModel> _objconsulationList;

        public ConsultationManager()
        {
            _objconsultation = new ConsultationModel();

        }


        public ConsultationModel BookConsultation(DateTime registrationDate, PatientRegistrationModel patient)
        {
            //if (patient.OffSetDays == 0)
            //{
            //    _objconsultation.consultationdate = registrationDate.AddDays(1);
            //}
            //else
            //{
            //    _objconsultation.consultationdate = registrationDate.AddDays(patient.OffSetDays);
            //}
            _objconsultation.patientName = patient.Name;
            _objconsultation.registrationDate = registrationDate;
            switch (patient.Condition.Name)
            {
                case "Cancer":
                    //_objconsultation.doctor._roles = { "xyz, abc"};
                    if (patient.Condition.Topographies == Topographies.HeadNeck.ToString())
                    {

                        
                        _objconsultation.doctor.Name = "DSFD";
                        _objconsultation.treatment.RoomName = "dsfd";
                        _objconsultation.treatment.MachineName.MachineName = "";
                        var nextconsultaionappointment = GetNextConsultationAppointment(_objconsulationList, registrationDate, _objconsultation.doctor.Doctors);
                        //get next consultation date, name, room for the available doctor

                    }
                    else
                    {

                        _objconsultation.doctor.Name = "DSFD";
                        _objconsultation.treatment.RoomName = "dsfd";
                    }

                    break;

                case "Flu":
                    _objconsultation.doctor.Name = "DSFD";
                    _objconsultation.treatment.RoomName = "dsfd";
                    break;
            }


            _objconsulationList.Add(_objconsultation);
            
            //_objconsultation.doctor = "SDF";

            
            throw new NotImplementedException();
        }


        private Tuple<String, DateTime> GetNextConsultationAppointment(List<ConsultationModel> lstConsultation,DateTime registrationDate, List<DoctorModel> lstDoctor)
        {
            if (lstDoctor.Count > 0 && lstConsultation.Any(j => lstDoctor.Any(x=>x.Name == j.doctor.Name)))
            {
                foreach (var item in lstConsultation)
                {
                    lstDoctor.Remove(item.doctor);
                }
                
            }


            return Tuple<String, DateTime>();
        }


        public IEnumerable<ConsultationModel> Consultations()
        {
            throw new NotImplementedException();
        }

        enum Topographies
        {
            [Description("Head & Neck")] HeadNeck,
            Breast
        }
    }
}
