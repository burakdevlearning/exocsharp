using Bmail.Dao;
using Bmail.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bmail
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private EmailDao mDao { get; set; }
        private CampaignDao cDao { get; set; }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            // Initialization of data access objects
            cDao = new CampaignDao();
            mDao = new EmailDao();

            // Getting every campaign
            var results = (await cDao.GetAll());

            // Adding campaign names to the list to show to the user
            listBox1.Items.AddRange(results.Select(c => c.Name).ToArray());

            // Adding campaign objects to the listbox
            listBox1.Tag = results;
        }

        // Delete campaign button
        private void button2_Click(object sender, EventArgs e)
        {
           
            
        }

        // View mails button
        private async void button4_Click(object sender, EventArgs e)
        {
            // Checking if an item (campaign) has been selected
            if (listBox1.SelectedItems.Count > 0)
            {
                // Getting every campaign added to the first list then filtering them by the selected campaign
                // finally assigning it to the variable
                int selectedCampaignId = ((List<Campaign>)listBox1.Tag)[listBox1.SelectedIndex].CampaignId;

                // Getting every email then filtering with the selected campaignId
                var results = (await mDao.GetAll())
                    .Where(c => c.CampaignId.Value == selectedCampaignId);

                // Clearing list if it is not the first time we pass through here
                listBox2.Items.Clear();
                // Adding the subjects of every mail in the list to be shown to the user
                listBox2.Items.AddRange(results.Select(e => e.Subject).ToArray());
                // Adding every mail to the listbox
                listBox2.Tag = results;
            }
            else
            {
                // popup
                MessageBox.Show("Select at least one campaign.");
            }
        }
    }
}
