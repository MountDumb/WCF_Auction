using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace WCF_Auction
{
    [DataContract]
    class Bid
    {
        public int ItemNumber { get; private set; }
        public int BidPrice { get; private set; }
        public string CustomerName { get; private set; }
        public string CustomerNumber { get; set; } 
        
    
        public Bid(int itemNumber, int bidPrice, string customerName, string customerNumber)
        {
            ItemNumber = itemNumber;
            BidPrice = bidPrice;
            CustomerName = customerName;
            CustomerNumber = customerNumber;
        }
    }
}
