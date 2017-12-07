using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace WCF_Auction
{
    [DataContract]
    public class AuctionItem
    {
        [DataMember]
        public int ItemNumber { get; private set; }
        [DataMember]
        public string ItemDescription { get; private set; }
        [DataMember]
        public int RatedPrice { get; private set; }
        [DataMember]
        public  int BidPrice { get; private set; }
        [DataMember]
        public string CustomerName { get; private set; }
        [DataMember]
        public string CustomerNumber { get; private set; }
        [DataMember]
        public DateTime BidTime { get; private set; }

        public AuctionItem(int itemNumber, string itemDescription, int ratedPrice)
        {
            ItemNumber = itemNumber;
            ItemDescription = itemDescription;
            RatedPrice = ratedPrice;
            BidPrice = 0;
            CustomerName = "";
            CustomerNumber = "";
            BidTime = DateTime.Now;
        }


    }
}
