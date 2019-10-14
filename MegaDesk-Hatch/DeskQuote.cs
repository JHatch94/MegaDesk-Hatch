using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Hatch
{
    public class DeskQuote
    {
        public DeskQuote(){
            getRushOrderPrices();

        }
        private int[,] _rushOrderPrices;

        const decimal BASE_DESK_PRICE = 200.0M;
        const decimal SURFACE_AREA_COST = 1.0M;
        const decimal DRAWER_COST = 50.0M;
        const decimal OAK_COST = 200.0M;
        const decimal LAMINATE_COST = 100.0M;
        const decimal PINE_COST = 50.0M;
        const decimal ROSEWOOD_COST = 300.0M;
        const decimal VENEER_COST = 125.0M;


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

        public Delivery ShippingType { get; set; }

        public decimal GetQuotePrice() {

            decimal runningTotal = BASE_DESK_PRICE;

            var surfaceArea = this.Desk.Width * this.Desk.Depth;

            var surfaceAreaPrice = 0M;

            if (surfaceArea > 1000)
            {
                surfaceAreaPrice = (surfaceArea - 1000) * SURFACE_AREA_COST;
            }

            runningTotal += surfaceAreaPrice;
            
            
            //add drawer
            var drawerCost = this.Desk.NumberOfDrawers * DRAWER_COST;

            runningTotal += drawerCost;

            // add surface materials
            decimal surfaceMaterialCost;
            var surfaceMat = this.Desk.SurfaceMaterial;

            switch (surfaceMat)
            {
                case Desk.DesktopMaterial.Oak:
                    surfaceMaterialCost = OAK_COST;
                    break;
                case Desk.DesktopMaterial.Laminate:
                    surfaceMaterialCost = LAMINATE_COST;
                    break;
                case Desk.DesktopMaterial.Pine:
                    surfaceMaterialCost = PINE_COST;
                    break;
                case Desk.DesktopMaterial.Rosewood:
                    surfaceMaterialCost = ROSEWOOD_COST;
                    break;
                case Desk.DesktopMaterial.Veneer:
                    surfaceMaterialCost = VENEER_COST;
                    break;   
            }

            //TODO: add logic to calculate price
            return QuotePrice;


            //TODO add shipping cost

            return runningTotal;
        }
        private void getRushOrderPrices()
        {
            _rushOrderPrices = new int[3, 3];
            var pricesFile = @"rushOrderPrices.txt";

            try
            {
                string[] prices = File.ReadAllLines(pricesFile);
                int i = 0, j = 0;

                foreach (string price in prices)
                {
                    _rushOrderPrices[i, j] = int.Parse(price);
                    if (j ==2)
                    {
                        i++;
                        j = 0;
                    }
                    else
                    {
                        j++;
                    }
                }
            }
            catch (Exception e)
            {
                throw;
            }
        }
    }
}
