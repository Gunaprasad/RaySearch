using System;
using System.Collections.Generic;
using System.Text;

namespace RayHospital.Interfaces
{
    public class PatientRegistrationModel
    {
        private string _name;

        private ConditionModel _condition;

        private int _offsetDays;

        private static readonly List<PatientRegistrationModel> _patientmodellist;

        private PatientRegistrationModel _objPatientRegistrationModel = null;

        public PatientRegistrationModel()
        {
            _objPatientRegistrationModel = new PatientRegistrationModel();

            foreach (var item in RayHospital.Resources.PatientRegistrations.Patients)
            {
                _objPatientRegistrationModel._name = item.Name;
                _objPatientRegistrationModel.Condition.Name = item.Condition;
                _objPatientRegistrationModel.Condition.Topographies = item.Topography;
            }
            patientModelList.Add(_objPatientRegistrationModel);
        }


        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public int OffSetDays
        {
            get
            {
                return _offsetDays;
            }
            set
            {
                _offsetDays = value;
            }
        }

        public ConditionModel Condition
        {
            get
            {

                return _condition;
            }
            set
            {
                _condition = value;
            }
        }

        public static List<PatientRegistrationModel> patientModelList
        {
            get
            {
                return _patientmodellist;
            }
        }
    }
}
