using System;

namespace RayHospital.Interfaces
{
  public class ConsultationModel
  {
    public DateTime consultationdate { get; set; }

    public DoctorModel doctor { get; set; }

    public RoomModel treatment { get; set; }

    public string patientName { get; set; }

    public DateTime registrationDate { get; set; }

  }
}