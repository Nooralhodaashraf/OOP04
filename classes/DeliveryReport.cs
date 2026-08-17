using OOP04.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP04.classes
{
    internal class DeliveryReport
    {
        //method printShipmemnt =>itrackable
        public void PrintShipment(ITrackable shipment)
        {
            Console.WriteLine(shipment.GetTrackingStatus());
        }

        //method PrintInsurance =>IInsurable
        public void PrintInsurance(IInsurable shipment)
        {
            Console.WriteLine($"Insurance Cost: {shipment.CalculateInsurance()}");
        }


    }
}
