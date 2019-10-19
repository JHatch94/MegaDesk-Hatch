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

            var materials = new List<Desk.DesktopMaterial>();

            materials = Enum.GetValues(typeof(Desk.DesktopMaterial))
                            .Cast<Desk.DesktopMaterial>()
                            .ToList();
            comSurfaceMaterial.DataSource = materials;

            comSurfaceMaterial.SelectedIndex = -1;
        }
        private void loadGrid()
        {
            var materials = Enum.GetValues(typeof(Desk.DesktopMaterial))
                           .Cast<Desk.DesktopMaterial>()
                           .ToString();
            comSurfaceMaterial.DataSource = materials;

            //Acquire the file
            var quotesFile = @"quotes.json";
            using (var reader = new StreamReader(quotesFile))
            {
                string quotes = reader.ReadToEnd();
                List<DeskQuote> deskQuotes = JsonConvert.DeserializeObject<List<DeskQuote>>(quotes);

                dataGridView1.DataSource = deskQuotes.Select(d => new
                {
                    Date = d.QuoteDate
                    ,Customer = d.CustomerName
                    ,Depth = d.Desk.Depth
                    ,Width = d.Desk.Width
                    ,Drawers = d.Desk.NumberOfDrawers
                    ,SurfaceMaterial = d.Desk.SurfaceMaterial
                    ,DeliveryType = d.ShippingType
                    ,QuoteAmount = d.QuotePrice.ToString("c")
                }).Where(q => q.SurfaceMaterial.ToString() == materials)
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
            loadGrid();
        }
    }
}
