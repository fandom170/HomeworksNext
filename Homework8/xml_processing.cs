using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Homework8
{
    class Xml_processing
    {

        private void createXml(object sender, EventArgs e, Invoice invoice)
        {
            int shipmentsCount = 1;
            XmlTextWriter writer = new XmlTextWriter("ShipmentData.xml", System.Text.Encoding.UTF8);
            writer.WriteStartDocument(true);
            writer.Formatting = Formatting.Indented;
            writer.Indentation = 4;
            writer.WriteStartElement("Shipments");
            for (int i = 0; i < shipmentsCount; i++) 
            {
                creatShipmentNode(invoice.Shipments[i], writer);
            }
            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Close();
            Console.WriteLine("XML File created ! ");
        }

        private void createCustomerNode(Customer customer, XmlTextWriter writer) 
        {
            writer.WriteStartElement("CustomerId");
            writer.WriteString(customer.CustomerId.ToString());
            writer.WriteEndElement();
            writer.WriteStartElement("CustomerName");
            writer.WriteString(customer.CustomerName);
            writer.WriteEndElement();
        }

        private void createOrderNode(Order order, XmlTextWriter writer) 
        {
            writer.WriteStartElement("OrderId");
            writer.WriteString(order.OrderId.ToString());
            writer.WriteEndElement();
            writer.WriteStartElement("ProductQuantity");
            writer.WriteString(order.Quantity.ToString());
            writer.WriteEndElement();
            writer.WriteStartElement("ProductType");
            writer.WriteString(order.Type.ToString());
            writer.WriteEndElement();
            writer.WriteStartElement("Customer");
            createCustomerNode(order.Customer, writer);
            writer.WriteEndElement();
        }

        private void creatShipmentNode(Shipment shipment,  XmlTextWriter writer) 
        {
            writer.WriteStartElement("ShipmentId");
            writer.WriteString(shipment.Id);
            writer.WriteEndElement();
            writer.WriteStartElement("ShipmentName");
            writer.WriteString(shipment.Name);
            writer.WriteEndElement();
            writer.WriteStartElement("ShipmentAddress");
            writer.WriteString(shipment.Adress);
            writer.WriteEndElement();
            writer.WriteStartElement("OrderList");
            for (int i = 0; i < shipment.Orders.Count; i++) 
            {
                createOrderNode(shipment.Orders[i], writer);
            }
            writer.WriteEndElement();
        }
    }
}

//<shipments>
//  <shipmentId>Init1600</shipmentId>
//  <shipmentName>Init_Data_01</shipmentName>
//  <shipmentAddress>1600_Pennsylvania_Avenue</shipmentAddress>
//  <ordersList>
//    <orderId>0</orderId>
//    <productQuantity>10</productQuantity>
//    <productType>Bomb</productType>
//    <customer>
//      <customerId>9e7199f2-1c0e-487c-a7a8-b9c4601e455a</customerId>
//      <customerName>test</customerName>
//    </customer>
//  </ordersList>
//</shipments> 
