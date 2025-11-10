namespace _2._1_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Declare variables
            string productName;
            double productCost;
            int productQuantity;
            double taxRate;
            double totalPrice;

            // Get user input
            Console.Write("Enter the name of the product: ");
            productName = Console.ReadLine();

            Console.Write("Enter the cost of the product: ");
            productCost = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the quantity of the product: ");
            productQuantity = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the tax rate (for example, enter 0.07 for 7%): ");
            taxRate = Convert.ToDouble(Console.ReadLine());

            // Calculate total price with tax
            double subtotal;
            double taxAmount;

            subtotal = productCost * productQuantity;
            taxAmount = subtotal * taxRate;
            totalPrice = subtotal + taxAmount;

            // Display product summary
            Console.WriteLine("\n---- Product Summary ----");
            Console.WriteLine("Product Name: " + productName);
            Console.WriteLine("Product Cost: $" + productCost);
            Console.WriteLine("Product Quantity: " + productQuantity);
            Console.WriteLine("Tax Rate: " + (taxRate * 100).ToString("0.00") + "%");
            Console.WriteLine("Total Price with Tax: $" + totalPrice.ToString("0.000"));

        }
    }
}
