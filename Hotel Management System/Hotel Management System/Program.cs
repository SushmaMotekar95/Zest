using System.Security.Cryptography.X509Certificates;

namespace Hotel_Management_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Restaurant restaurant = new Restaurant();

            int option;
            do
            {
                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine("Welcome to Sahyadri Restaurant...");
                Console.WriteLine("1.Display Menu..");
                Console.WriteLine("2.Place Order");
                Console.WriteLine("3.View Order");
                Console.WriteLine("4.Bill");
                Console.WriteLine("5.Exit");
                Console.WriteLine("----------------------------------------------------");
                option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:

                        restaurant.DisplayMenu();
                        Console.WriteLine("----------------------------------------------------");
                        break;

                    case 2:
                        restaurant.PlaceOrder();
                        break;
                        Console.WriteLine("----------------------------------------------------");
                    case 3:
                        restaurant.ViewOrder();
                        break;
                        Console.WriteLine("----------------------------------------------------");
                    case 4:
                        restaurant.Checkout();
                        break;
                        break;
                        Console.WriteLine("----------------------------------------------------");
                    case 5:
                        Console.WriteLine("Exit");
                        break;
                        Console.WriteLine("----------------------------------------------------");
                    default:
                        Console.WriteLine("Please Enter the valid Option...");
                        break;
                        Console.WriteLine("----------------------------------------------------");

                }

            } while (option < 5);
        }
    }
}
