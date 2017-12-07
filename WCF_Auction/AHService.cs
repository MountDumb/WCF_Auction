using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Auction
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class AHService : IAHService
    {
        public string GetAuctionItems()
        {
            string output = "Current Items:" + System.Environment.NewLine;
            foreach (var item in AuctionRepository.Instance.GetItems())
            {
                output += $"ItemNr: {item.ItemNumber}, Description: {item.ItemDescription}, Rated Price: {item.RatedPrice}{System.Environment.NewLine}" +
                    $"Current Bid: {item.BidPrice}, Highest Bidder: {item.CustomerName}, Latest Bid: {item.BidPrice}{System.Environment.NewLine}{System.Environment.NewLine}";
            }
            return output;
        }
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        //public CompositeType GetDataUsingDataContract(CompositeType composite)
        //{
        //    if (composite == null)
        //    {
        //        throw new ArgumentNullException("composite");
        //    }
        //    if (composite.BoolValue)
        //    {
        //        composite.StringValue += "Suffix";
        //    }
        //    return composite;
        //}
    }
}
