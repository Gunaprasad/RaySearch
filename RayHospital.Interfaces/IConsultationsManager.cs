using System;
using System.Collections.Generic;

namespace RayHospital.Interfaces
{
  public interface IConsultationsManager
  {

    ConsultationModel BookConsultation(DateTime registrationDate, PatientRegistrationModel patient);

    //Consultation functionality to be implemented 
    IEnumerable<ConsultationModel> Consultations();
  }
}