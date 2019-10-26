using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Hatch
{
    public partial class SearchQuotes : Form
    {
        public SearchQuotes()
        {
            InitializeComponent();
            //Declare placeholder variable for holding the materials array
            var materials = new List<Desk.DesktopMaterial>();
            //Grab values from the Enum
            materials = Enum.GetValues(typeof(Desk.DesktopMaterial))
                            .Cast<Desk.DesktopMaterial>()
                            .ToList();
            comSurfaceMaterial.DataSource = materials;
            // Start the drop box at index -1
            comSurfaceMaterial.SelectedIndex = -1;
        }
        private void loadGrid()
        {
            //Acquire the file
            var quotesFile = @"quotes.json";
            using (StreamReader reader = new StreamReader(quotesFile))
            {
                // All the created quotes will load.
                string quotes = reader.ReadToEnd();
                List<DeskQuote> deskQuotes = JsonConvert.DeserializeObject<List<DeskQuote>>(quotes);
                dataGridView1.DataSource = deskQuotes.Select(d => new
                {
                    Date = d.QuoteDate
                    , Customer = d.CustomerName
                    , Depth = d.Desk.Depth
                    , Width = d.Desk.Width
                    , Drawers = d.Desk.NumberOfDrawers
                    , SurfaceMaterial = d.Desk.SurfaceMaterial
                    , DeliveryType = d.ShippingType
                    , QuoteAmount = d.QuotePrice.ToString("c")
                }).ToList();
            }
        }
        private void loadGrid(String surfaceMat)
        {
            //var surfaceMat = surfaceMat;
            //Acquire the file
            var quotesFile = @"quotes.json";
            using (StreamReader reader = new StreamReader(quotesFile))
            {
                // All the created quotes will load.
                string quotes = reader.ReadToEnd();
                List<DeskQuote> deskQuotes = JsonConvert.DeserializeObject<List<DeskQuote>>(quotes);
                dataGridView1.DataSource = deskQuotes.Select(d => new
                {
                    Date = d.QuoteDate
                    , Customer = d.CustomerName
                    , Depth = d.Desk.Depth
                    , Width = d.Desk.Width
                    , Drawers = d.Desk.NumberOfDrawers
                    , SurfaceMaterial = d.Desk.SurfaceMaterial
                    , DeliveryType = d.ShippingType
                    , QuoteAmount = d.QuotePrice.ToString("c")
                })
                    //.Where(q => q.SurfaceMaterial == surfaceMat)
                    .ToList();
            }
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            var MainMenu = new MainMenu();
            MainMenu.Tag = this;
            MainMenu.Show();
            this.Hide();
        }

        private void comSurfaceMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadGrid(this.comSurfaceMaterial.SelectedIndex.ToString());
        }
    }
}
