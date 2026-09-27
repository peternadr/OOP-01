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
    }
}
