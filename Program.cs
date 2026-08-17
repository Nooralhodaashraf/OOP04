using OOP03.classes;
using OOP04.classes;
using OOP04.interfaces;

namespace OOP04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01 — Theoretical Questions

            #region Q1  

            #region a)  What is Abstraction in Object-Oriented Programming?
            //a) Abstraction is a fundamental concept in Object-Oriented Programming (OOP) that focuses on simplifying complex systems by modeling classes based on the essential properties and behaviors of real-world entities. It allows developers to hide unnecessary implementation details and expose only the relevant features of an object, making it easier to understand and work with.
            #endregion

            #region b)  Why is abstraction considered one of the four pillars of OOP?
            //abstraction is considered one of the 4 pillars of OOP because it hides unnecessary implementation details and exposes only the essential features of an object.
            #endregion

            #endregion

            #region Q2
            #region a)  What is the difference between an Abstract Class and an Interface?
            //the difference between an Abstract Class and an Interface is 
            //abstract:
            //class can have abstract and cocrete methods
            //can have feilds 
            //can use any access modifier 
            //class can inhert 1 abstract class
            //provides base functionality and commen behavior
            //interface:
            //only abstract methods untill C# 0.8 (defult and ststic methods)
            //connot have feilds only const
            //access modifier is public by defult for members 
            //class can implements multible interfaces 
            //connot have a constructor 
            //define a contract 
            #endregion

            #region b)  When would you choose an Interface instead of an Abstract Class?
            //you would choose an interface instead of an abstract class when you want to define a contract that multiple classes can implement, regardless of their position in the class hierarchy. Interfaces are ideal for defining capabilities that can be shared across unrelated classes, promoting flexibility and decoupling in your code design.

            #endregion

            #region c)  Can a class inherit from multiple abstract classes? Can it implement multiple interfaces?
            //no,it can only inhert from 1 abstract class 
            //yes , it can implement multiple interfaces
            #endregion

            #endregion

            #endregion


            #region Part 02 — Practical
            #region original code from ass.03
            //1.Create a DeliveryCenter.
            DelivaryCenter center = new DelivaryCenter();
            Console.ForegroundColor = ConsoleColor.White;

            //2.Read the center name from the user.
            string centerName;
            do
            {
                Console.Write("Enter Center ");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("Name:");
                Console.ForegroundColor = ConsoleColor.White;

                centerName = Console.ReadLine();
                center.CenterName = centerName;

            } while (string.IsNullOrWhiteSpace(centerName) || int.TryParse(centerName, out _));


            //3.Create one StandardShipment.
            StandardShipment standardShipment; //dont initail now bc the CTOR needs params 
                                               //4.Create one ExpressShipment.
            ExpressShipment expressShipment;
            //5.Create one InternationalShipment.
            InternationalShipment internationalShipment;
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("===================================");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("DelivaryCenter :" + center.CenterName);
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("===================================");
            Console.ForegroundColor = ConsoleColor.White;

            //6.Read all shipment data from the user.
            #region StanderdShipment
            Console.WriteLine(" Standard Shipment :");

            string TrackingCode;
            do
            {
                Console.Write("Tracking ");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("Code:");
                Console.ForegroundColor = ConsoleColor.White;
                TrackingCode = Console.ReadLine();


            } while (string.IsNullOrWhiteSpace(TrackingCode) || int.TryParse(TrackingCode, out _));


            string description;
            do
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("Description: ");
                Console.ForegroundColor = ConsoleColor.White;
                description = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(description));
            Console.ForegroundColor = ConsoleColor.White;


            decimal weight;

            do
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("Weight: ");
                Console.ForegroundColor = ConsoleColor.White;

            } while (!decimal.TryParse(Console.ReadLine(), out weight) || weight <= 0);


            decimal deliveryFee;

            do
            {
                Console.Write("Delivery ");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("Fee: ");
                Console.ForegroundColor = ConsoleColor.White;

            } while (!decimal.TryParse(Console.ReadLine(), out deliveryFee) || deliveryFee <= 0);



            DilevaryAddress destination = new DilevaryAddress("cairo", "Dokki", 123);
            //need to hasndle the DilevaryAddress class to read the address from the user


            decimal EstimatedCost;

            do
            {
                Console.Write("Estimated ");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("Cost: ");
                Console.ForegroundColor = ConsoleColor.White;

            } while (!decimal.TryParse(Console.ReadLine(), out EstimatedCost) || EstimatedCost <= 0);


            standardShipment = new StandardShipment(TrackingCode, description, weight, deliveryFee, destination, EstimatedCost);
            #endregion
            //7.Add the shipments to the delivery center.
            center.AddShipment(standardShipment);


            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("_____________________________________");
            Console.ForegroundColor = ConsoleColor.White;


            #region ExpressShipment
            Console.WriteLine(" Standard Shipment :");

            string ExpressTrackingCode;
            do
            {
                Console.Write("Tracking ");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("Code:");
                Console.ForegroundColor = ConsoleColor.White;
                ExpressTrackingCode = Console.ReadLine();


            } while (string.IsNullOrWhiteSpace(ExpressTrackingCode) || int.TryParse(ExpressTrackingCode, out _));


            string Expressdescription;
            do
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("Description: ");
                Console.ForegroundColor = ConsoleColor.White;
                Expressdescription = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(Expressdescription));
            Console.ForegroundColor = ConsoleColor.White;


            decimal Expressweight;

            do
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("Weight: ");
                Console.ForegroundColor = ConsoleColor.White;

            } while (!decimal.TryParse(Console.ReadLine(), out Expressweight) || Expressweight <= 0);


            decimal ExpressdeliveryFee;

            do
            {
                Console.Write("Delivery ");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("Fee: ");
                Console.ForegroundColor = ConsoleColor.White;

            } while (!decimal.TryParse(Console.ReadLine(), out ExpressdeliveryFee) || ExpressdeliveryFee <= 0);

            decimal ExtraFee;

            do
            {
                Console.Write("Extra ");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("Fee: ");
                Console.ForegroundColor = ConsoleColor.White;

            } while (!decimal.TryParse(Console.ReadLine(), out ExtraFee) || ExtraFee <= 0);

            decimal ExpressEstimatedCost;

            do
            {
                Console.Write("Estimated ");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("Cost: ");
                Console.ForegroundColor = ConsoleColor.White;

            } while (!decimal.TryParse(Console.ReadLine(), out ExpressEstimatedCost) || ExpressEstimatedCost <= 0);

            expressShipment = new ExpressShipment(ExpressTrackingCode, Expressdescription, Expressweight, ExpressdeliveryFee, destination, ExtraFee, ExpressEstimatedCost);

            #endregion
            //7.Add the shipments to the delivery center.
            center.AddShipment(expressShipment);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("_____________________________________");
            Console.ForegroundColor = ConsoleColor.White;


            #region InternationalShipment
            Console.WriteLine(" Standard Shipment :");

            string IntrernaionalTrackingCode;
            do
            {
                Console.Write("Tracking ");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("Code:");
                Console.ForegroundColor = ConsoleColor.White;
                IntrernaionalTrackingCode = Console.ReadLine();


            } while (string.IsNullOrWhiteSpace(IntrernaionalTrackingCode) || int.TryParse(IntrernaionalTrackingCode, out _));


            string Intrernaionaldescription;
            do
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("Description: ");
                Console.ForegroundColor = ConsoleColor.White;
                Intrernaionaldescription = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(Intrernaionaldescription));
            Console.ForegroundColor = ConsoleColor.White;


            decimal Intrernaionalweight;

            do
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("Weight: ");
                Console.ForegroundColor = ConsoleColor.White;

            } while (!decimal.TryParse(Console.ReadLine(), out Intrernaionalweight) || Intrernaionalweight <= 0);


            decimal IntrernaionaldeliveryFee;

            do
            {
                Console.Write("Delivery ");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("Fee: ");
                Console.ForegroundColor = ConsoleColor.White;

            } while (!decimal.TryParse(Console.ReadLine(), out IntrernaionaldeliveryFee) || IntrernaionaldeliveryFee <= 0);


            string DestinationCountry;
            do
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("Destination Country: ");
                Console.ForegroundColor = ConsoleColor.White;
                DestinationCountry = Console.ReadLine();
            }
            while (string.IsNullOrWhiteSpace(DestinationCountry) || int.TryParse(DestinationCountry, out _));
            Console.ForegroundColor = ConsoleColor.White;


            decimal CustomFee;

            do
            {
                Console.Write("Custom ");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("Fee: ");
                Console.ForegroundColor = ConsoleColor.White;

            } while (!decimal.TryParse(Console.ReadLine(), out CustomFee) || CustomFee <= 0);

            decimal IntrernaionalEstimatedCost;

            do
            {
                Console.Write("Estimated ");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("Cost: ");
                Console.ForegroundColor = ConsoleColor.White;

            } while (!decimal.TryParse(Console.ReadLine(), out IntrernaionalEstimatedCost) || IntrernaionalEstimatedCost <= 0);

            internationalShipment = new InternationalShipment(IntrernaionalTrackingCode, Intrernaionaldescription, Intrernaionalweight, IntrernaionaldeliveryFee, destination, IntrernaionalEstimatedCost, CustomFee, DestinationCountry);
            #endregion

            //7.Add the shipments to the delivery center.
            center.AddShipment(internationalShipment);


            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("_____________________________________");
            Console.ForegroundColor = ConsoleColor.White;

            //8.Print all shipments.
            center.PrintAllShipments();

            //10.Remove one shipment using its tracking code.
            string TrackingCodeToRemove;

            do
            {
                Console.Write("Enter Tracking Code To ");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("Remove:");
                Console.ForegroundColor = ConsoleColor.White;
                TrackingCodeToRemove = Console.ReadLine();


            } while (string.IsNullOrWhiteSpace(TrackingCodeToRemove) || int.TryParse(TrackingCodeToRemove, out _));


            //11.Print the remaining shipments.
            center.PrintAllShipments();


            Console.WriteLine("===================================");
            Console.WriteLine("Assignment 03 Code");
            Console.WriteLine("===================================");
            Console.WriteLine("Printing Using DeliveryHelper...");
            DeliveryHelper.PrintShipmentDetails(standardShipment);
            DeliveryHelper.PrintShipmentDetails(expressShipment);
            DeliveryHelper.PrintShipmentDetails(internationalShipment);
            Console.WriteLine("===================================");
            Console.WriteLine("Updating Weight... ");
            Console.WriteLine($"Original Weight :{standardShipment.Weight} ");
            Console.WriteLine($"Updated Weight :{standardShipment.weightUpdate(standardShipment.Weight)} ");
            Console.WriteLine($"Updated Weight After Packing  :{standardShipment.weightUpdateAfter(standardShipment.Weight, 5)} ");
            Console.WriteLine($"Original Weight :{expressShipment.Weight} ");
            Console.WriteLine($"Updated Weight :{expressShipment.weightUpdate(expressShipment.Weight)} ");
            Console.WriteLine($"Updated Weight After Packing  :{expressShipment.weightUpdateAfter(expressShipment.Weight, 5)} ");
            Console.WriteLine($"Original Weight :{internationalShipment.Weight} ");
            Console.WriteLine($"Updated Weight :{internationalShipment.weightUpdate(internationalShipment.Weight)} ");
            Console.WriteLine($"Updated Weight After Packing  :{internationalShipment.weightUpdateAfter(internationalShipment.Weight, 5)} ");
            Console.WriteLine("===================================");
            Console.WriteLine("Printing Using Shipment[]...");
            center.PrintAllShipments();
            Console.WriteLine("===================================");



            #endregion

            #region assignment 04 code 
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("===================================");
            Console.ForegroundColor = ConsoleColor.White;

            //☐  f. Print the tracking status of every shipment.
            Console.WriteLine("Tracking Statuses:");
            center.PrintTrackingStatuses();

            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("===================================");
            Console.ForegroundColor = ConsoleColor.White;

            //☐  g. Print the insurance cost of every shipment.
            DeliveryReport report = new DeliveryReport();
            Console.WriteLine("Insurance Costs:");
            report.PrintInsurance(standardShipment);
            report.PrintInsurance(expressShipment);
            report.PrintInsurance(internationalShipment);

            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("===================================");
            Console.ForegroundColor = ConsoleColor.White;


            //☐  h. Store the shipment objects in an ITrackable[] array and print their tracking statuses.
            ITrackable[] trackableShipments =
               {
                    standardShipment,
                     expressShipment,
                       internationalShipment
               };
            Console.WriteLine("Tracking Statuses Using ITrackable[]:");

            foreach (ITrackable shipment in trackableShipments)
            {
                //dont know the ?? where come from 
                Console.WriteLine(shipment.GetTrackingStatus());
            }

            //☐  i. Store the shipment objects in an IInsurable[] array and print their insurance values.
            IInsurable[] insurableShipments =
             {
                  standardShipment,
                   expressShipment,
                 internationalShipment
               };

            Console.WriteLine("Insurance Costs Using IInsurable[]:");

            foreach (IInsurable shipment in insurableShipments)
            {
                Console.WriteLine($"Insurance Cost: {shipment.CalculateInsurance()}");
            }
            #endregion

            #endregion

        }
    }
}
