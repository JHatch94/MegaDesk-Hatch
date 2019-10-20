﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Hatch
{


    public class DeskQuote
    {
        const decimal BASE_DESK_PRICE = 200.0M;
        const decimal SURFACE_AREA_COST = 1.0M;
        const decimal DRAWER_COST = 50.0M;
        const decimal OAK_COST = 200.0M;
        const decimal LAMINATE_COST = 100.0M;
        const decimal PINE_COST = 50.0M;
        const decimal ROSEWOOD_COST = 300.0M;
        const decimal VENEER_COST = 125.0M;

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

                foreach (int k in prices)
                {
                    int i = 0;
                    int j = 0;
                    rushOrderPrices[i, j] = prices[k];
                    if (j < 2)
                    {
                        i++;
                        j = 0;
                    }
                    else
                    {
                        j++;
                    }
                }
                return rushOrderPrices;
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public DeskQuote()
        {
            var rushOrderPrices = getRushOrderPrices();

            decimal RUSH_3DAY_LESS_THAN_1000 = rushOrderPrices[0, 0];
            decimal RUSH_3DAY_1000_TO_2000 = rushOrderPrices[0, 1];
            decimal RUSH_3DAY_GREATER_THAN_2000 = rushOrderPrices[0, 2];
            decimal RUSH_5DAY_LESS_THAN_1000 = rushOrderPrices[1, 0];
            decimal RUSH_5DAY_1000_TO_2000 = rushOrderPrices[1, 1];
            decimal RUSH_5DAY_GREATER_THAN_2000 = rushOrderPrices[1, 2];
            decimal RUSH_7DAY_LESS_THAN_1000 = rushOrderPrices[2, 0];
            decimal RUSH_7DAY_1000_TO_2000 = rushOrderPrices[2, 1];
            decimal RUSH_7DAY_GREATER_THAN_2000 = rushOrderPrices[2, 2];

        }
        public enum Delivery
        {
            Standard
            , Rush3
            , Rush5
            , Rush7
            , Rush14

        }
        // Declare methods
        public string CustomerName { get; set; }
        public DateTime QuoteDate { get; set; }
        public decimal QuotePrice { get; set; }
        public Desk Desk { get; set; }
        public Delivery ShippingType { get; set; }

        public decimal GetQuotePrice()
        {

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
            switch (this.ShippingType)
            {
                case Delivery.Rush3:
                    if (surfaceArea < 1000)
                    {
                        runningTotal += 60;
                    }
                    else if (surfaceArea >= 1000 && surfaceArea <= 2000)
                    {
                        runningTotal += 70;
                    }
                    else
                    {
                        runningTotal += 80;
                    }
                    break;

                case Delivery.Rush5:
                    if (surfaceArea < 1000)
                    {
                        runningTotal += 40;
                    }
                    else if (surfaceArea >= 1000 && surfaceArea <= 2000)
                    {
                        runningTotal += 50;
                    }
                    else
                    {
                        runningTotal += 60;
                    }
                    break;

                case Delivery.Rush7:
                    if (surfaceArea < 1000)
                    {
                        runningTotal += 30;
                    }
                    else if (surfaceArea >= 1000 && surfaceArea <= 2000)
                    {
                        runningTotal += 35;
                    }
                    else
                    {
                        runningTotal += 40;
                    }
                    break;

                default:
                    runningTotal += 0;
                    break;
            }
            return runningTotal;
        }
    }
}
