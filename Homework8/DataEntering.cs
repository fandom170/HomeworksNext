using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8
{
    class DataEntering
    {
        public void DataSelection()
        {
            Console.WriteLine("Please enter \"Y\"  if you want to enter extra data.\n Enter any other value for continue processing.");
            while (true)
            {
                String processingChoince = Console.ReadLine().ToLower();
                if (processingChoince.Equals("y")) 
                {
                    Console.WriteLine("Please enter type of entitity which you do want to enter:\n" +
                        " \"O\" for \"Order\"" +
                        "\"C\" for \"Customer\" " +
                        "\"S\" for Shipment\n " +
                        "Any other value leads to continue JSON processing.");
                    String itemType = Console.ReadLine().ToLower();
                    if (itemType.Equals("o"))
                    {
                        NewOrder();
                    }
                    else if (itemType.Equals("c"))
                    {
                        NewCustomer();
                    }
                    else if (itemType.Equals("s"))
                    {
                        NewShipment();
                    }
                    else 
                    {
                        break;
                    }
                }
                else {break;}

            }

            Console.WriteLine("All shipments from datasource will be printed now.\n" +
                "Do yu want to see orders inside each of shipment?\n" +
                "Please enter \"Y\" if you want to see orders");
            String printOrders = Console.ReadLine().ToLower();
            if (printOrders.Equals("y"))
            {
                //print with orders
            }
            else 
            { 
                //print without orders
            }
        }
        
        public void NewShipment() 
        { 
            //add shipments to the list
        }
        public void NewCustomer() 
        { 
            //add customer to the list
        }
        public void NewOrder() 
        { 
            //add oorders to the list
        }
    }
}
