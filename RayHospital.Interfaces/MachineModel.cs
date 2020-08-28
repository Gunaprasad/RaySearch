using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using System.Text;

namespace RayHospital.Interfaces
{
    public class MachineModel
    {
        private string _machineName;

        private string _capability;

        public string MachineName
        {
            get
            {
                return _machineName;
            }
            set
            {
                _machineName = value;
            }
        }

        public string Capability
        {
            get
            {
                return _capability;
            }
            set
            {
                _capability = value;
            }
        }

    }
}