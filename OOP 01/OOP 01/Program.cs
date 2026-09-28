using OOP_01.DeliveryManagementSystem;
using System.ComponentModel;

namespace OOP_01;

internal class Program
{
    static void Main(string[] args)
    {
        #region Theoretical Questions

        #region Question 01
        // (a) What happens when a DeliveryAddress variable is copied into another variable and the copy is modified?
        // The values in the variable dosen't change but change in the copy


        // (b) What happens when a Customer variable is copied into another variable and one variable modifies the object
        // Values change in the two variables
        #endregion

        #region Question 02
        // a) Identify at least three problems with this design from an encapsulation perspective.
        /*
         * There is no validation to prevent invalid values
         * All fields public allowing any one to modify data
         * The design dose not use getters and setters
        */

        // b) How can private fields and public properties improve this design?
        // With controlled getters and setters to manage read and modify data
        #endregion

        #endregion

        #region Practical

        #region Question 01
        //DeliveryAdress deliveryAdress1 = new("Alex", "st 45" , 10);

        //DeliveryAdress deliveryAdress2 = deliveryAdress1;
        //deliveryAdress1.printAdress();
        //deliveryAdress2.printAdress();

        //Console.WriteLine("--------------------------------------------------");

        //deliveryAdress2 = new("cairo", "elsalam", 13);
        //deliveryAdress1.printAdress();
        //deliveryAdress2.printAdress();
        #endregion

        #region printShipment
        //Shipment shipment = new Shipment(deliveryAdress1, "SH_101", "Laptop", 6, 50);
        //shipment.PrintShipment();
        #endregion

        #region DeliveryManagementSystem

        // Create a DeliveryCenter.
        DeliveryCenter deliveryCenter = new DeliveryCenter();

        // Read data for three shipments from the user.
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"Enter Data For shipment {i+1}: ");

            // Get tracking code from user
            Console.Write("Enter Tracing Code: ");
            string? trackingCode = Console.ReadLine();
            

            // Get description from user
            Console.Write("Enter Description: ");
            string? description = Console.ReadLine();
            

            // Get weight from user
            bool flag = false;
            decimal weight;
            do
            {
                Console.Write("Enter Valid Weight: ");
                flag = decimal.TryParse(Console.ReadLine(), out weight);
            }
            while (!flag || weight <= 0);
            

            // Get delivery Fee from user
            decimal deliveryFee;
            do
            {
                Console.Write("Enter Valid Delivery Fee: ");
                flag = decimal.TryParse(Console.ReadLine(), out deliveryFee);
            }
            while (!flag || deliveryFee <= 0);
            

            // Get City from user
            Console.Write("Enter Your City: ");
            string? city = Console.ReadLine();
            

            // Get street from user
            Console.Write("Enter Your street: ");
            string? street = Console.ReadLine();
            

            // Get building Number from user
            int buildingNumber;
            do
            {
                Console.Write("Enter Valid Building Number: ");
                flag = int.TryParse(Console.ReadLine(), out buildingNumber);
            }
            while (!flag);
            

            // Add shipment to delivery center
            DeliveryAdress deliveryAdress = new DeliveryAdress(city, street, buildingNumber);
            Shipment shipment = new Shipment(deliveryAdress, trackingCode, description, weight, deliveryFee);
            if (deliveryCenter.AddShipment(shipment))
            {
                Console.WriteLine("--Shipment Add Successfully--");
            }
            Console.WriteLine();

            
        }

        // print shipments
        Console.WriteLine("--All Shipments: ");
        for (int i = 0; i < 3; i++)
        {
            deliveryCenter[i].PrintShipment();
            Console.WriteLine("----------------");
        }

        // Search about Shipment With Tracking Code
        Console.Write("Enter a Tracking Code To Search: ");
        string searchCode = Console.ReadLine();
        Console.WriteLine();
        Shipment foundShipment = deliveryCenter[searchCode];

        //Print the shipment if found; otherwise print:Shipment not found. 
        if (!string.IsNullOrWhiteSpace(foundShipment.TrackingCode))
        {
            Console.WriteLine("Shipment Found: ");
            foundShipment.PrintShipment();
        }
        else
        {
            Console.WriteLine("Shipment Not Found: ");
        }
        Console.WriteLine();


        //Demonstrate the DeliveryAddress struct copy behavior.
        DeliveryAdress deliveryAdress1 = new("Alex", "st 45", 10);

        DeliveryAdress deliveryAdress2 = deliveryAdress1;
        deliveryAdress1.printAdress();
        deliveryAdress2.printAdress();

        Console.WriteLine("--------------------------------------------------");

        deliveryAdress2 = new("cairo", "elsalam", 13);
        deliveryAdress1.printAdress();
        deliveryAdress2.printAdress();
        #endregion

        #endregion
    }
}
