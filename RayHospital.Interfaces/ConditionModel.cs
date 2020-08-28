using System;
using System.Collections.Generic;
using System.Text;

namespace RayHospital.Interfaces
{
    public class ConditionModel
    {
        private string _name = String.Empty;

        private string _topographies;


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

        public string Topographies
        {
            get
            {
                return _topographies;
            }
            set
            {
                _topographies = value;
            }
        }


    }
}
