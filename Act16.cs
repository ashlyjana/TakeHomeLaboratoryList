using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> cart = new List<string>();
            bool running = true;

            while (running)
            {
                Console.WriteLine("\nShopping Cart Menu:");
                Console.WriteLine("1. Add item");
                Console.WriteLine("2. Remove item");
                Console.WriteLine("3. View cart");
                Console.WriteLine("4. Clear cart");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter item to add: ");
                        string addItem = Console.ReadLine();
                        cart.Add(addItem);
                        Console.WriteLine("Item added to cart.");
                        break;

                    case 2:
                        Console.Write("Enter item to remove: ");
                        string removeItem = Console.ReadLine();
                        if (cart.Contains(removeItem))
                        {
                            cart.Remove(removeItem);
                            Console.WriteLine("Item removed from cart.");
                        }
                        else
                        {
                            Console.WriteLine("Item not found in cart.");
                        }
                        break;

                    case 3:
                        Console.WriteLine("\nYour Cart:");
                        if (cart.Count == 0)
                        {
                            Console.WriteLine("(empty)");
                        }
                        else
                        {
                            for (int i = 0; i < cart.Count; i++)
                            {
                                Console.WriteLine($"{i + 1}. {cart[i]}");
                            }
                        }
                        break;

                    case 4:
                        cart.Clear();
                        Console.WriteLine("Cart cleared.");
                        break;

                    case 5:
                        running = false;
                        Console.WriteLine("Exiting Shopping Cart System...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }
    }
}
