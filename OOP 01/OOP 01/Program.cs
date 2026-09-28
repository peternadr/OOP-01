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


        #endregion
    }
}
