using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Hatch
{
    public class DeskQuote
    {
        public enum Delivery
        {
            Standard
            , Rush3
            , Rush5
            , Rush7
        }

        public string CustomerName { get; set; }

        public DateTime QuoteDate { get; set; }


        public decimal QuotePrice { get; set; }

        public Desk Desk { get; set; }

        public decimal GetQuotePrice() {

            //TODO: add logic to calculate price
            return QuotePrice;
        }

    }
}
