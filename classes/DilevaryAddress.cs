using System;
using System.Collections.Generic;
using System.Text;

namespace OOP03.classes
{
    internal class DilevaryAddress
    {
        #region feilds
        private string City;
        private string Street;
        private int BuildingNumber;
        #endregion

        #region CTOR
        public DilevaryAddress(string city, string street, int buildingNumber)
        {
            City = city;
            Street = street;
            BuildingNumber = buildingNumber;
        }
        #endregion
        #region GetFullAddress() method
        public string GetFullAddress(string City, string Street, int BuildingNumber)
        {
            return $"City: {City}, Street: {Street}, Building Number: {BuildingNumber}";
        }

        #endregion 

    }
}
