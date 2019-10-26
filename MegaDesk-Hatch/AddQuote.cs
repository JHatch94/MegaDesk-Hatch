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

        //ON BUTTON CLICK
        private void BtnGetQuote_Click(object sender, EventArgs e)
        {
            var desk = new Desk();

            //desk.Depth = numDepth.Value;
            //desk.Width = numWidth.Value;
            //desk.SurfaceMaterial = comSurfaceMaterial.SelectedValue.ToString();

            var DeskQuote = new DeskQuote();
            //This if statement is to check if the add quote form is complete.

            // gets the information of the desk.  // needs to fill up this section
            Desk NameOfNewDesk = new Desk();

            //gets the information entered by the user. // needs to fill up this section
            DeskQuote NewDeskQuote = new DeskQuote();

            // get the quote amount and add amount to quote

            NewDeskQuote.Desk = NameOfNewDesk;
            DateTime today = DateTime.Today;
            NewDeskQuote.QuoteDate = today;
            NewDeskQuote.QuotePrice = NewDeskQuote.GetQuotePrice();


            try
            {
                // add quote to file
                AddQuoteToFile(NewDeskQuote);

                //show displayquote form
                DisplayQuote NewDeskForm = new DisplayQuote(NewDeskQuote);
                NewDeskForm.Show();
                Hide();
            }
            catch (Exception err)
            {
                MessageBox.Show("There was an error creating the quote. {0}", err.Message);
            }

        }

        //gets the new quote and adds it to the new file
        private void AddQuoteToFile(DeskQuote deskQuote)
        {
            List<DeskQuote> deskQuotes = new List<DeskQuote>();
            if (!File.Exists(@"quotes.json"))
            {
                deskQuotes.Add(deskQuote);
                var list = JsonConvert.SerializeObject(deskQuotes);
                File.WriteAllText(@"quotes.json", JsonConvert.SerializeObject(deskQuotes));
            }
            else
            {
                using (StreamReader reader = new StreamReader(@"quotes.json"))
                {
                    string allQuotes = reader.ReadToEnd();
                    deskQuotes = JsonConvert.DeserializeObject<List<DeskQuote>>(allQuotes);
                }
                deskQuotes.Add(deskQuote);
                var list = JsonConvert.SerializeObject(deskQuotes);
                File.WriteAllText(@"quotes.json", list);
            }
        }

        private void SaveQuotes(List<DeskQuote> quotes)
        {
            var quotesFile = @"quotes.json";
            // serilize quotes

            var serializedQuotes = JsonConvert.SerializeObject(quotes);

            // write quotes to file
            File.WriteAllText(quotesFile, serializedQuotes);
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
