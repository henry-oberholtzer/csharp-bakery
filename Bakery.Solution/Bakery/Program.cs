using System.Globalization;
using Bakery.Models;

namespace Bakery
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to the Bakery at Sharp Sea!");
            Thread.Sleep(750);
            Console.WriteLine(
                "There are only two things you can order, loaves of bread, or pastry."
            );
            Thread.Sleep(750);
            Console.WriteLine("However, quantity discounts are offered on all items!");
            Thread.Sleep(750);
            Console.WriteLine("If you'd like to place an order, press <Enter> to continue.");
            Thread.Sleep(750);
            Console.WriteLine("Otherwise, press any key to exit the application.");
            ConsoleKeyInfo input = Console.ReadKey();
            if (input.Key == ConsoleKey.Enter)
            {
                BreadOrder orderBread = new(0);
                PastryOrder orderPastry = new(0);
                OrderManager(orderBread, orderPastry);
            }
            else
            {
                Console.WriteLine("Thanks for stopping by!");
            }
        }

        static void OrderManager(Order orderBread, Order orderPastry)
        {
            string[] breadNames = {"bread", "loaves"};
            OrderLoop(orderBread, breadNames);
            string[] pastryNames = {"pastry", "pastries"};
            OrderLoop(orderPastry, pastryNames);
            Console.WriteLine("\n\n");
            Console.WriteLine("Let's recap your order:");
            Console.WriteLine(
                $"You've ordered {orderBread.Quantity} {breadNames[1]} for a total of ${orderBread.GetTotal()}."
            );
            Console.WriteLine(
                $"We also have you down for {orderPastry.Quantity} {pastryNames[1]} for a total of ${orderPastry.GetTotal()}."
            );
            Console.WriteLine("If this is correct, press <Enter> to continue or any key to edit.");
            ConsoleKeyInfo input = Console.ReadKey();
            if (input.Key == ConsoleKey.Enter)
            {
                Console.WriteLine("\n\n");
                Console.WriteLine(
                    $"Your total today is ${orderPastry.GetTotal() + orderBread.GetTotal()}."
                );
                Console.WriteLine($"Thanks for shopping at Sharp Sea Bakery!");
            }
            else
            {
                Console.WriteLine("\n\n");
                Console.WriteLine("No problem, we can modify your order!");
                Console.WriteLine($"Press any key to continue.");
                Console.ReadKey();
                OrderManager(orderBread, orderPastry);
            }
        }

        static void OrderLoop(Order orderType, string[] itemNames)
        {
            Console.WriteLine("\n\n");
            Console.WriteLine($"Let's get your order for {itemNames[0]} down.");
            Thread.Sleep(750);
            TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
            Console.WriteLine($"{ti.ToTitleCase(itemNames[0])}: ${orderType.Price} per");
            Thread.Sleep(750);
            Console.WriteLine($"For every {orderType.DiscountRate} you order, one will be free!");
            Thread.Sleep(750);
            Console.WriteLine($"You currently have {orderType.Quantity} ordered.");
            Console.WriteLine(
                $"Would you like to order more {itemNames[1]}? <Enter> to continue, or any other key to skip."
            );
            ConsoleKeyInfo input = Console.ReadKey();
            if (input.Key == ConsoleKey.Enter)
            {
                Console.WriteLine("\nGreat! Please enter how many you'd like to order:");
                string? quantityInput = Console.ReadLine();
                try
                {
                    quantityInput?.All(Char.IsDigit);
                    orderType.Quantity = Int32.Parse(quantityInput);
                    Console.WriteLine($"Very well! I've updated your order to {quantityInput}.");
                    Console.WriteLine(
                        $"You've now ordered {orderType.Quantity} {itemNames[1]} for a total price of ${orderType.GetTotal()}."
                    );
                    Console.WriteLine($"Press any key to continue.");
                    Console.ReadKey();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: {0}", ex.Message);
                    Console.WriteLine($"Press any key to continue");
                    Console.ReadKey();
                    OrderLoop(orderType, itemNames);
                }
            }
        }
    }
}
