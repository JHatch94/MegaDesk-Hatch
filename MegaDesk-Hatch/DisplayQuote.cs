using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Hatch
{
    public partial class DisplayQuote : Form
    {

        private DeskQuote _deskQuote;
        public DisplayQuote(DeskQuote NewDeskQuote)
        {
            InitializeComponent();
            // we neeed to match these variables from your yours.
            _deskQuote = NewDeskQuote;
          //  widthupanddown.Value = NewDeskQuote.Desk.Width;
          //  depthupdown.Value = NewDeskQuote.Desk.Depth;
           // DesktopMaterial.SelectedValue = NewDeskQuote.Desk.SurfaceMaterial;
           // Num_Drawers.SelectedValue = NewDeskQuote.Desk.NumberOfDrawers;
           // Delivery_Time.SelectedValue = NewDeskQuote.ShippingType;
          //  CustomerName.Text = NewDeskQuote.CustomerName;
           // TotalPrice.Text = NewDeskQuote.QuotePrice.ToString();
        }

        private void DisplayQuote_Load(object sender, EventArgs e)
        {
            var mainMenu = new MainMenu();
            mainMenu.Show();
            Close();
        }
        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
