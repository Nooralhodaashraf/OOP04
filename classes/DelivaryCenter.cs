using OOP04.interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OOP03.classes
{
    internal class DelivaryCenter
    {

        private string centerName;

        public string CenterName
        {
            get { return centerName; }

            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    centerName = value;
                }
            }
        }        // Private array that can store up to 20 shipments
        private Shipment[] shipments; //Done

        private Driver driverInfo;
        public Driver DriverInfo { get; set; }


        // Constructor initializes the shipments array
        public DelivaryCenter()
        {
            shipments = new Shipment?[20]; //so we can remove from it
        }


        // Integer Indexer
        public Shipment this[int index]
        {
            get
            {
                // Check if index is valid
                if (index >= 0 && index < shipments.Length)
                {
                    return shipments[index];
                }

                // Invalid index
                return default;
            }

            set
            {
                // Check if index is valid
                if (index >= 0 && index < shipments.Length)
                {
                    shipments[index] = value;
                }
            }
        }


        // String Indexer
        public Shipment? this[string trackingCode]
        {
            get
            {
                for (int i = 0; i < shipments.Length; i++)
                {
                    if (shipments[i] != null &&
                        shipments[i].TrackingCode == trackingCode)
                    {
                        return shipments[i];
                    }
                }

                return null;
            }
        }
        public bool RemoveShipment(string trackingCode)
        {
            for (int i = 0; i < shipments.Length; i++)
            {
                if (shipments[i].TrackingCode == trackingCode)
                {
                    shipments[i] = null;
                    return true;
                }
            }
            return false;

        }


        // Add a shipment to the first available position
        public bool AddShipment(Shipment shipment)
        {
            for (int i = 0; i < shipments.Length; i++)
            {
                // Check if the position is available
                if (shipments[i] == null)
                {
                    shipments[i] = shipment;
                    return true;
                }
            }

            return false;
        }
        // Delivery center is full

        //public void PrintAllShipments()
        //{
        //    for (int i = 0; i < shipments.Length; i++)
        //    {
        //        if (shipments[i] != null)
        //        {
        //            shipments[i].PrintShipment();
        //        }
        //    }
        //}

        //Modify PrintAllShipments() to loop through the array and simply call shipment.PrintShipment(); — no manual type - checking.That single call resolving to a different method per object is dynamic binding.
        public void PrintAllShipments()
        {
            foreach (Shipment shipment in shipments)
            {
                if (shipment != null)
                {
                    shipment.PrintShipment();// call shipment.PrintShipment()
                }
            }
        }
        public void PrintTrackingStatuses()
        {
            foreach (Shipment shipment in shipments)
            {
                if (shipment != null)
                {
                    ITrackable trackableShipment = shipment;
                    Console.WriteLine(trackableShipment.GetTrackingStatus());
                }
            }
        }


    }


}

