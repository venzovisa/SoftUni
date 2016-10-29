using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AndreyAndBilliard
{
    public class Customer {
        public String name;
        public Dictionary<String, int> order = new Dictionary<String, int>();
        public double bill;
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Customer> customers = new List<Customer>();
            Dictionary<String, double> menu = new Dictionary<String, double>();
            int amount = int.Parse(Console.ReadLine());
            String command = "";

            for (int i = 0; i < amount; i++)
            {
                String[] input = Console.ReadLine().Split('-');
                // add menu item
                if (!menu.ContainsKey(input[0]))
                {
                    menu.Add(input[0], double.Parse(input[1]));
                } // replace existent item price
                else {
                    menu[input[0]] = double.Parse(input[1]);
                }
            }
            command = Console.ReadLine();
            while (command != "end of clients") {
                
                String[] input = command.Split('-');
                String clientName = input[0];
                String[] clientOrder = input[1].Split(',');
                String clientOrderName = clientOrder[0];
                int clientOrderAmount = int.Parse(clientOrder[1]);
                // check customer for existence
                bool hasCustomer = false;
                for (int i = 0; i < customers.Count; i++)
                {
                    if (customers[i].name == clientName) {
                        hasCustomer = true; break;
                    }
                }
                // add customer and ignore duplicate item in menu
                if (!hasCustomer && menu.ContainsKey(clientOrderName)) { 
                    Customer newCustomer = new Customer();
                    newCustomer.name = clientName;
                    newCustomer.order.Add(clientOrderName, clientOrderAmount);
                    customers.Add(newCustomer); }
                command = Console.ReadLine();         
            }
            double totalBill = 0;
            // calculate customer bill
            for (int c = 0; c < customers.Count; c++)
            {
                for (int m = 0; m < menu.Count; m++)
			    {
                    double tempBill = 0;                    
                    for (int o = 0; o < customers[c].order.Count; o++)
                    {
                        if (menu.ElementAt(m).Key == customers[c].order.ElementAt(o).Key)
                            tempBill += customers[c].order.ElementAt(o).Value * menu.ElementAt(m).Value;
                        break;
                    }
                    customers[c].bill += tempBill;
			    }
                totalBill += customers[c].bill;
            }

            // sort cunstomers list
            customers = customers.OrderBy(a => a.name).ToList();

            // print result
            for (int c = 0; c < customers.Count; c++)
            {
                Console.WriteLine(customers[c].name);
                for (int o = 0; o < customers[c].order.Count; o++)
                {
                    Console.WriteLine("-- {0} - {1}", customers[c].order.ElementAt(o).Key,
                                                      customers[c].order.ElementAt(o).Value);
                }
                Console.WriteLine("Bill: {0:f2}", customers[c].bill);
            }
            Console.WriteLine("Total bill: {0:f2}", totalBill);
        }
    }
}
