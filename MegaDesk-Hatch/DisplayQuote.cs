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
    public partial class DisplayQuote : Form
    {

        private DeskQuote _deskQuote;
        public DisplayQuote(DeskQuote NewDeskQuote)
        {
            InitializeComponent();

          numWidth.Value = NewDeskQuote.Desk.Width;
          numDepth.Value = NewDeskQuote.Desk.Depth;
          txtSurfaceMaterial.Text = NewDeskQuote.Desk.SurfaceMaterial.ToString();
          numDrawers.Value = NewDeskQuote.Desk.NumberOfDrawers;
          txtShippingMethod.Text = NewDeskQuote.ShippingType.ToString();
          txtCustName.Text = NewDeskQuote.CustomerName.ToString();
          txtPrice.Text = NewDeskQuote.QuotePrice.ToString();
        }

        private void DisplayQuote_Load(object sender, EventArgs e)
        {
        }
        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void DisplayQuote_Load_1(object sender, EventArgs e)
        {

        }

        private void DisplayQuote_FormClosed(object sender, FormClosedEventArgs e)
        {
            var mainMenu = (Form)this.Tag;
            mainMenu.Show();
        }

        private void btnSubmitQuote_Click(object sender, EventArgs e)
        {

            try
            {
                var deskQuote = _deskQuote;
                // add quote to file
                AddQuoteToFile(deskQuote);
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

    }
}
