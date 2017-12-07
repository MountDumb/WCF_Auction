using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCF_Auction
{
    public class AuctionRepository
    {
        private static AuctionRepository instance;
        private List<AuctionItem> auctionItems;

        public static AuctionRepository Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AuctionRepository();
                }
                return instance;
            }
        }

        private AuctionRepository()
        {
            auctionItems = new List<AuctionItem>();
            auctionItems.Add(new AuctionItem(12345, "Rocket", 2934));
            auctionItems.Add(new AuctionItem(11111, "Racoon", 2568));
            auctionItems.Add(new AuctionItem(87424, "Space Boy", 6666));
            auctionItems.Add(new AuctionItem(43945, "Søren", 8406));
        }

        public List<AuctionItem> GetItems()
        {
            return auctionItems.ToList();
        }
    }
}
