using OOP04.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP03.classes
{
    #region Parent class
    //Change the Shipment class into an abstract class
    internal abstract class Shipment : ITrackable, IInsurable
    {
        #region feilds 
        private string trackingCode;
        private string description;
        private decimal weight;
        private decimal deliveryFee;
        #endregion


        #region properties && validation
        public DilevaryAddress Destination { get; set; }

        public string TrackingCode
        {
            get { return trackingCode; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    trackingCode = value;
                }
            }
        }

        public string Description
        {
            get { return description; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    description = value;
                }
            }
        }
        public decimal Weight
        {
            get { return weight; }
            set
            {
                if (value > 0)
                {
                    weight = value;
                }
            }
        }
        public decimal DeliveryFee
        {
            get { return deliveryFee; }
            private set
            {
                if (value > 0)
                {
                    deliveryFee = value;
                }
            }
        }

        //estimation
        //Abstract Property=> decimal EstimatedCost
        public abstract decimal EstimatedCost{get;}

        #endregion

        #region CTOR //constructors overloading
        public Shipment(string trackingCode)
        {
            this.trackingCode = "";
            this.description = "";
            this.weight = 0;
            this.deliveryFee = 0;

            // Set the tracking code using the property to ensure validation
            TrackingCode = trackingCode;
            Description = "Unknown";
            Weight = 1;
            DeliveryFee = 50;
            Destination = new DilevaryAddress("Cairo", "Nasr City", 1);
        }

        public Shipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DilevaryAddress destination)
        {
            this.trackingCode = "";
            this.description = "";
            this.weight = 0;
            this.deliveryFee = 0;

            // Use properties for validation
            TrackingCode = trackingCode;
            Description = description;
            Weight = weight;
            DeliveryFee = deliveryFee;
            Destination = destination;
        }

        #endregion

        #region deliveryFee
        public void UpdateDeliveryFee(decimal newFee)
        {
            if (newFee > 0)
            {
                DeliveryFee = newFee;
            }
        }
        #endregion

        #region PrintShipment()
        //Convert to a virtual method. Every child class will override it. 
        //public virtual void PrintShipment()
        //{
        //    Console.WriteLine("Shipment Information:");
        //    Console.WriteLine($"Tracking Code: {TrackingCode}");
        //    Console.WriteLine($"Description: {Description}");
        //    Console.WriteLine($"Weight: {Weight}");
        //    Console.WriteLine($"Delivery Fee: {DeliveryFee}");
        //    //Console.WriteLine($"Destination: {Destination.GetFullAddress(city, street, buildingNumber)}");
        //    Console.WriteLine($"Estimated Cost: {EstimatedCost}");
        //}



        //abstract method => print shipment
        public abstract void PrintShipment();
        #endregion

        #region Method Overloading
        // add two versions of the weight-update method: 


        //1 Updates the shipment weight.

        public virtual decimal weightUpdate(decimal weight) {
            weight += 2;
            return weight;
        }


        //Updates the shipment weight after adding the extra packing weight.

        public virtual decimal weightUpdateAfter(decimal newWeight, decimal extraWeight)
        {
            return newWeight+extraWeight;
        }


        #endregion


        #region itrackable interface implementation
        //had the idea to make it abstract and make every child class implement it but i thought it may be against the idea of the assignment
        public string GetTrackingStatus()
        {
            
            return $"● Shipment {TrackingCode} is Ready.";
        }

        public decimal CalculateInsurance()
        {
            return EstimatedCost;
        }

        #endregion
    }

    #endregion

    #region StandardShipment child class
    internal class StandardShipment : Shipment, ITrackable, IInsurable
    {
        public StandardShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DilevaryAddress destination, decimal estimatedCost)
    : base(trackingCode, description, weight, deliveryFee, destination)
{
            TrackingCode = trackingCode;
            Description = description;
            Weight = weight;
            Destination = destination;
        }

        //3  Override EstimatedCost //no updates
        public override decimal EstimatedCost
        {
            get
            {
                return DeliveryFee + (decimal)(Weight * 5);
            }
        }

        // Override Printshipment
        public override void PrintShipment()
        {
            Console.WriteLine("Shipment Information:");
            Console.WriteLine($"Tracking Code: {TrackingCode}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Weight: {Weight}");
            Console.WriteLine($"Delivery Fee: {DeliveryFee}");
            Console.WriteLine($"Estimated Cost: {EstimatedCost}");
            Console.WriteLine("Standard Shipment Printed Successfully.");

        }

        public string GetTrackingStatus()
        {

            return $" Shipment {TrackingCode} is Out for Delivery.";
        }

        public decimal CalculateInsurance()
        {
            return EstimatedCost * 0.05m;
        }

    }

    #endregion

    #region ExpressShipment child class
    internal class ExpressShipment : Shipment
    {

        private decimal extraFee;

        public decimal ExtraFee
        {
            get { return extraFee; }

            set
            {
                if (value >= 0)
                {
                    extraFee = value;
                }
            }
        }


        //DeliveryFee + (Weight × 5) + ExtraFee 
        public override decimal EstimatedCost
        {
            get
            {
                return DeliveryFee + (decimal)(Weight * 5) + ExtraFee;
            }
        }

        public ExpressShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DilevaryAddress destination, decimal extraFee, decimal expressEstimatedCost)
    : base(trackingCode, description, weight, deliveryFee, destination)
{
            TrackingCode = trackingCode;
            Description = description;
            Weight = weight;
            Destination = destination;
            ExtraFee = extraFee;

        }

        //override printshipment 
        public override void PrintShipment()
        {
            Console.WriteLine("Shipment Information:");
            Console.WriteLine($"Tracking Code: {TrackingCode}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Weight: {Weight}");
            Console.WriteLine($"Delivery Fee: {DeliveryFee}");
            Console.WriteLine($"Estimated Cost: {EstimatedCost}");
            Console.WriteLine($"Extra Fee:{extraFee}");
            Console.WriteLine("Express Shipment Printed Successfully.");

        }
        public decimal CalculateInsurance()
        {
            return EstimatedCost * 0.08m;
        }

        public string GetTrackingStatus()
        {

            return $"express Shipment {TrackingCode} has been Delivered.";
        }

    }
    #endregion

    #region InternationalShipment child class
    internal class InternationalShipment : Shipment
    {
        private string destinationCountry;

        public string DestinationCountry
        {
            get { return destinationCountry; }

            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    destinationCountry = value;
                }
            }
        }
        private decimal customsFee;

        public decimal CustomsFee
        {
            get { return customsFee; }

            set
            {
                if (value >= 0)
                {
                    customsFee = value;
                }
            }


        }

        public string GetTrackingStatus()
        {

            return $"International Shipment {TrackingCode} has been Delivered.";
        }


        //override EstimatedCost
        public override decimal EstimatedCost
        {
            get
            {
                return DeliveryFee + (decimal)(Weight * 5) + CustomsFee;
            }
        }



        public decimal CalculateInsurance()
        {
            return EstimatedCost * 0.12m;
        }


        public InternationalShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DilevaryAddress destination, decimal customsFee, decimal customFee, string destinationCountry)
    : base(trackingCode, description, weight, deliveryFee, destination)
{
            TrackingCode = trackingCode;
            Description = description;
            Weight = weight;
            Destination = destination;
            CustomsFee = customsFee;
            DestinationCountry = destinationCountry;

        }

        public InternationalShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DilevaryAddress destination, decimal customsFee) : base(trackingCode, description, weight, deliveryFee, destination)
        {
        }

        public override void PrintShipment()
        {
            Console.WriteLine("Shipment Information:");
            Console.WriteLine($"Tracking Code: {TrackingCode}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Weight: {Weight}");
            Console.WriteLine($"Delivery Fee: {DeliveryFee}");
            Console.WriteLine($"Estimated Cost: {EstimatedCost}");
            Console.WriteLine($"Customs Fee:{customsFee}");
            Console.WriteLine($"Destination: {destinationCountry}");
            Console.WriteLine("International Shipment Printed Successfully.");

        }

        // Sealed Method 
        //In InternationalShipment, add a virtual GenerateCustomsReport(). In PriorityInternationalShipment(inherits from  InternationalShipment), override it and mark that override sealed.
        public virtual void GenerateCustomsReport()
        {
            Console.WriteLine("Generating customs report for International Shipment...");
        }
    }
    #endregion

    internal class PriorityInternationalShipment : InternationalShipment , ITrackable
    {

        public PriorityInternationalShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DilevaryAddress destination, decimal customsFee, string destinationCountry)
    : base(trackingCode, description, weight, deliveryFee, destination, customsFee)
{
            // ctor
        }
        public sealed override void GenerateCustomsReport()
        {
            Console.WriteLine("Generating customs report for Priority International Shipment...");
        }

       
    }


    #region CompletedShipment
    internal sealed class CompletedShipment : Shipment
    {
        public CompletedShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DilevaryAddress destination)
        : base(trackingCode, description, weight, deliveryFee, destination)
{
        }

        // Provide an implementation for the abstract EstimatedCost getter
        public override decimal EstimatedCost
        {
            get
            {
                return DeliveryFee + (decimal)(Weight * 5);
            }
        }

        // Provide an implementation for the abstract PrintShipment method
        public override void PrintShipment()
        {
            Console.WriteLine("Shipment Information:");
            Console.WriteLine($"Tracking Code: {TrackingCode}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Weight: {Weight}");
            Console.WriteLine($"Delivery Fee: {DeliveryFee}");
            Console.WriteLine($"Estimated Cost: {EstimatedCost}");
            Console.WriteLine("Completed Shipment Printed Successfully.");
        }
    }
    #endregion
}
