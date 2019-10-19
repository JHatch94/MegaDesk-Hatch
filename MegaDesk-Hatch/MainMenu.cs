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
    public partial class MainMenu : Form
    {
        
        //Main menu initialize
        public MainMenu()
        {
            InitializeComponent();
        }

        //Add new quote button
        private void BtnAddNewQuote_Click(object sender, EventArgs e)
        {
            var addQuote = new AddQuote();
            addQuote.Tag = this;
            addQuote.Show();
            this.Hide();
        }

        //View all quotes button
        private void BtnViewQuotes_Click(object sender, EventArgs e)
        {
            var viewAllQuotes = new ViewAllQuotes(this);
            viewAllQuotes.Tag = this;
            viewAllQuotes.Show();
            this.Hide();
        }

        //Search quotes
        private void BtnSearchQuotes_Click(object sender, EventArgs e)
        {
            var searchQuotes = new SearchQuotes();
            searchQuotes.Tag = this;
            searchQuotes.Show();
            this.Hide();
        }

        //Exit the program
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
