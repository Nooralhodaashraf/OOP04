using System;
using System.Collections.Generic;
using System.Text;

namespace OOP03.classes
{
    internal class Driver
    {

        #region feilds 
        private string driverId;
        private string fullName;
        private string phoneNumber;
   
        #endregion


        #region properties && validation

        public string DriverId
        {
            get { return driverId; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    driverId = value;
                }
            }
        }

        public string FullName
        {
            get { return FullName; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    FullName = value;
                }
            }
        }


        public string PhoneNumber
        {
            get { return PhoneNumber; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    PhoneNumber = value;
                }
            }
        }

        #endregion
    }
}
