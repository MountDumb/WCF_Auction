using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionClient
{
    class Program
    {
        
        private AuctionService.AHServiceClient asc;
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Run();
        }

        void Run()
        {
            asc = new AuctionService.AHServiceClient();
            Console.WriteLine(asc.GetAuctionItems());
            Console.Read();
            
        }
    }
}
