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
    public partial class AddQuote : Form
    {
        // private Form _mainMenu;
        public AddQuote( )
        {   //Form mainMenu
            InitializeComponent();
            //_mainMenu = mainMenu;

            //Populate SurfaceMaterials dropdown menu
            var materials = new List<Desk.DesktopMaterial>();

            materials = Enum.GetValues(typeof(Desk.DesktopMaterial))
                            .Cast<Desk.DesktopMaterial>()
                            .ToList();
            comSurfaceMaterial.DataSource = materials;

            comSurfaceMaterial.SelectedIndex = -1;

            //Populate shipping type dropdown menu
            var shipping = new List<DeskQuote.Delivery>();

            shipping = Enum.GetValues(typeof(DeskQuote.Delivery))
                            .Cast<DeskQuote.Delivery>()
                            .ToList();
            comShippingMethod.DataSource = shipping;

            comShippingMethod.SelectedIndex = 0;


        }

        private void AddQuote_FormClosed(object sender, FormClosedEventArgs e)
        {
            var mainMenu = (Form)this.Tag;
            mainMenu.Show();
        }
        private void AddQuote_Load(object sender, EventArgs e)
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

        private void BtnGetQuote_Click(object sender, EventArgs e)
        {
            var desk = new Desk();

            desk.Depth = numDepth.Value;
            desk.Width = numWidth.Value;


            var DeskQuote = new DeskQuote();

        }
    }
}
