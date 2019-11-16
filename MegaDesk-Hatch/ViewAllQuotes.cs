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
    public partial class ViewAllQuotes : Form
    {
        private Form _MainMenu;

        public ViewAllQuotes(Form MainMenu)
        {
            InitializeComponent();

            _MainMenu = MainMenu;

            loadGrid();
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
                grdDisplayQuotes.DataSource = deskQuotes.Select(d => new
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

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            var MainMenu = new MainMenu();
            MainMenu.Tag = this;
            MainMenu.Show();
            this.Hide();
        }
    }
}
