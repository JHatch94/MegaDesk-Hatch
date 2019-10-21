using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MegaDesk_Hatch
{
    public class DeskQuote
    {
        //Constructor? I'm not sure what this is here for, or if we actually need it
        public DeskQuote()
        {

        }

        //Declare rush delivery options
        public enum Delivery
        {
            Standard
            , Rush3
            , Rush5
            , Rush7
            , Rush14
        }

        // Create array to store the rush order price values
        int[,] rushOrderPrices = getRushOrderPrices();

        //Store value constants
        const decimal BASE_DESK_PRICE = 200.0M;
        const decimal SURFACE_AREA_COST = 1.0M;
        const decimal DRAWER_COST = 50.0M;
        const decimal OAK_COST = 200.0M;
        const decimal LAMINATE_COST = 100.0M;
        const decimal PINE_COST = 50.0M;
        const decimal ROSEWOOD_COST = 300.0M;
        const decimal VENEER_COST = 125.0M;

        // Creates the rush order pricing array and populate it with usable values
        public static int[,] getRushOrderPrices()
        {
            try
            {
                // Declare variable for reference to file
                String pricesFile = @"rushOrderPrices.txt";
                
                // Convert contents to int[]
                int[] prices = Array.ConvertAll(File.ReadAllLines(pricesFile), int.Parse);
                
                //Declare rush order pricing array
                int[,] rushOrderPrices = new int[3, 3];
                
                // Populate rushOrderPrices array with values from file
                int i = 0;
                int j = 0;
                for (int k = 0; k <prices.Length;  k++)
                {
                    rushOrderPrices[i, j] = prices[k];
                    if (j == 2)
                    {i++; j = 0; } 
                        else{j++;}
                }
                return rushOrderPrices;
            }
            catch (Exception e)
            {
                throw;
            }
        }

        // Declare methods
        public string CustomerName { get; set; }
        public DateTime QuoteDate { get; set; }
        public decimal QuotePrice { get; set; }
        public Desk Desk { get; set; }
        public Delivery ShippingType { get; set; }

        public decimal GetQuotePrice()
        {
            // Base price
            decimal runningTotal = BASE_DESK_PRICE;
            
            // Caclulate surface area
            var surfaceArea = this.Desk.Width * this.Desk.Depth;
            
            // Base surface area price
            var surfaceAreaPrice = 0M;
            
            // If surface area > 1000 logic
            if (surfaceArea > 1000)
                {surfaceAreaPrice = (surfaceArea - 1000) * SURFACE_AREA_COST; }
            runningTotal += surfaceAreaPrice;

            // Calculate drawer cost + add to running total
            var drawerCost = this.Desk.NumberOfDrawers * DRAWER_COST;
            runningTotal += drawerCost;

            // TODO: Could the following line be removed?
            // decimal surfaceMaterialCost;

            // Move surface material to usable variable
            var surfaceMat = this.Desk.SurfaceMaterial;
            // Determine cost based on user selection
            switch (surfaceMat)
            {
                case Desk.DesktopMaterial.Oak:
                    runningTotal += OAK_COST;
                    break;
                case Desk.DesktopMaterial.Laminate:
                    runningTotal += LAMINATE_COST;
                    break;
                case Desk.DesktopMaterial.Pine:
                    runningTotal += PINE_COST;
                    break;
                case Desk.DesktopMaterial.Rosewood:
                    runningTotal += ROSEWOOD_COST;
                    break;
                case Desk.DesktopMaterial.Veneer:
                    runningTotal += VENEER_COST;
                    break;
            }
            // Determine shipping type
            switch (this.ShippingType)
            {
                case Delivery.Rush3:    // Rush 3 day shipping
                    if (surfaceArea < 1000)
                        {runningTotal += rushOrderPrices[0, 0];}
                    else if (surfaceArea >= 1000 && surfaceArea <= 2000)
                        {runningTotal += rushOrderPrices[0, 1];}
                    else
                        {runningTotal += rushOrderPrices[0, 2];}
                    break;
                case Delivery.Rush5:    // Rush 5 day shipping
                    if (surfaceArea < 1000)
                        {runningTotal += rushOrderPrices[1, 0];}
                    else if (surfaceArea >= 1000 && surfaceArea <= 2000)
                        {runningTotal += rushOrderPrices[1, 1]; }
                    else
                        {runningTotal += rushOrderPrices[1, 2];}
                    break;
                case Delivery.Rush7:    // Rush 7 day shipping
                    if (surfaceArea < 1000)
                        {runningTotal += rushOrderPrices[2, 0]; }
                    else if (surfaceArea >= 1000 && surfaceArea <= 2000)
                        {runningTotal += rushOrderPrices[2, 1];}
                    else
                        { runningTotal += rushOrderPrices[2, 2];}
                    break;
                default:    // Standard no rush shipping
                    runningTotal += 0;
                    break;
            }
         return runningTotal;

        }
    }
}
