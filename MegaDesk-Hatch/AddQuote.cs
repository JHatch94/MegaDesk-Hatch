using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace MegaDesk_Hatch
{
    public partial class AddQuote : Form
    {
        // private Form _mainMenu;
        public AddQuote( )
        {   //Form mainMenu
            InitializeComponent();
            //_mainMenu = mainMenu
        }

        private void AddQuote_Load(object sender, EventArgs e)
        {
            //Populate SurfaceMaterials dropdown menu
            var materials = new List<Desk.DesktopMaterial>();

            materials = Enum.GetValues(typeof(Desk.DesktopMaterial))
                            .Cast<Desk.DesktopMaterial>()
                            .ToList();
            comSurfaceMaterial.DataSource = materials;
            // Begin at index -1
            comSurfaceMaterial.SelectedIndex = -1;

            //Populate shipping type dropdown menu
            var shipping = new List<DeskQuote.Delivery>();
            shipping = Enum.GetValues(typeof(DeskQuote.Delivery))
                            .Cast<DeskQuote.Delivery>()
                            .ToList();
            comShippingMethod.DataSource = shipping;
            //Begin at index 0
            comShippingMethod.SelectedIndex = 0;
        }

        private void Get_NewQuote_Click(object sender, EventArgs e)
        {
           
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            var MainMenu = new MainMenu();
            MainMenu.Tag = this;
            MainMenu.Show();
            this.Hide();
        }

        private void NumDrawers_ValueChanged(object sender, EventArgs e)
        {

        }

        //Get quote functionality
        private void BtnGetQuote_Click(object sender, EventArgs e)
        {
            var desk = new Desk();

            desk.Depth = numDepth.Value;
            desk.Width = numWidth.Value;
            desk.NumberOfDrawers = numDrawers.Value;
            desk.SurfaceMaterial = (Desk.DesktopMaterial)comSurfaceMaterial.SelectedValue;
            //Create new deskquote
            var deskQuote = new DeskQuote();

            deskQuote.Desk = desk;
            DateTime today = DateTime.Today;
            deskQuote.CustomerName = txtCustName.Text;
            //deskQuote.ShippingType = ;
            deskQuote.QuoteDate = today;
            deskQuote.QuotePrice = deskQuote.GetQuotePrice();

            //show displayquote form
            DisplayQuote NewDeskForm = new DisplayQuote(deskQuote);
            NewDeskForm.Tag = this.Tag;
            NewDeskForm.Show();
            Hide();

        }


        private void widthupanddown_Validating(object sender, CancelEventArgs e)
        {
            //size of desk in width(min 24"; max 96"
        }
        private void depthupdown_KeyPress(object sender, KeyPressEventArgs e)
        {
            //size of desk in  depth (min 12"; max 48")
        }
        
        // Close the program
        private void AddQuote_FormClosed(object sender, FormClosedEventArgs e)
        {
            var mainMenu = (Form)this.Tag;
            mainMenu.Show();
        }
    }
}
