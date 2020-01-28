using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8
{
    class JSONClass
    {
        public Shipment [] shipments { get; set; }
        public string shipmentId { get; set; }
        public string address { get; set;}
        public Order[] orders { get; set;}
        public Guid customer { get; set; }
        public int id { get; set; }
        public string type { get; set;}
        public int qty { get; set; }
    }

    /*JSON file structure
         * [{"shipments":[{
         *                 "shipmentId": "xxxx",          //string
         *                 "address": "aaaa",             //string
         *                 "order": [{
         *                            "id":"iii",        //int
         *                            "customer":"cccc", //Guid
         *                            "type":"tttt",     //string
         *                            "qty":"qqqq"       //int
         *                            }]
         *                  }, 
         *                  {...}
         *              ]}
         * ]
         
             */

       
}
