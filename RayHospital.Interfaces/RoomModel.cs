using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using System.Text;

namespace RayHospital.Interfaces
{
    public class RoomModel
    {
        private string _roomname;

        private MachineModel _machinename;

        private static List<RoomModel> _roommodellist;

        private RoomModel _objRoomModel = null;

        private (string Name, string Capability)[] _treatmentMachine = { };

        private (string Name, string Capability)[] _treatmentrooms = { };

        private RoomModel()
        {
            _objRoomModel = new RoomModel();
            foreach (var itemroom in RayHospital.Resources.HospitalResources.TreatmentRooms)
            {
                _objRoomModel.RoomName = itemroom.Name;
                foreach (var itemmachine in RayHospital.Resources.HospitalResources.TreatmentMachines)
                {
                    if(itemmachine.Name == itemroom.MachineName)
                    {
                        _objRoomModel.MachineName.MachineName = itemmachine.Name;
                        _objRoomModel.MachineName.Capability = itemmachine.Capability;
                    }
                }
                _roommodellist.Add(_objRoomModel);

            }
        }


        public string RoomName
        {
            get
            {
                return _roomname;
            }
            set
            {
                _roomname = value;
            }
        }

        public MachineModel MachineName
        {
            get
            {
                return _machinename;
            }
            set
            {
                _machinename = value;
            }
        }


        public static List<RoomModel> RoomModelList
        {
            get
            {
                return _roommodellist;
            }
            set
            {
                _roommodellist = value;
            }
        }

        //public (string Name, string Capability)[] TreatmentRooms
        //{
        //    get
        //    {
        //        return _treatmentrooms = RayHospital.Resources.HospitalResources.TreatmentRooms; 
        //    }
        //}

        //public (string Name, string Capability)[] TreatmentMachine
        //{
        //    get
        //    {
        //        return _treatmentMachine  = RayHospital.Resources.HospitalResources.TreatmentMachines; 
        //    }
        //}

    }
}
