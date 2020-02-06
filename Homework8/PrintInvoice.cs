using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8
{
    class PrintInvoice
    {
        private Invoice invoiceForPrint;
        private Boolean printOrders = false;
        public PrintInvoice(Invoice invoice, Boolean printOrders) 
        {
            this.invoiceForPrint = invoice;
            this.printOrders = printOrders;
        }

        public void PrintInvoices() 
        {
            //foreach (Shipment shipment in invoiceForPrint.shipments)
            //{
                //PrintShipment
                    //}
        }
        
    

        public void PrintShipment(Shipment shipment, Boolean printOrders)
        {
            Console.WriteLine("Shipment name = " + shipment.Name);
            //...
        }

        public void PrintOrder(Order order)
        {

        }
    }
}
